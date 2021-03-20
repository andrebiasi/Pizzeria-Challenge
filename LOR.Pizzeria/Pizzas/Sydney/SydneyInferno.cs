public sealed class SydneyInferno : Inferno
{
    public override decimal Price { get; } = 31;

    public SydneyInferno(IToppings toppings) : base(toppings)
    {
    }
}