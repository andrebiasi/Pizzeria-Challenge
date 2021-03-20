using System;
using System.Collections.Generic;

public abstract class Margherita : Pizza
{
    public override string Name { get; } = "Margherita";

    public override List<string> Ingredients { get; } = new List<string> { "mozarella", "onion", "garlic", "oregano" };

    public Margherita(IToppings toppings) : base(toppings)
    {
    }

    public override void Bake()
    {
        Console.WriteLine("Baking pizza for 15 minutes at 200 degrees...");
    }
}