class Program
{
    static void Main()
    {
        // Composite Formatting
        string name = "Alice";
        int age = 25;

        string compositeFormatted = string.Format("Hello, my name is {0} and I am {1} years old.", name, age);
        Console.WriteLine("Composite Formatting:");
        Console.WriteLine(compositeFormatted);

        Console.WriteLine();

        // String Interpolation
        string interpolatedFormatted = $"Hello, my name is {name} and I am {age} years old.";
        Console.WriteLine("String Interpolation:");
        Console.WriteLine(interpolatedFormatted);

        Console.WriteLine();

        // Format Specifiers
        double price = 19.99;
        int quantity = 3;

        string currencyFormatted = string.Format("Total cost: {0:C}", price * quantity);
        Console.WriteLine("Currency Format Specifier:");
        Console.WriteLine(currencyFormatted);

        string numberFormatted = string.Format("Quantity: {0:D5}", quantity);
        Console.WriteLine("Decimal Format Specifier (5 digits):");
        Console.WriteLine(numberFormatted);

        string scientificFormatted = string.Format("Scientific Notation: {0:E}", 12345.6789);
        Console.WriteLine("Scientific Notation Format Specifier:");
        Console.WriteLine(scientificFormatted);

        string fixedPointFormatted = string.Format("Fixed-Point Notation: {0:F2}", 12345.6789);
        Console.WriteLine("Fixed-Point Format Specifier (2 decimal places):");
        Console.WriteLine(fixedPointFormatted);

        string percentageFormatted = string.Format("Percentage: {0:P}", 0.25);
        Console.WriteLine("Percentage Format Specifier:");
        Console.WriteLine(percentageFormatted);
    }
}
