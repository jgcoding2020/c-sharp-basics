using System;
using System.Collections.Generic;

namespace LinkedList_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a LinkedList of strings
            LinkedList<string> linkedList = new LinkedList<string>();

            // Add elements to the LinkedList
            linkedList.AddLast("Apple");
            linkedList.AddLast("Banana");
            linkedList.AddLast("Cherry");

            // Display the LinkedList using a foreach loop
            Console.WriteLine("LinkedList:");
            foreach (string fruit in linkedList)
            {
                Console.Write(fruit + " ");
            }
            Console.WriteLine();

            // Add elements to the beginning and end of the LinkedList
            linkedList.AddFirst("Orange");
            linkedList.AddLast("Grapes");

            Console.WriteLine("LinkedList after adding elements:");
            foreach (string fruit in linkedList)
            {
                Console.Write(fruit + " ");
            }
            Console.WriteLine();

            // Check if an element exists in the LinkedList
            bool containsApple = linkedList.Contains("Apple");
            bool containsMango = linkedList.Contains("Mango");

            Console.WriteLine("Contains 'Apple': " + containsApple);
            Console.WriteLine("Contains 'Mango': " + containsMango);

            // Remove elements from the LinkedList
            linkedList.Remove("Banana");
            linkedList.RemoveLast();

            Console.WriteLine("LinkedList after removals:");
            foreach (string fruit in linkedList)
            {
                Console.Write(fruit + " ");
            }
            Console.WriteLine();

            // Get the first and last elements
            string firstFruit = linkedList.First.Value;
            string lastFruit = linkedList.Last.Value;

            Console.WriteLine("First Fruit: " + firstFruit);
            Console.WriteLine("Last Fruit: " + lastFruit);

            // Clear all elements from the LinkedList
            linkedList.Clear();
            Console.WriteLine("LinkedList cleared. Count: " + linkedList.Count);

            // Check if the LinkedList is empty
            bool isEmpty = linkedList.Count == 0;
            Console.WriteLine("LinkedList is empty: " + isEmpty);
        }
    }
}
