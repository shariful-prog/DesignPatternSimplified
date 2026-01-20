using Pattern.Creational.Factory;
using Pattern.Structural.Adapter;
using System;
using System.Collections.Generic;
using System.Text;

namespace MainApp.PatternDemo;

public class FactoryPatternDemo : IPatternDemo
{
    public Task RunAsync()
    {
        string paymentType = "CreditCard";
        decimal amount = 150.00m;

        IPaymentExecutor paymentProcessor = PaymentFactory.GetPaymentProcessor(paymentType);
        paymentProcessor.ProcessPayment(amount);
        return Task.CompletedTask;

    }
}
