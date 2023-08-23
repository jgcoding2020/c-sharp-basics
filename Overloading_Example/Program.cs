using System;

namespace Overloading_Example
{
    class Calculator
    {
        // Method to add two integers
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Method to add three integers
        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        // Method to add two double values
        public double Add(double x, double y)
        {
            return x + y;
        }

        // Method to concatenate two strings
        public string Add(string str1, string str2)
        {
            return str1 + str2;
        }

        // Method to concatenate three strings
        public string Add(string str1, string str2, string str3)
        {
            return str1 + str2 + str3;
        }
    }

    class Program
    {
        static void Main()
        {
            Calculator calc = new Calculator();

            // Using the Add methods to perform various operations
            int sum1 = calc.Add(5, 10);
            int sum2 = calc.Add(5, 10, 15);
            double sum3 = calc.Add(3.5, 2.7);
            string concat1 = calc.Add("Hello, ", "world!");
            string concat2 = calc.Add("Hello, ", "C#", " world!");

            // Displaying the results
            Console.WriteLine("Sum1: " + sum1);
            Console.WriteLine("Sum2: " + sum2);
            Console.WriteLine("Sum3: " + sum3);
            Console.WriteLine("Concat1: " + concat1);
            Console.WriteLine("Concat2: " + concat2);
        }
    }

}
