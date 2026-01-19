namespace Pattern.Behavioral.Strategy;

//Different customers get different pricing:

    //Regular customer → normal price
    //Premium customer → 10% discount
    //Festival offer → 20% discount
    //Corporate deal → custom discount


public interface IPricingStrategy
{
    decimal CalculatePrice(decimal basePrice);
}

