class Program
{
    static void Main()
    {
        // Variable Declarations and Assignments
        int integerNumber = 42; // Integer variable
        Console.WriteLine($"Integer: {integerNumber}");

        double doubleNumber = 3.14159265359; // Double-precision floating-point variable
        Console.WriteLine($"Double: {doubleNumber}");

        string text = "Hello, World!"; // String variable
        Console.WriteLine($"String: {text}");

        bool isTrue = true; // Boolean variable
        Console.WriteLine($"Boolean: {isTrue}");

        char character = 'A'; // Character variable
        Console.WriteLine($"Character: {character}");

        // Array Declaration and Assignment
        int[] intArray = new int[] { 1, 2, 3, 4, 5 }; // Integer array
        Console.Write("Array of Integers: ");
        foreach (int num in intArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        // Multi-dimensional Array Declaration and Assignment
        int[,] matrix = new int[,]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        }; // 2D integer array (matrix)
        Console.WriteLine("2D Array (Matrix):");
        for (int row = 0; row < 3; row++)
        {
            for (int col = 0; col < 3; col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }

        // Object Declaration and Assignment
        object obj = "This is an object."; // Object variable
        Console.WriteLine($"Object: {obj}");

        // Dynamic Declaration and Assignment
        dynamic dynamicVar = 42; // Dynamic variable
        Console.WriteLine($"Dynamic Variable: {dynamicVar}");

        // Nullable Types Declaration and Assignment
        int? nullableInt = null; // Nullable integer
        Console.WriteLine($"Nullable Integer: {nullableInt}");

        // Constant Declaration
        const double pi = 3.14159265359; // Constant double
        Console.WriteLine($"Constant Pi: {pi}");
    }
}
