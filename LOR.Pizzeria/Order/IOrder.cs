using System.Collections.Generic;

public interface IOrder
{
    void AddPizza(Pizza pizza);
    List<Pizza> GetPizzas();
    decimal GetTotal();
}