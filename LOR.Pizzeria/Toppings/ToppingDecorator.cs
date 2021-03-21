using System.Collections.Generic;

public class ToppingDecorator : Pizza
{
    private Pizza pizza;
    private readonly string toppingName;
    private readonly decimal toppingPrice;

    public override string Name
    {
        get
        {
            return $"{pizza.Name} + {toppingName}";
        }
    }

    public override List<string> Ingredients
    {
        get
        {
            var ingredients = new List<string>(pizza.Ingredients);
            ingredients.Add(toppingName);
            return ingredients;
        }
    }

    public override decimal Price
    {
        get
        {
            return toppingPrice + pizza.Price;
        }
    }

    public ToppingDecorator(string toppingName, decimal toppingPrice, Pizza pizza, IToppings toppings) : base(toppings)
    {
        this.toppingName = toppingName;
        this.toppingPrice = toppingPrice;
        this.pizza = pizza;
    }
}