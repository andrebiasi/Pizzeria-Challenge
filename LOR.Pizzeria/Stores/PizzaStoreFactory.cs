public class PizzaStoreFactory
{
    public Store createStore(string store)
    {
        switch (store.ToUpper())
        {
            case "BRISBANE": return new BrisbaneStore(new BrisbanePizzaFactory(), new Toppings());
            case "SYDNEY": return new SydneyStore(new SydneyPizzaFactory(), new Toppings());
            default: throw new InvalidStoreException($"Invalid store: {store}");
        }
    }
}