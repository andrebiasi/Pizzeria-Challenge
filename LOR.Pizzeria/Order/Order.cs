using System.Collections.Generic;

public class Order : IOrder
{
    private List<Pizza> pizzas { get; set; }
    private decimal total { get; set; }

    public Order()
    {
        this.pizzas = new List<Pizza>();
        this.total = 0;
    }

    public void AddPizza(Pizza pizza)
    {
        this.pizzas.Add(pizza);
        total += pizza.Price;
    }

    public List<Pizza> GetPizzas()
    {
        return this.pizzas;
    }

    public decimal GetTotal()
    {
        return this.total;
    }
}