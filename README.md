# design pattern:

in software development, programmers may face different kinds of recurring  problems and to deal with them there are some solutions.
design pattern is not a code, but it is the way that developers deal with those problems. meaning the implementing structure is the pattern that we use in our software designing to avoid some repeatable problems.

# Type of design patterns:
we have 3 different types of design patterns:
1. Creational: this kind of design pattern helps us to instantiate classes or objects based on a specific pattern.
2. Structural: as it is obvious by its name, structural design patterns are used for giving the classes a structure to organize when they are complex. this is for increasing the flexibility of classes and objects and their relationships.
3. Behavioral: this structure is created to improve the connectivity of classes and enhance class behavior. meaning that it created a pattern of how objects communicate with each other and distribute the responsibility of the class.

let's take a look at some useful patterns:

# Singelton(Creational):
	in this pattern, you can create only one object of a class. when you want to restrict the application to create different objects of one class you can use this pattern.
	the way we should restrict applications to create just one object?? the answer is that in some cases like when you want to create a class of a database you can not create different objects of one class and to avoid it we can use these creational patterns.
	to implement it we make a static object of that class inside of the class and make the constructor class private. so no one can create an object of that class. then we create a class as getInstance and return that object. so we limited ourselves to creating any object of that class and by using getInstance we can just use the created class.
	a simple implementation can be seen in the first picture or this git repository:
	link
	
# Builder(Creational):
	in complex projects to manage classes, we can use builder design patterns by constructing complex objects step by step. in this pattern, you create a timeline of objects and implement them step by step and at the end, the final result is returned.
	for implementing the Pizzashop example we create a class for each of them and to implement we create a base class and add all we need step by step and return all of the results at the end.
	a simple implementation can be seen in the second picture or this git repository:
	link

# Decorator(Structural):
in any software design, we don't use data as it is in the database, we manipulate it and change the data in a way we want. 
sometimes we need to define different scenarios and combine different data to return what we need. in this situation, we can use a structural design pattern to cover all scenarios structurally.
imagine we have a pizza shop and we want to manage the price of pizzas based on their topping. we sell 60 different pizzas 
we have 2 different daughs, 3 different base sauces, and 10 different toppings. to implement these pizzas we need 2*3*10 = 60 different classes to cover all pizzas and imagine one day we need to add another base sauce or change a topping price. in that case, we need to recreate or change all classes.
what is the solution?? a decorator design pattern.
by using a decorator pattern we don't need to implement all 60 classes and we create just one class for each of them meaning 2 + 3 + 10 = 15 classes and they are inherited or composite from each other.
we will create 2 classes for dough and 3 classes for base sauces. base sauces inherited from the dough class and topping inherited from the base sauce class.
a simple implementation can be seen in the third picture or this git repository:
link
	
# Strategy(Behavioral):
	it works by separating the behavior of an object from the object itself. meaning that a common interface is used to behave as father and other objects inherit from this class. then we capsulate child objects and delegate them to a class to define the behavior based on the parameters (objects) passed to it.
	the way we need to use this strategy? to avoid violating the Open-Close principle. meaning that if we want to add another object to our process we don't need to modify our object and we need to just create a new object and delegate it to the main class. so that, managing objects, classes, and the whole project is easier in the future.
	in our example, we can use a strategy design pattern for dough and base sauce example
	as you can see we made an interface for dough and sauce and created classes based on these interfaces. then we create the pizza class with these 2 objects and pass these objects to the pizza class.
	so in the future, if we need to add a new base sauce we need to create an object inheriting from Isauce and pass it to the Pizza class.
	This implementation can be seen in the fourth picture or this git repository:
	link 
	
