using System;
using System.Collections.Generic;
using System.Text;

namespace Example.Combined.StrategywithFactory;

public static class PaymentFactory
{
    public static IPayment CreatePayment(string paymentMethod)
    {
        return paymentMethod.ToLower() switch
        {
            "creditcard" => new CreditCardPayment(),
            "paypal" => new PayPalPayment(),
            "bkash" => new BkashPayment(),
            _ => throw new NotSupportedException("Payment method not supported")
        };
    }
}
