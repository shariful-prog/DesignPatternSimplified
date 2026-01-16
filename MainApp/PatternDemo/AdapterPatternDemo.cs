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
        var paymentRequest = new PaymentRequest("4111111111111111", 100.00m, "USD");

        var paymentProcessor = new PayPalAdapter(new OldPayPalClient());
        var paymentResult = await paymentProcessor.ProcessAsync(paymentRequest);
        Console.WriteLine($"Payment Success: {paymentResult.Success}, Transaction ID: {paymentResult.TransactionId}, Message: {paymentResult.Message}");

        IPaymentProcessor visaClient = new VisaPaymentClient();
        var visaPaymentResult = await visaClient.ProcessAsync(paymentRequest);
        Console.WriteLine($"Payment Success: {visaPaymentResult.Success}, Transaction ID: {visaPaymentResult.TransactionId}, Message: {visaPaymentResult.Message}");



        //  to Make more abstructor we can combine this with Creational Pattern - Factory Method
        Console.WriteLine("-----------------------");
        Console.WriteLine("Using Factory to create Payment Processor instances");
        IPaymentProcessor factory = PaymentProcessorFactory.CreateProcessor("PayPal");
        var factoryPaymentResult = await factory.ProcessAsync(paymentRequest);
        Console.WriteLine($"Payment Success: {factoryPaymentResult.Success}, Transaction ID: {factoryPaymentResult.TransactionId}, Message: {factoryPaymentResult.Message}");



    }
}
