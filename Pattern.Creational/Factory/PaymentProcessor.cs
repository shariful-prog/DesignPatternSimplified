using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Creational.Factory;

public interface IPaymentExecutor
{
    void ProcessPayment(decimal amount);
}



public class CreditCardPaymentProcessor : IPaymentExecutor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing credit card payment of {amount:C}");
    }
}

public class PayPalPaymentProcessor : IPaymentExecutor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing PayPal payment of {amount:C}");
    }
}

public class BkashPaymentProcessor : IPaymentExecutor
{
    public void ProcessPayment(decimal amount)
    {
        Console.WriteLine($"Processing Bkash payment of {amount:C}");
    }
}