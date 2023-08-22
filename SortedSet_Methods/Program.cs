using System;
using System.Collections.Generic;

namespace SortedSet_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a SortedSet of integers
            SortedSet<int> numbers = new SortedSet<int>();

            // Add elements to the SortedSet
            numbers.Add(5);
            numbers.Add(2);
            numbers.Add(8);
            numbers.Add(1);
            numbers.Add(5); // Duplicates are automatically removed in a SortedSet

            // Display the SortedSet
            Console.WriteLine("SortedSet:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // Check if an element exists in the SortedSet
            bool containsThree = numbers.Contains(3);
            bool containsEight = numbers.Contains(8);

            Console.WriteLine("Contains 3: " + containsThree);
            Console.WriteLine("Contains 8: " + containsEight);

            // Remove elements from the SortedSet
            numbers.Remove(2);
            numbers.Remove(7); // Trying to remove an element that doesn't exist is safe

            Console.WriteLine("SortedSet after removals:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // Get the minimum and maximum elements
            int min = numbers.Min;
            int max = numbers.Max;

            Console.WriteLine("Minimum: " + min);
            Console.WriteLine("Maximum: " + max);

            // Clear all elements from the SortedSet
            numbers.Clear();
            Console.WriteLine("SortedSet cleared. Count: " + numbers.Count);

            // Check if the SortedSet is empty
            bool isEmpty = numbers.Count == 0;
            Console.WriteLine("SortedSet is empty: " + isEmpty);
        }
    }
}
