namespace Pattern.Behavioral.Strategy;

public class PriceCalculator
{
    private IPricingStrategy _pricingStrategy;
    public PriceCalculator(IPricingStrategy pricingStrategy)
    {
        _pricingStrategy = pricingStrategy;
    }

    public void SetStrategy(IPricingStrategy strategy) 
    {
        _pricingStrategy = strategy ?? throw new ArgumentNullException(nameof(strategy));
    }

    public decimal CalculatePrice(decimal basePrice)
    {
        return _pricingStrategy.CalculatePrice(basePrice);
    }


}
