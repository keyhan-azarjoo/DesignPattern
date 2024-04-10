// Implementing Singleton Design Pattern

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
