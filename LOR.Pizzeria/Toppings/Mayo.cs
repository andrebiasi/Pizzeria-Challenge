using System.Collections.Generic;

public class Mayo : ToppingDecorator
{
    private Pizza pizza;
    private string toppingName { get; } = "Mayo";
    private string descripition { get; } = "mayo";
    private decimal toppingPrice { get; } = 1.5M;

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

    public Mayo(Pizza pizza, IToppings toppings) : base(toppings)
    {
        this.pizza = pizza;
    }
}