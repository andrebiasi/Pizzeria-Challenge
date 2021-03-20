public sealed class SydneyCapriciosa : Capriciosa
{
    public sealed override decimal Price { get; } = 30;

    public SydneyCapriciosa(IToppings toppings) : base(toppings)
    {
    }
}