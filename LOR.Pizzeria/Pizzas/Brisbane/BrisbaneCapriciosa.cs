public sealed class BrisbaneCapriciosa : Capriciosa
{
    public sealed override decimal Price { get; } = 20;

    public BrisbaneCapriciosa(IToppings toppings) : base(toppings)
    {
    }
}