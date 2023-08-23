// Class with static members and types
public class StaticDemo
{
    // Static field
    public static int StaticField = 10;

    // Static property
    public static string StaticProperty { get; set; }

    // Static constructor (type initializer)
    static StaticDemo()
    {
        Console.WriteLine("Static constructor (type initializer) called");
    }

    // Static method
    public static void StaticMethod()
    {
        Console.WriteLine("Static method called");
    }
    // Nested static class
    public static class NestedStaticClass
    {
        public static void NestedMethod()
        {
            Console.WriteLine("Nested static method called");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Accessing static members and types without creating an instance

        // Display the value of the static field.
        Console.WriteLine($"StaticField: {StaticDemo.StaticField}");
        // Set the value of the static property and display it.
        StaticDemo.StaticProperty = "Hello, static property!";
        Console.WriteLine($"StaticProperty: {StaticDemo.StaticProperty}");

        // Call the static method.
        StaticDemo.StaticMethod();

        // Call the nested static method within the nested static class.
        StaticDemo.NestedStaticClass.NestedMethod();
    }
}