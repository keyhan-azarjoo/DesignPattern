// Implementing a Strategy Design Pattern


using System;

// Dough interface
public interface IDough {
    string GetDescription();
    double GetCost();
}

// Concrete implementation of dough
public class ThinCrustDough : IDough {
    public string GetDescription() {
        return "Thin Crust Dough";
    }

    public double GetCost() {
        return 8;
    }
}

// Concrete implementation of dough
public class ThickCrustDough : IDough {
    public string GetDescription() {
        return "Thick Crust Dough";
    }

    public double GetCost() {
        return 10;
    }
}

// Sauce interface
public interface ISauce {
    string GetDescription();
    double GetCost();
}

// Concrete implementation of base sauce
public class TomatoBaseSauce : ISauce {
    public string GetDescription() {
        return "Tomato Base Sauce";
    }

    public double GetCost() {
        return 5;
    }
}

// Concrete implementation of base sauce
public class PestoBaseSauce : ISauce {
    public string GetDescription() {
        return "Pesto Base Sauce";
    }

    public double GetCost() {
        return 6;
    }
}

// Context class for pizza
public class Pizza {
    private IDough dough;
    private ISauce sauce;

    public Pizza(IDough dough, ISauce sauce) {
        this.dough = dough;
        this.sauce = sauce;
    }

    public string GetDescription() {
        return $"{dough.GetDescription()} with {sauce.GetDescription()}";
    }

    public double GetCost() {
        return dough.GetCost() + sauce.GetCost();
    }
}

public class PizzaOrderingSystem {
    public static void Main(string[] args) {
        // Example 1: Thin crust pizza with tomato base sauce
        IDough thinCrust = new ThinCrustDough();
        ISauce tomatoBaseSauce = new TomatoBaseSauce();
        Pizza pizza1 = new Pizza(thinCrust, tomatoBaseSauce);
        Console.WriteLine("Pizza 1: " + pizza1.GetDescription() + " - Cost: $" + pizza1.GetCost());

        // Example 2: Thick crust pizza with pesto base sauce
        IDough thickCrust = new ThickCrustDough();
        ISauce pestoBaseSauce = new PestoBaseSauce();
        Pizza pizza2 = new Pizza(thickCrust, pestoBaseSauce);
        Console.WriteLine("Pizza 2: " + pizza2.GetDescription() + " - Cost: $" + pizza2.GetCost());
    }
}
