using Example.Combined.StrategywithFactory;

namespace MainApp.PatternDemo;

public class FactoryStrategyDemo : IPatternDemo
{
    public Task RunAsync()
    {
        // Regular customer paying with Credit Card
        var creditCardPayment = PaymentFactory.CreatePayment("creditcard");
        creditCardPayment.SetDiscountStrategy(new RegularCustomerDiscount());
        creditCardPayment.ProcessPayment(100m);

        // Premium customer paying with PayPal
        var payPalPayment = PaymentFactory.CreatePayment("paypal");
        payPalPayment.SetDiscountStrategy(new PremiumCustomerDiscount());
        payPalPayment.ProcessPayment(100m);

        // Corporate deal paying with Credit Card (custom 25%)
        var corporatePayment = PaymentFactory.CreatePayment("creditcard");
        corporatePayment.SetDiscountStrategy(new CorporateDealDiscount(25));
        corporatePayment.ProcessPayment(100m);

        return Task.CompletedTask;
    }
}
