namespace Pattern.Behavioral.Strategy;

public class RegularPricing : IPricingStrategy
{
    public decimal CalculatePrice(decimal basePrice)
    {
        // No discount applied for regular customers
        Console.WriteLine($"Regular price applied: {basePrice:C}");
        return basePrice;
    }
}

public class PremiumPricing : IPricingStrategy
{
    public decimal CalculatePrice(decimal basePrice)
    {
        // Premium customers get a 10% discount
        decimal discount = basePrice * 0.10m;
        decimal finalPrice = basePrice - discount;

        Console.WriteLine($"Premium price applied: {finalPrice:C}");
        return finalPrice;
    }
}

public class FestivalPricing : IPricingStrategy
{
    public decimal CalculatePrice(decimal basePrice)
    {
        // Festival offer gives a 20% discount
        decimal finalPrice = basePrice * 0.80m;

        Console.WriteLine($"Festival price applied: {finalPrice:C}");
        return finalPrice;
    }
}

public class CorporateDeal : IPricingStrategy
{
    public decimal CalculatePrice(decimal basePrice)
    {
        // Corporate customers receive a flat 25% discount
        decimal finalPrice = basePrice * 0.75m;

        Console.WriteLine($"Corporate deal applied: {finalPrice:C}");
        return finalPrice;
    }
}
