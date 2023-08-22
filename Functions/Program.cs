using System;

namespace Functions
{
    class Program
    {
        // Function with no parameters and no return value (void)
        static void SayHello()
        {
            Console.WriteLine("Hello, World!");
        }

        // Function with parameters and a return value
        static int Add(int a, int b)
        {
            return a + b;
        }

        // Function with a parameter array and a return value
        static double Average(params double[] numbers)
        {
            if (numbers.Length == 0)
            {
                return 0.0;
            }

            double sum = 0;
            foreach (double num in numbers)
            {
                sum += num;
            }
            return sum / numbers.Length;
        }

        // Function with reference parameters
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        // Function with an out parameter
        static bool TryParseInt(string input, out int result)
        {
            return int.TryParse(input, out result);
        }

        // Function that returns a string
        static string Greet(string name)
        {
            return "Hello, " + name + "!";
        }

        // Function that returns an array
        static int[] GenerateNumbers(int count)
        {
            int[] numbers = new int[count];
            for (int i = 0; i < count; i++)
            {
                numbers[i] = i + 1;
            }
            return numbers;
        }
        static void Main(string[] args)
        {
            // Calling functions with various return types and parameters
            SayHello();

            int sum = Add(5, 3);
            Console.WriteLine("Sum: " + sum);

            double avg1 = Average(1.0, 2.0, 3.0, 4.0, 5.0);
            Console.WriteLine("Average: " + avg1);

            double avg2 = Average(); // Handling empty array
            Console.WriteLine("Average: " + avg2);

            int a = 10, b = 20;
            Swap(ref a, ref b);
            Console.WriteLine("After Swap - a: " + a + ", b: " + b);

            string userInput = "42";
            if (TryParseInt(userInput, out int parsedValue))
            {
                Console.WriteLine("Parsed Value: " + parsedValue);
            }
            else
            {
                Console.WriteLine("Failed to parse.");
            }

            // Calling functions that return strings and arrays
            string greeting = Greet("Alice");
            Console.WriteLine(greeting);

            int[] numbersArray = GenerateNumbers(5);
            Console.WriteLine("Generated Numbers:");
            foreach (int num in numbersArray)
            {
                Console.Write(num + " ");
            }
        }
    }
}
