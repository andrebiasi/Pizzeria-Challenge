using System;

public class SydneyPizzaFactory : IPizzaFactory
{
    public Pizza CreatePizza(string pizzaType)
    {
        switch (pizzaType.ToUpper())
        {
            case "CAPRICIOSA": return new SydneyCapriciosa(new Toppings());
            case "INFERNO": return new SydneyInferno(new Toppings());
            default: throw new InvalidPizzaTypeException($"Invalid pizza type: {pizzaType}");
        }
    }
}