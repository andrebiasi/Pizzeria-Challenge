using System.Collections.Generic;
using System.Linq;

public class Toppings : IToppings
{
    public Pizza AddTopping(string topping, Pizza pizza)
    {
        switch (topping.ToUpper())
        {
            case "CHEESE": return new Cheese(pizza, this);
            case "MAYO": return new Mayo(pizza, this);
            case "OLIVE OIL": return new OliveOil(pizza, this);
            default: throw new InvalidToppingException($"Invalid topping: {topping}");
        }
    }

    public List<string> GetAvailableToppingsWithPrice(Pizza pizza)
    {
        return new List<string> {
           new Cheese(pizza, this).GetToppingWithPrice(),
           new Mayo(pizza, this).GetToppingWithPrice(),
           new OliveOil(pizza, this).GetToppingWithPrice(),
        };
    }
}