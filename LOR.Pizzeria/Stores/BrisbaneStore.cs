using System;
using System.Collections.Generic;
using System.Linq;

public class BrisbaneStore : Store
{
    private List<string> availablePizzas = new List<string> { "Capriciosa", "Florenza", "Margherita" };
    private IPizzaFactory pizzaFactory;

    public BrisbaneStore(IPizzaFactory pizzaFactory, IToppings toppings) : base(pizzaFactory, toppings)
    {
        this.pizzaFactory = pizzaFactory;
    }

    public override List<string> GetAvailablePizzas()
    {
        return availablePizzas.Select(pizza => $"{this.pizzaFactory.CreatePizza(pizza).ToString()}").ToList();
    }
}