class Program
{
    static void Main()
    {
        // String Interpolation
        string name = "Alice";
        int age = 30;
        double salary = 50000.75;

        Console.WriteLine($"String Interpolation: My name is {name}, I am {age} years old, and I earn {salary:C} per year.");
        Console.WriteLine();

        // Formatting Placeholders
        Console.WriteLine("Formatting Placeholders: My name is {0}, I am {1} years old, and I earn {2:C} per year.", name, age, salary);
        Console.WriteLine();

        // String.Format Method
        string formattedString = string.Format("String.Format Method: My name is {0}, I am {1} years old, and I earn {2:C} per year.", name, age, salary);
        Console.WriteLine(formattedString);
        Console.WriteLine();

        // Numeric Formatting
        int number = 12345;
        double pi = Math.PI;

        Console.WriteLine("Numeric Formatting:");
        Console.WriteLine("Formatted Integer: {0:N0}", number); // Format as thousands separator
        Console.WriteLine("Formatted Double (2 decimal places): {0:F2}", pi); // Format with 2 decimal places
        Console.WriteLine("Scientific Notation (3 decimal places): {0:E3}", pi); // Scientific notation with 3 decimal places
        Console.WriteLine();

        // Custom Numeric Formatting
        decimal price = 12345.6789m;

        Console.WriteLine("Custom Numeric Formatting:");
        Console.WriteLine("Formatted Price (2 decimal places): {0:0.00}", price);
        Console.WriteLine("Formatted Price with Thousands Separator: {0:#,###.00}", price);
    }
}