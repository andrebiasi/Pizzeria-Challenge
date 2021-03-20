using System.Collections.Generic;

public abstract class ToppingDecorator : Pizza
{
    public abstract override string Name { get; }
    public abstract override List<string> Ingredients { get; }
    public abstract override decimal Price { get; }

    public abstract string ToppingName { get; }
    public abstract decimal ToppingPrice { get; }

    public ToppingDecorator(IToppings toppings) : base(toppings)
    {
    }

    public string GetToppingWithPrice()
    {
        return $"{this.ToppingName} - {PriceHelper.ToAUPrice(this.ToppingPrice)}";
    }
}