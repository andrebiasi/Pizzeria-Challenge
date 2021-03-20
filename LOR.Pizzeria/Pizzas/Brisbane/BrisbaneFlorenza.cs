public sealed class BrisbaneFlorenza : Florenza
{
    public override decimal Price { get; } = 21;

    public BrisbaneFlorenza(IToppings toppings) : base(toppings)
    {
    }
}