using System;
using System.Collections.Generic;

public class SydneyStore : Store
{
    private List<string> AvailablePizzas = new List<string> { "Capriciosa", "Inferno" };
    private IPizzaFactory pizzaFactory;

    public SydneyStore(IPizzaFactory pizzaFactory, IToppings toppings) : base(pizzaFactory, toppings)
    {
        this.pizzaFactory = pizzaFactory;
    }

    public override void PrintMenu()
    {
        AvailablePizzas.ForEach((pizza) => Console.WriteLine(this.pizzaFactory.CreatePizza(pizza).ToString()));
    }
}