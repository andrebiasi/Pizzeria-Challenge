using System;
using System.Collections.Generic;

public abstract class Florenza : Pizza
{
    public override string Name { get; } = "Florenza";
    public override List<string> Ingredients { get; } = new List<string> { "olives", "pastrami", "mozarella", "onion" };

    public Florenza(IToppings toppings) : base(toppings)
    {
    }

    public override void Cut()
    {
        Console.WriteLine("Cutting pizza into 6 slices with a special knife...");
    }
}