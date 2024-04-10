# DesignPattern


design pattern:

in software developing, programmer may face different kind of recurring  problems and to deal with it there are several disign solution.
design pattern is not a code, but it is the way that developer deal with those problems. meaning the framework or implimenting structure is the pattern that we use in our software designing to avoid some reapetable problems.

Type of design patterns:
we have 3 different Type of design pattern:
1. Creational: this kind of design pattern help us to instantiation classes or objects base on specific pettern.
2. Structural: as it is obvious by it name, structural design pattern are used for giving the classes an structure to organize when they are complex. this is for increasing the flexibility of classes and objects and their relationships.
3. Behavioral: this structure is created to improve the connectivity of classess and enhancing classess behaviour. meanning that it created to a pattern of how objects communicate to each other and distribute the responsibility of classess.

let take a look to some of usefull patterns:

Singelton(Creational):
	in this pattern you can create only one object of a class. when you want to restrict the application to create different object of one class you can use this pattern.
	way we should restrict application to create just one object?? the answere is that in some case like wen you want to create a class of a database you can not create different object of one class and to avoiding it we can use this creational patterns.
	to impliment it we make an static object of that class inside of class and make constructure class private. soo no ome can create on object of that class. then we create a class as getInstance and return that object. so we limite ourself to create any object of that class and by using getInstance we can just use the created class.
	a simple implimentation can be seen in this git repository:
	
	
Builder(Creational):
	in complex project to manage classess we can use builder design pattern by constracting complex object step by step. in this pattern you create a time line of objects and impliment them step by step and at the end the final result is returned.
	for implimenting the Pizzashop example we create a class for each of them and to impliment we create a base class and add all we need step by step and return all of the result at the end.
	a simple implimentation can be seen in this git repository:

Decorator(Structural):
	in any software design we don't use data as it is in database, we manupilate it and change the data in a way we want. 
	sometime we need to define different cenario and combine different data to return what we need. in this setuation we can use a structural design pattern to cover all senarios structurally.
	emagin we have a pizza shop and we want to manage the price of pizzas base on their topping. we sell 60 different pizza 
	we have 2 different daugh, 3 different base suce, and 10 different topping. to impliment these pizzas we need 2*3*10 = 60 different class to cover all pizzas and emagin one day we need to add another base suce or change a topping price. in that case we need to recreate or change all classess.
	what is the solution?? a decorator design pattern.
	by using a decorator pattern we don't need to impliment all 60 classess and we create just one class for each of them meanning 2 + 3 + 10 = 15 class and they inheritate or composite form other.
	we will create 2 class for dough and 3 classes for base sauces. base sauces inheritate from dough class and topping inheritate from base sauce class.
	a simple implimentation can be seen in this git repository:
	
Strategy(Behavioral):
	it work by seperating behaviour of an object from object it self. meaning that a common interface is used to behaiv as father and other objects inheritate from this class. then we capsulate child objects and deligating it to a class to defin the behaviour base on the parammeter(object) passed to it.
	way we need to use this strategy? to avoid violating Open-Close-Principle. meaning that if we want to add other object to our process we don't need to modify our object and wa need to just create a new object and deligate it to main class. so that, managing objects, classess, and whole project is easier in the future.
	in our exaple we can use strategy design pattern for dough and basesauce as an example
	as you can see we made an interface for dough and sauce and create classess based on these interfaces. then we create the pizza class with these 2 object and pass these object to the pizza class.
	so in future if wee needed to add a new base sauce wee need to create an object inheritating from Isauce and pass it to the Pizza class.
	This implimentation can be seen in this git repository:

	
