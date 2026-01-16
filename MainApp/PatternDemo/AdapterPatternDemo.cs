using Pattern.Structural.Adapter;
using System;
using System.Collections.Generic;
using System.Text;

namespace MainApp.PatternDemo;

internal class AdapterPatternDemo : IPatternDemo
{
    public async Task RunAsync()
    {
        Console.WriteLine("Starting Structural Pattern - Adapter");

        var paymentProcessor = new PayPalAdapter(new OldPayPalClient());
        var paymentRequest = new PaymentRequest("4111111111111111", 100.00m, "USD");
        var paymentResult = await paymentProcessor.ProcessAsync(paymentRequest);
        Console.WriteLine($"Payment Success: {paymentResult.Success}, Transaction ID: {paymentResult.TransactionId}, Message: {paymentResult.Message}");

        IPaymentProcessor visaClient = new VisaPaymentClient();
        var visaPaymentRequest = new PaymentRequest("5500000000000004", 50.00m, "USD");
        var visaPaymentResult = await visaClient.ProcessAsync(visaPaymentRequest);
        Console.WriteLine($"Payment Success: {visaPaymentResult.Success}, Transaction ID: {visaPaymentResult.TransactionId}, Message: {visaPaymentResult.Message}");

    }
}
