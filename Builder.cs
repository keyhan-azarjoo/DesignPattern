// Implementing Builder Design Pattern

//The Builder pattern is a creational pattern that separates the construction of a complex object from its representation, allowing the same construction process to create different representations.

//In this implementation:

//The PizzaBuilder class is responsible for constructing pizza objects with various toppings.
//It provides methods like WithGarlicSauce(), WithSpicyRedSauce(), WithMushroom(), WithOnion() to add different toppings to the pizza.
//The Build() method is used to retrieve the final constructed pizza object.
//The Dough class represents the base dough of the pizza, and it is a part of the object being constructed.
//The Builder pattern is useful when you need to create objects with many optional parts or configurations, especially when there can be multiple valid configurations for the same object. It simplifies the object construction process and makes the code more readable and maintainable by separating the construction logic from the main object.

using System;

// Dough class representing the base dough of the pizza
public class Dough
{
    public string Description { get; }
    public double Cost { get; }

    public Dough(string description, double cost)
    {
        Description = description;
        Cost = cost;
    }
}

// PizzaBuilder class for constructing pizzas with various toppings
public class PizzaBuilder
{
    private Dough _dough;

    public PizzaBuilder()
    {
        // Initialize with default values
        _dough = new Dough("Plain Dough", 5); // Example cost for plain dough
    }

    public PizzaBuilder WithGarlicSauce()
    {
        _dough = new Dough(_dough.Description + " with Garlic Sauce", _dough.Cost + 2); // Example cost for garlic sauce
        return this;
    }

    public PizzaBuilder WithSpicyRedSauce()
    {
        _dough = new Dough(_dough.Description + " with Spicy Red Sauce", _dough.Cost + 3); // Example cost for spicy red sauce
        return this;
    }

    public PizzaBuilder WithMushroom()
    {
        _dough = new Dough(_dough.Description + " with Mushroom", _dough.Cost + 1.5); // Example cost for mushroom
        return this;
    }

    public PizzaBuilder WithOnion()
    {
        _dough = new Dough(_dough.Description + " with Onion", _dough.Cost + 1); // Example cost for onion
        return this;
    }

    public Dough Build()
    {
        return _dough;
    }
}

// PizzaShop class for demonstrating pizza construction
public class PizzaShop
{
    public static void Main(string[] args)
    {
        // Use the builder to construct the pizza step by step
        Dough pizza = new PizzaBuilder()
            .WithGarlicSauce()
            .WithMushroom()
            .WithOnion()
            .Build();

        // Output the description and cost of the pizza
        Console.WriteLine(pizza.Description + ": " + pizza.Cost);
    }
}
