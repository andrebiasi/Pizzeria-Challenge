using System;
using System.Collections.Generic;

public class BrisbaneStore : Store
{
    private List<string> AvailablePizzas = new List<string> { "Capriciosa", "Florenza", "Margherita" };
    private IPizzaFactory pizzaFactory;

    public BrisbaneStore(IPizzaFactory pizzaFactory, IToppings toppings) : base(pizzaFactory, toppings)
    {
        this.pizzaFactory = pizzaFactory;
    }

    public override void PrintMenu()
    {
        AvailablePizzas.ForEach((pizza) => Console.WriteLine(this.pizzaFactory.CreatePizza(pizza).ToString()));
    }
}