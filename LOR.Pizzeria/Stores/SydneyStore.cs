using System;
using System.Collections.Generic;
using System.Linq;

public class SydneyStore : Store
{
    private List<string> availablePizzas = new List<string> { "Capriciosa", "Inferno" };
    private IPizzaFactory pizzaFactory;

    public SydneyStore(IPizzaFactory pizzaFactory, IToppings toppings) : base(pizzaFactory, toppings)
    {
        this.pizzaFactory = pizzaFactory;
    }

    public override List<string> GetAvailablePizzas()
    {
        return availablePizzas.Select(pizza => $"{this.pizzaFactory.CreatePizza(pizza).ToString()}").ToList();
    }
}