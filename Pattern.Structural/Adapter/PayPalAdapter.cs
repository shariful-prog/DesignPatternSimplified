namespace Pattern.Structural.Adapter;

public class PayPalAdapter : IPaymentProcessor
{
    private readonly OldPayPalClient _legacyClient;

    public PayPalAdapter(OldPayPalClient legacyClient)
    {
        _legacyClient = legacyClient;
    }
    public Task<PaymentResult> ProcessAsync(PaymentRequest request, CancellationToken ct = default)
    {
        var response = _legacyClient.MakePayment(request.CardNumber, (double)request.Amount, request.Currency);
        return Task.FromResult(ParsePaymentResult(response));
    }

    public Task<RefundResult> RefundAsync(string transactionId, decimal amount, CancellationToken ct = default)
    {
        var response = _legacyClient.RefundPayment(transactionId, (double)amount);
        return Task.FromResult(ParseRefundResult(response));
    }
    private PaymentResult ParsePaymentResult(string response)
    {
        var parameters = ParseResponse(response);
        bool success = parameters.TryGetValue("ACK", out var ack) && ack == "SUCCESS";
        parameters.TryGetValue("TRANSACTIONID", out var transactionId);
        parameters.TryGetValue("AMOUNT", out var amount);
        parameters.TryGetValue("CURRENCY", out var currency);
        string message = success ? $"Payment of {amount} {currency} processed successfully." : "Payment failed.";
        return new PaymentResult(success, transactionId ?? string.Empty, message);
    }
    private RefundResult ParseRefundResult(string response)
    {
        var parameters = ParseResponse(response);
        bool success = parameters.TryGetValue("ACK", out var ack) && ack == "SUCCESS";
        parameters.TryGetValue("REFUNDTRANSACTIONID", out var refundTransactionId);
        parameters.TryGetValue("AMOUNT", out var amount);
        string message = success ? $"Refund of {amount} processed successfully." : "Refund failed.";
        return new RefundResult(success, refundTransactionId ?? string.Empty, message);
    }
    private Dictionary<string, string> ParseResponse(string response)
    {
        var parameters = new Dictionary<string, string>();
        var pairs = response.Split('&', StringSplitOptions.RemoveEmptyEntries);
        foreach (var pair in pairs)
        {
            var keyValue = pair.Split('=', 2);
            if (keyValue.Length == 2)
            {
                parameters[keyValue[0]] = keyValue[1];
            }
        }
        return parameters;
    }


}
