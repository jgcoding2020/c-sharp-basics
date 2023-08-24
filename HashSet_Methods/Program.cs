using System;
using System.Collections.Generic;

namespace HashSet_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a hash set of integers
            HashSet<int> numbers = new HashSet<int>();

            // Add elements to the hash set
            numbers.Add(5);
            numbers.Add(10);
            numbers.Add(15);
            numbers.Add(20);

            // Display the hash set
            Console.WriteLine("HashSet:");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            // Check if an element exists in the hash set
            bool contains10 = numbers.Contains(10);
            Console.WriteLine("Contains 10: " + contains10);

            // Remove an element from the hash set
            numbers.Remove(15);

            // Display the hash set after removal
            Console.WriteLine("HashSet after removal:");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine();

            // Create another hash set
            HashSet<int> otherNumbers = new HashSet<int> { 10, 30, 40, 50 };

            // Union of two hash sets
            numbers.UnionWith(otherNumbers);

            // Display the union of hash sets
            Console.WriteLine("Union of HashSet and Other HashSet:");
            foreach (var num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
