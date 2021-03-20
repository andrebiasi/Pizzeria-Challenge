public sealed class BrisbaneMargherita : Margherita
{
    public override decimal Price { get; } = 22;

    public BrisbaneMargherita(IToppings toppings) : base(toppings)
    {
    }
}