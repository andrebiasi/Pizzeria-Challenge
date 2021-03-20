public static class PriceHelper
{
    public static string ToAUPrice(decimal price)
    {
        return $"{price.ToString("0.##")} AUD";
    }
}