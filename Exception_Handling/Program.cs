using System;

namespace Exception_Handling
{
    class Program
    {
        // Define a custom exception class that inherits from Exception.
        class CustomException : Exception
        {
            public CustomException(string message) : base(message) { }
        }

        static void Main(string[] args)
        {
            try
            {
                // Divide by zero exception
                int a = 10;
                int b = 0;
                int result = a / b;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Divide by zero exception: " + ex.Message);
            }

            try
            {
                // Null reference exception
                string str = null;
                int length = str.Length;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Null reference exception: " + ex.Message);
            }

            try
            {
                // Index out of range exception
                int[] numbers = { 1, 2, 3 };
                int value = numbers[10];
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("Index out of range exception: " + ex.Message);
            }

            try
            {
                // Format exception
                string input = "abc";
                int number = int.Parse(input);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format exception: " + ex.Message);
            }

            try
            {
                // Custom exception
                throw new CustomException("This is a custom exception.");
            }
            catch (CustomException ex)
            {
                Console.WriteLine("Custom exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Generic exception handler: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally block always executes.");
            }
        }
    }
}
