using System.Collections.Generic;

public class Cheese : ToppingDecorator
{
    private Pizza pizza;
    private const string descripition = "extra cheese";
    public override string ToppingName { get; } = "Cheese";
    public override decimal ToppingPrice { get; } = 2.5M;

    public override string Name
    {
        get
        {
            return $"{pizza.Name} + {this.ToppingName}";
        }
    }

    public override List<string> Ingredients
    {
        get
        {
            var ingredients = new List<string>(pizza.Ingredients);
            ingredients.Add(descripition);
            return ingredients;
        }
    }

    public override decimal Price
    {
        get
        {
            return this.ToppingPrice + pizza.Price;
        }
    }

    public Cheese(Pizza pizza, IToppings toppings) : base(toppings)
    {
        this.pizza = pizza;
    }
}