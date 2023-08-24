using System;

namespace Array_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating an array
            int[] numbers = { 1, 2, 3, 4, 5 };

            // Accessing elements by index
            Console.WriteLine("Accessing elements by index:");
            Console.WriteLine("First element: " + numbers[0]);
            Console.WriteLine("Last element: " + numbers[numbers.Length - 1]);

            // Iterating through an array using a for loop
            Console.WriteLine("\nIterating through the array:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Element " + i + ": " + numbers[i]);
            }

            // Using the foreach loop
            Console.WriteLine("\nUsing the foreach loop:");
            foreach (int number in numbers)
            {
                Console.WriteLine("Element: " + number);
            }

            // Sorting the array
            Console.WriteLine("\nSorting the array:");
            Array.Sort(numbers);
            foreach (int number in numbers)
            {
                Console.WriteLine("Element: " + number);
            }

            // Reversing the array
            Console.WriteLine("\nReversing the array:");
            Array.Reverse(numbers);
            foreach (int number in numbers)
            {
                Console.WriteLine("Element: " + number);
            }

            // Searching for an element
            int searchValue = 3;
            int index = Array.IndexOf(numbers, searchValue);
            Console.WriteLine("\nSearching for value " + searchValue + " at index: " + index);

            // Copying an array
            int[] copy = new int[numbers.Length];
            Array.Copy(numbers, copy, numbers.Length);
            Console.WriteLine("\nCopied array:");
            foreach (int number in copy)
            {
                Console.WriteLine("Element: " + number);
            }

            // Resizing an array (not recommended)
            Array.Resize(ref copy, copy.Length + 1);
            copy[copy.Length - 1] = 6;
            Console.WriteLine("\nResized array:");
            foreach (int number in copy)
            {
                Console.WriteLine("Element: " + number);
            }
        }
    }
}
