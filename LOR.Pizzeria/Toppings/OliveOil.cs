using System.Collections.Generic;

public class OliveOil : ToppingDecorator
{
    private Pizza pizza;
    private const string descripition = "olive oil";
    public override string ToppingName { get; } = "Olive Oil";
    public override decimal ToppingPrice { get; } = 1.5M;

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

    public OliveOil(Pizza pizza, IToppings toppings) : base(toppings)
    {
        this.pizza = pizza;
    }
}