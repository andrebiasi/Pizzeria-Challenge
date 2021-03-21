using System.Collections.Generic;
using System;
using System.Linq;

public class Toppings : IToppings
{
    private readonly List<Tuple<string, decimal>> availabeToppings = new List<Tuple<string, decimal>>
    {
        new Tuple<string, decimal>("Cheese", 2.5M),
        new Tuple<string, decimal>("Mayo", 1.5M),
        new Tuple<string,decimal>("Olive Oil", 1.5M)
    };

    public Pizza AddTopping(string topping, Pizza pizza)
    {
        var extraTopping = availabeToppings.Where(t => t.Item1.ToUpper() == topping.ToUpper()).FirstOrDefault();
        if (extraTopping == null)
        {
            throw new InvalidToppingException($"Invalid topping: {topping}");
        }

        return new ToppingDecorator(extraTopping.Item1, extraTopping.Item2, pizza, this);
    }

    public List<string> GetAvailableToppingsWithPrice(Pizza pizza)
    {
        return availabeToppings.Select(topping => $"{topping.Item1} - {PriceHelper.ToAUPrice(topping.Item2)}").ToList();
    }
}