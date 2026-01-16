using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern.Structural.Adapter;

public static class PaymentProcessorFactory
{
    public static IPaymentProcessor CreateProcessor(string provider)
    {
        return provider.ToLower() switch
        {
            "paypal" => new PayPalAdapter(new OldPayPalClient()),
            "visa" => new VisaPaymentClient(),
            _ => throw new ArgumentException($"Unknown provider {provider}")
        };
    }


}
