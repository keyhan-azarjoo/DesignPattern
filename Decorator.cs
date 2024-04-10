using System;

public abstract class Dough
{
    private string description;

    public Dough(string description)
    {
        this.description = description;
    }

    public string GetDescription()
    {
        return description;
    }

    public abstract double Cost();
}

public class GarlicSauce : Dough
{
    public GarlicSauce() : base("Garlic Sauce")
    {
    }

    public override double Cost()
    {
        return 10;
    }
}

public class SpicyRedSauce : Dough
{
    public SpicyRedSauce() : base("Spicy Red Sauce")
    {
    }

    public override double Cost()
    {
        return 12;
    }
}

public abstract class AddOn : Dough
{
    protected Dough dough;

    public AddOn(string description, Dough dough) : base(description)
    {
        this.dough = dough;
    }

    public abstract new string GetDescription();
}

public class Mushroom : AddOn
{
    public Mushroom(Dough dough) : base("Mushroom", dough)
    {
    }

    public override string GetDescription()
    {
        return dough.GetDescription() + " with Mushroom";
    }

    public override double Cost()
    {
        return dough.Cost() + 2;
    }
}

public class Onion : AddOn
{
    public Onion(Dough dough) : base("Onion", dough)
    {
    }

    public override string GetDescription()
    {
        return dough.GetDescription() + " with Onion";
    }

    public override double Cost()
    {
        return dough.Cost() + 0.5;
    }
}

public class PizzaShop
{
    public static void Main(string[] args)
    {
        GarlicSauce garlicSauce = new GarlicSauce();
        Console.WriteLine(garlicSauce.GetDescription() + ": " + garlicSauce.Cost());

        Mushroom mushroomAddOn = new Mushroom(garlicSauce);
        Console.WriteLine(mushroomAddOn.GetDescription() + ": " + mushroomAddOn.Cost());

        Onion onionAddOn = new Onion(mushroomAddOn);
        Console.WriteLine(onionAddOn.GetDescription() + ": " + onionAddOn.Cost());
    }
}
