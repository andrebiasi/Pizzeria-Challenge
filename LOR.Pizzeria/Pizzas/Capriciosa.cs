using System;
using System.Collections.Generic;

public abstract class Capriciosa : Pizza
{
    public sealed override string Name { get; } = "Capriciosa";
    public sealed override List<string> Ingredients { get; } = new List<string> { "mushrooms", "cheese", "ham", "mozarella" };

    public Capriciosa(IToppings toppings) : base(toppings)
    {
    }
}