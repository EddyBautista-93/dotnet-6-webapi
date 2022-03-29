using dotnet_6_webapi.Models;

namespace dotnet_6_webapi.Services;

public static class PizzaService
{
    static List<Pizza> Pizzas { get; }
    static int nextId = 3;
    static PizzaService()
    {
        Pizzas = new List<Pizza>
        {
            new Pizza { Id = 1, Name = "Classic Italian", IsGlutenFree = false },
            new Pizza { Id = 2, Name = "Veggie", IsGlutenFree = true }
        };
    }

    // Grab all the pizzas from the pizza list. 
    public static List<Pizza> GetAll() => Pizzas;

    // Grab the Pizza specific to its Id.
    public static Pizza? Get(int id) => Pizzas.FirstOrDefault(p => p.Id == id);

    // First you grab the next Pizza id incremented and add it to the list of pizza
    public static void Add(Pizza pizza)
    {
        pizza.Id = nextId++;
        Pizzas.Add(pizza);
    }

    // Pass the id you want and save as a object variable , then remove the list.
    public static void Delete(int id)
    {
        var pizza = Get(id);
        if (pizza is null)
            return;
        Pizzas.Remove(pizza);
    }

    // -1 as index = value not in the list;
    public static void Update(Pizza pizza)
    {
        var index = Pizzas.FindIndex(p => p.Id == pizza.Id);
        if (index == -1)
            return;

        Pizzas[index] = pizza;
    }
}
