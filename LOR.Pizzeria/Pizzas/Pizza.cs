using System;
using System.Collections.Generic;

public abstract class Pizza
{
    private IToppings toppings;
    public abstract string Name { get; }
    public abstract List<string> Ingredients { get; }
    public abstract decimal Price { get; }

    public Pizza(IToppings toppings)
    {
        this.toppings = toppings;
    }

    public void Prepare()
    {
        Console.WriteLine($"Preparing {this.Name} ({PriceHelper.ToAUPrice(this.Price)})...");
        Console.Write($"Adding {string.Join(", ", Ingredients)}");
        Console.WriteLine();
    }

    public virtual void Bake()
    {
        Console.WriteLine("Baking pizza for 30 minutes at 200 degrees...");
    }

    public virtual void Cut()
    {
        Console.WriteLine("Cutting pizza into 8 slices...");
    }

    public void Box()
    {
        Console.WriteLine("Putting pizza into a nice box...");
    }

    public List<string> GetAvailableToppingsWithPrice()
    {
        return this.toppings.GetAvailableToppingsWithPrice(this);
    }

    public Pizza AddTopping(string topping)
    {
        return this.toppings.AddTopping(topping, this);
    }

    public override string ToString()
    {
        return $"{this.Name} - {string.Join(", ", Ingredients)} - {PriceHelper.ToAUPrice(Price)}";
    }
}