using Pattern.Behavioral.Strategy;

namespace MainApp.PatternDemo;

public class StrategyPatternDemo : IPatternDemo
{
    public Task RunAsync()
    {
        var priceCalculator = new PriceCalculator(new RegularPricing());

        Console.WriteLine("Regular Pricing:");
        priceCalculator.CalculatePrice(100);

        priceCalculator.SetStrategy(new PremiumPricing());
        Console.WriteLine("Premium Pricing:");
        priceCalculator.CalculatePrice(100);

        priceCalculator.SetStrategy(new FestivalPricing());
        Console.WriteLine("Festival Pricing:");
        priceCalculator.CalculatePrice(100);

        priceCalculator.SetStrategy(new CorporateDeal());
        Console.WriteLine("Corporate Deal:");
        priceCalculator.CalculatePrice(100);

        return Task.CompletedTask;
    }
}
