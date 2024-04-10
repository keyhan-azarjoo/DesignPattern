// Implementing Decorator Design Pattern

public abstract class Dough {
	private String description;
    
	public Dough(String description) {
		super();
		this.description = description;
	}
    
	public String getDescription() {
		return description;
	}
    
	public abstract double cost();
}


public class GarlicSauce : Dough {
	public GarlicSauce() {
		super(“Garlic Sauce”);
	}

	@Override
	public double cost() {
		return 10;
	}
}
public class SpicyRedSauce : Dough {
	public SpicyRedSauce() {
		super(“Spicy Red Sauce”);
	}

	@Override
	public double cost() {
		return 12;
	}
}

public abstract class AddOn : Dough {
	protected Dough dough;

	public AddOn(String description, Dough dou) {
		super(description);
		this.dough = dou;
	}

	public abstract String getDescription();
}




public class Mushroom : AddOn {
	public Mushroom(Dough dou) {
		super(“Mushroom”, dou);
	}

	@Override
	public String getDescription() {
		return dough.getDescription() + “ with Mushroom”;
	}

	@Override
	public double cost() {
		return dough.cost() + 2;
	}
}

public class Onion : AddOn {
	public Onion(Dough dou) {
		super(“Onion”, dou);
	}

	@Override
	public String getDescription() {
		return dough.getDescription() + “ with Onion”;
	}

	@Override  public double cost() {
		return dough.cost() + 0.5;
	}
}


public class PizzShop {
	public static void main(String[] args) {
		GarlicSauce garlicSauce = new GarlicSauce();
		System.out.println(garlicSauce.getDescription() + “: “ + garlicSauce.cost());

		Mushroom mushroomAddOn = new Mushroom(garlicSauce);
		System.out.println(mushroomAddOn.getDescription() + “: “ + mushroomAddOn.cost());

		Onion onionAddOn = new Onion(mushroomAddOn);
		System.out.println(onionAddOn.getDescription() + “: “ + onionAddOn.cost());
	}
}
