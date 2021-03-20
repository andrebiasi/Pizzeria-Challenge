using System.Collections.Generic;

public class Cheese : ToppingDecorator
{
    private Pizza pizza;
    private string toppingName { get; } = "Cheese";
    private string descripition { get; } = "extra cheese";
    private decimal toppingPrice { get; } = 2.5M;

    public override string Name
    {
        get
        {
            return $"{pizza.Name} + {this.toppingName}";
        }
    }

    public override List<string> Ingredients
    {
        get
        {
            var ingredients = new List<string>(pizza.Ingredients);
            ingredients.Add(this.descripition);
            return ingredients;
        }
    }

    public override decimal Price
    {
        get
        {
            return this.toppingPrice + pizza.Price;
        }
    }
    public Cheese(Pizza pizza, IToppings toppings) : base(toppings)
    {
        this.pizza = pizza;
    }
}