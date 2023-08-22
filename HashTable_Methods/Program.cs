using System;
using System.Collections;

namespace HashTable_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Hashtable
            Hashtable myHashtable = new Hashtable();

            // Add key-value pairs to the Hashtable
            myHashtable.Add("Name", "John");
            myHashtable.Add("Age", 30);
            myHashtable.Add("IsStudent", false);

            // Display the Hashtable
            Console.WriteLine("Hashtable:");
            foreach (DictionaryEntry entry in myHashtable)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
            Console.WriteLine();

            // Access values by key
            string name = (string)myHashtable["Name"];
            Console.WriteLine($"Name: {name}");
            int age = (int)myHashtable["Age"];
            Console.WriteLine($"Age: {age}");
            bool isStudent = (bool)myHashtable["IsStudent"];
            Console.WriteLine($"Is Student: {isStudent}");
            Console.WriteLine();

            // Check if the Hashtable contains a specific key
            bool containsKey = myHashtable.ContainsKey("Name");
            Console.WriteLine("Contains 'Name' key: " + containsKey);
            Console.WriteLine();

            // Check if the Hashtable contains a specific value
            bool containsValue = myHashtable.ContainsValue(30);
            Console.WriteLine("Contains value '30': " + containsValue);
            Console.WriteLine();

            // Remove a key-value pair
            myHashtable.Remove("IsStudent");
            Console.WriteLine("Hashtable after removal:");
            foreach (DictionaryEntry entry in myHashtable)
            {
                Console.WriteLine($"{entry.Key}: {entry.Value}");
            }
            Console.WriteLine();

            // Clear all key-value pairs from the Hashtable
            myHashtable.Clear();
            Console.WriteLine("Hashtable cleared. Count: " + myHashtable.Count);

            // Check if the Hashtable is empty
            bool isEmpty = myHashtable.Count == 0;
            Console.WriteLine("Hashtable is empty: " + isEmpty);
        }
    }
}
