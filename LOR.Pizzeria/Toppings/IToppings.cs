using System.Collections.Generic;

public interface IToppings
{
    List<string> GetAvailableToppingsWithPrice(Pizza pizza);
    Pizza AddTopping(string topping, Pizza pizza);
}