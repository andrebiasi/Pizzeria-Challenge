using System;

public class BrisbanePizzaFactory : IPizzaFactory
{
    public Pizza CreatePizza(string pizzaType)
    {
        switch (pizzaType.ToUpper())
        {
            case "CAPRICIOSA": return new BrisbaneCapriciosa(new Toppings());
            case "FLORENZA": return new BrisbaneFlorenza(new Toppings());
            case "MARGHERITA": return new BrisbaneMargherita(new Toppings());
            default: throw new InvalidPizzaTypeException($"Invalid pizza type: {pizzaType}");
        }
    }
}