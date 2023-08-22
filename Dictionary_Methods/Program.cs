using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a dictionary of string keys and int values
            Dictionary<string, int> scores = new Dictionary<string, int>();

            // Add key-value pairs to the dictionary
            scores.Add("Alice", 95);
            scores.Add("Bob", 88);
            scores.Add("Charlie", 75);
            scores.Add("David", 92);

            // Display the dictionary
            Console.WriteLine("Dictionary:");
            foreach (var kvp in scores)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            Console.WriteLine();

            // Check if a key exists in the dictionary
            bool containsAlice = scores.ContainsKey("Alice");
            Console.WriteLine("Contains 'Alice': " + containsAlice);

            // Retrieve the value associated with a key
            int bobScore;
            if (scores.TryGetValue("Bob", out bobScore))
            {
                Console.WriteLine("Bob's Score: " + bobScore);
            }

            // Modify the value associated with a key
            scores["Charlie"] = 80;

            // Display the modified dictionary
            Console.WriteLine("Modified Dictionary:");
            foreach (var kvp in scores)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
            Console.WriteLine();

            // Remove a key-value pair
            scores.Remove("David");

            // Display the dictionary after removal
            Console.WriteLine("Dictionary after removal:");
            foreach (var kvp in scores)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }
        }
    }
}
