namespace Pattern.Creational.Factory;

public static class PaymentFactory
{
    public static IPaymentExecutor GetPaymentProcessor(string paymentType)
    {
        return paymentType.ToLower() switch
        {
            "creditcard" => new CreditCardPaymentProcessor(),
            "paypal" => new PayPalPaymentProcessor(),
            "bkash" => new BkashPaymentProcessor(),
            _ => throw new ArgumentException("Invalid payment type"),
        };
    }
}
