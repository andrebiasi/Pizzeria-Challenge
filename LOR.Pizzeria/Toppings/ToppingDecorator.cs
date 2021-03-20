using System.Collections.Generic;

public abstract class ToppingDecorator : Pizza
{
    public abstract override string Name { get; }
    public abstract override List<string> Ingredients { get; }
    public abstract override decimal Price { get; }

    public ToppingDecorator(IToppings toppings) : base(toppings)
    {
    }
}