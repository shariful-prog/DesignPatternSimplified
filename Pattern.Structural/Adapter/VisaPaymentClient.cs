using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Structural.Adapter;

public class VisaPaymentClient : IPaymentProcessor
{
    public Task<PaymentResult> ProcessAsync(PaymentRequest request, CancellationToken ct = default)
    {
        // Simulate real payment processing
        Console.WriteLine($"[Visa] Charging {request.Amount} {request.Currency} to {request.CardNumber}");
        return Task.FromResult(new PaymentResult(true, "VISA12345", "Payment successful via Visa"));
    }

    public Task<RefundResult> RefundAsync(string transactionId, decimal amount, CancellationToken ct = default)
    {
        // Simulate refund processing
        Console.WriteLine($"[Visa] Refunding {amount} for transaction {transactionId}");
        return Task.FromResult(new RefundResult(true, "VISAREF123", "Refund successful via Visa"));
    }
}
