using System;
using System.Collections.Generic;

namespace List_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of integers
            List<int> numbers = new List<int>();

            // Add elements to the list
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(5);

            // Display the list
            Console.WriteLine("List elements:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // Check if an element exists in the list
            bool contains3 = numbers.Contains(3);
            Console.WriteLine("Contains 3: " + contains3);

            // Find the index of an element
            int index = numbers.IndexOf(4);
            Console.WriteLine("Index of 4: " + index);

            // Remove an element
            numbers.Remove(2);

            // Display the modified list
            Console.WriteLine("Modified List elements:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // Sort the list
            numbers.Sort();

            // Display the sorted list
            Console.WriteLine("Sorted List elements:");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
            Console.WriteLine();

            // Clear all elements from the list
            numbers.Clear();
            Console.WriteLine("List cleared. Count: " + numbers.Count);
        }
    }
}
