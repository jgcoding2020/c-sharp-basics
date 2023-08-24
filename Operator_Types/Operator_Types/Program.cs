class Program
{
    static void Main()
    {
        // Arithmetic Operators
        int a = 10;
        int b = 5;
        int result;

        result = a + b; // Addition
        Console.WriteLine($"Addition: {result}");

        result = a - b; // Subtraction
        Console.WriteLine($"Subtraction: {result}");

        result = a * b; // Multiplication
        Console.WriteLine($"Multiplication: {result}");

        result = a / b; // Division (integer division)
        Console.WriteLine($"Division: {result}");

        result = a % b; // Modulus (remainder)
        Console.WriteLine($"Modulus: {result}");

        // Relational Operators
        bool isEqual = (a == b); // Equal to
        Console.WriteLine($"Equal to: {isEqual}");

        bool isNotEqual = (a != b); // Not equal to
        Console.WriteLine($"Not equal to: {isNotEqual}");

        bool isGreater = (a > b); // Greater than
        Console.WriteLine($"Greater than: {isGreater}");

        bool isLess = (a < b); // Less than
        Console.WriteLine($"Less than: {isLess}");

        // Logical Operators
        bool x = true;
        bool y = false;
        bool logicalAnd = x && y; // Logical AND
        Console.WriteLine($"Logical AND: {logicalAnd}");

        bool logicalOr = x || y; // Logical OR
        Console.WriteLine($"Logical OR: {logicalOr}");

        bool logicalNot = !x; // Logical NOT
        Console.WriteLine($"Logical NOT: {logicalNot}");

        // Assignment Operators
        int c = 7;
        c += 3; // c = c + 3
        Console.WriteLine($"Assignment (c += 3): {c}");

        // Increment and Decrement Operators
        int count = 5;
        count++; // Increment
        Console.WriteLine($"Increment: {count}");

        count--; // Decrement
        Console.WriteLine($"Decrement: {count}");

        // Conditional (Ternary) Operator
        int number = 42;
        string resultText = (number > 50) ? "Greater than 50" : "Less than or equal to 50";
        Console.WriteLine($"Conditional Operator: {resultText}");
    }
}
