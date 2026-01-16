namespace Pattern.Structural.Adapter;

public interface IPaymentProcessor
{
    Task<PaymentResult> ProcessAsync(PaymentRequest request, CancellationToken ct = default);
    Task<RefundResult> RefundAsync(string transactionId, decimal amount, CancellationToken ct = default);
}


public record PaymentRequest(string CardNumber,decimal Amount,string Currency);
public record PaymentResult(bool Success, string TransactionId, string Message);
public record RefundResult(bool Success, string RefundTransactionId, string Message);