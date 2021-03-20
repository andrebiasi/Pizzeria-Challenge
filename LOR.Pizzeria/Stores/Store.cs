using System;
using System.Linq;

public abstract class Store
{
    private IPizzaFactory pizzaFactory;

    public Store(IPizzaFactory pizzaFactory, IToppings toppings)
    {
        this.pizzaFactory = pizzaFactory;
    }

    public Pizza OrderPizza(string pizzaType)
    {
        return pizzaFactory.CreatePizza(pizzaType);
    }

    public void PlaceOrder(IOrder order)
    {
        var pizzasToOrder = order.GetPizzas();
        if (!pizzasToOrder.Any())
        {
            return;
        }

        pizzasToOrder.ForEach((pizza) =>
        {
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        });

        Console.WriteLine($"\nTotal price is: {order.GetTotal()}");
        Console.WriteLine("\nYour pizza(s) is(are) ready!");
    }

    public abstract void PrintMenu();
}