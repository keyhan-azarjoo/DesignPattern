// Implementing Singleton Design Pattern
//In the Singleton pattern, a class is designed to have only one instance, and that instance provides a global point of access to it. This is useful when exactly one object is needed to coordinate actions across the system.

//In the code:

//The class MySingletonClass has a private constructor, preventing other classes from instantiating it directly.
//It has a static method GetInstance() that provides the global access point to the singleton instance.
//It maintains a private static instance MSC of the class, which is initialized only once when the class is loaded.
//This ensures that only one instance of MySingletonClass exists throughout the lifetime of the program, and it can be accessed globally through the GetInstance() method.

using System;

public class Singleton
{
    public static void Main(string[] args)
    {
        // Using the created object of the class.
        MySingletonClass obj = MySingletonClass.GetInstance();
    }
}

public class MySingletonClass
{
    // Create an instance of the class.
    private static MySingletonClass MSC = new MySingletonClass();

    // Private constructor, so it cannot be instantiated outside this class.
    private MySingletonClass()
    {
    }

    // Get the only instance of the object created.
    public static MySingletonClass GetInstance()
    {
        return MSC;
    }
}

