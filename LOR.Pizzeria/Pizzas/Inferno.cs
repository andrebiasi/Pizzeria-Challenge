using System.Collections.Generic;

public abstract class Inferno : Pizza
{
    public override string Name { get; } = "Inferno";
    public override List<string> Ingredients { get; } = new List<string> { "chili peppers", "mozzarella", "chicken", "cheese" };

    public Inferno(IToppings toppings) : base(toppings)
    {
    }
}