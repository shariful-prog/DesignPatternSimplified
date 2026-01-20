using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Combined.StrategywithFactory;

public interface IPayment
{
    void SetDiscountStrategy(IDiscountStrategy discountStrategy);
    void ProcessPayment(decimal amount);
}


// Credit Card Payment
public sealed class CreditCardPayment : IPayment
{
    private IDiscountStrategy _discountStrategy = new RegularCustomerDiscount();

    public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    public void ProcessPayment(decimal amount)
    {
        var finalAmount = _discountStrategy.ApplyDiscount(amount);
        Console.WriteLine($"Paid {finalAmount:C} using Credit Card.");
    }
}

// PayPal Payment
public sealed class PayPalPayment : IPayment
{
    private IDiscountStrategy _discountStrategy = new RegularCustomerDiscount();

    public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    public void ProcessPayment(decimal amount)
    {
        var finalAmount = _discountStrategy.ApplyDiscount(amount);
        Console.WriteLine($"Paid {finalAmount:C} using PayPal.");
    }
}

// bKash Payment
public sealed class BkashPayment : IPayment
{
    private IDiscountStrategy _discountStrategy = new RegularCustomerDiscount();

    public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
    {
        _discountStrategy = discountStrategy;
    }

    public void ProcessPayment(decimal amount)
    {
        var finalAmount = _discountStrategy.ApplyDiscount(amount);
        Console.WriteLine($"Paid {finalAmount:C} using bKash.");
    }
}

