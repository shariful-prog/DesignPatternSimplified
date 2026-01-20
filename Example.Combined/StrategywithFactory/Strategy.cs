using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Combined.StrategywithFactory;

// Base interface
public interface IDiscountStrategy
{
    decimal ApplyDiscount(decimal amount);
}

// No discount
public sealed class RegularCustomerDiscount : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal amount) => amount;
}

// Premium customer → 10% discount
public sealed class PremiumCustomerDiscount : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal amount) => amount * 0.90m;
}

// Festival offer → 20% discount
public sealed class FestivalDiscount : IDiscountStrategy
{
    public decimal ApplyDiscount(decimal amount) => amount * 0.80m;
}

// Corporate deal → custom discount
public sealed class CorporateDealDiscount : IDiscountStrategy
{
    private readonly decimal _discountPercentage;

    public CorporateDealDiscount(decimal discountPercentage)
    {
        _discountPercentage = discountPercentage;
    }

    public decimal ApplyDiscount(decimal amount) =>
        amount - (amount * _discountPercentage / 100);
}