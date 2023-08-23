// Class with various constructor types
public class MyClass
{
    // Default Constructor
    public MyClass()
    {
        Console.WriteLine("Default constructor called");
    }

    // Parameterized Constructor
    public MyClass(string message)
    {
        Console.WriteLine($"Parameterized constructor called with message: {message}");
    }

    // Constructor Overloading
    public MyClass(int number)
    {
        Console.WriteLine($"Parameterized constructor with int called: {number}");
    }

    // Constructor Chaining
    public MyClass(string message, int number) : this(message)
    {
        Console.WriteLine($"Chained constructor with int called: {number}");
    }

    // Static Constructor (Type Initializer)
    static MyClass()
    {
        Console.WriteLine("Static constructor (type initializer) called");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Creating instances using different constructors
        MyClass obj1 = new MyClass();  // Calls default constructor
        MyClass obj2 = new MyClass("Hello");  // Calls parameterized constructor with string
        MyClass obj3 = new MyClass(42);  // Calls parameterized constructor with int
        MyClass obj4 = new MyClass("Hi", 99);  // Calls constructor chaining
                                               // Static constructor is automatically called when the class is first accessed
    }
}