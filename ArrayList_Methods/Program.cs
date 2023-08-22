using System;
using System.Collections;

namespace ArrayList_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an ArrayList
            ArrayList myArrayList = new ArrayList();

            // Add elements to the ArrayList
            myArrayList.Add(10);
            myArrayList.Add("Hello");
            myArrayList.Add(3.14);
            myArrayList.Add(true);

            // Display the ArrayList
            Console.WriteLine("ArrayList:");
            foreach (var item in myArrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Access elements by index
            Console.WriteLine("Element at index 1: " + myArrayList[1]);
            Console.WriteLine();

            // Insert an element at a specific index
            myArrayList.Insert(1, "Inserted");
            Console.WriteLine("ArrayList after insertion:");
            foreach (var item in myArrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Remove an element
            myArrayList.Remove("Hello");
            Console.WriteLine("ArrayList after removal:");
            foreach (var item in myArrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            // Check if the ArrayList contains a specific element
            bool containsHello = myArrayList.Contains("Hello");
            Console.WriteLine("Contains 'Hello': " + containsHello);
            Console.WriteLine();

            // Clear all elements from the ArrayList
            myArrayList.Clear();
            Console.WriteLine("ArrayList cleared. Count: " + myArrayList.Count);

            // Check if the ArrayList is empty
            bool isEmpty = myArrayList.Count == 0;
            Console.WriteLine("ArrayList is empty: " + isEmpty);
        }
    }
}
