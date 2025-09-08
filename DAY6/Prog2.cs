using System;

// Step 1: Define PropertyDemo class
public class PropertyDemo
{
    public int PublicValue { get; set; } = 5;
    private string privateValue = "Private Value";

    public string GetPrivateValue()
    {
        return privateValue;
    }
}

// Step 2: Define StaticDemo class
public class StaticDemo
{
    public static int StaticValue;

    // Static constructor
    static StaticDemo()
    {
        Console.WriteLine("Static Constructor");
        StaticValue = 10;
    }

    public static void StaticMethod()
    {
        Console.WriteLine("Static Method");
        StaticValue += 5;
    }
}

// Step 3: Define MathHelper static class
public static class MathHelper
{
    public static int Double(int number)
    {
        return number * 2;
    }
}

// Step 4: Main method demonstration
public class Program
{
    public static void Main()
    {
        PropertyDemo obj = new PropertyDemo();
        Console.WriteLine(obj.PublicValue);               // 5
        Console.WriteLine(obj.GetPrivateValue());         // Private Value

        Console.WriteLine(StaticDemo.StaticValue);        // Triggers static constructor, prints "Static Constructor" then 10
        StaticDemo.StaticMethod();                        // Prints "Static Method"
        Console.WriteLine(StaticDemo.StaticValue);        // 15

        Console.WriteLine(obj.PublicValue);               // 5 again
    }
}