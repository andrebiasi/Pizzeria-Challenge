using System;

namespace LOR.Pizzeria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to LOR Pizzeria! Please select the store location: Brisbane OR Sydney");
            var store = GetStore();


            Console.WriteLine("MENU");
            Console.WriteLine(string.Join("\n", store.GetAvailablePizzas()));
            var order = GetOrder(store);

            store.PlaceOrder(order);
        }

        private static Store GetStore()
        {
            Store store = null;
            while (store == null)
            {
                var storeName = Console.ReadLine();
                var storeFactory = new PizzaStoreFactory();

                try
                {
                    store = storeFactory.createStore(storeName);
                }
                catch (InvalidStoreException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return store;
        }

        private static Order GetOrder(Store store)
        {
            var order = new Order();

            while (true)
            {
                Console.WriteLine("What can I get you? Enter 'P' to place the order");
                var pizzaType = Console.ReadLine();
                if (pizzaType.ToUpper() == "P")
                {
                    return order;
                }

                try
                {
                    var pizza = store.OrderPizza(pizzaType);

                    Console.WriteLine("EXTRA TOPPINGS");
                    Console.WriteLine($"{string.Join("\n", pizza.GetAvailableToppingsWithPrice())}. Enter 'X' when no more extras.");
                    pizza = AddToppings(pizza);

                    order.AddPizza(pizza);
                }
                catch (InvalidPizzaTypeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private static Pizza AddToppings(Pizza pizza)
        {
            while (true)
            {
                Console.WriteLine($"Extras? Enter 'X' when no more extras.");
                var topping = Console.ReadLine();
                if (topping.ToUpper() == "X")
                {
                    return pizza;
                }

                try
                {
                    pizza = pizza.AddTopping(topping);
                }
                catch (InvalidToppingException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
