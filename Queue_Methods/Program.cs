using System;
using System.Collections.Generic;

namespace Queue_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a queue of strings
            Queue<string> namesQueue = new Queue<string>();

            // Enqueue (add) elements to the queue
            namesQueue.Enqueue("Alice");
            namesQueue.Enqueue("Bob");
            namesQueue.Enqueue("Charlie");
            namesQueue.Enqueue("David");

            // Display the queue
            Console.WriteLine("Queue:");
            foreach (var name in namesQueue)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            // Dequeue (remove and return) elements from the queue
            string firstPerson = namesQueue.Dequeue();
            Console.WriteLine("Dequeued: " + firstPerson);

            // Peek at the front element without removing it
            string nextPerson = namesQueue.Peek();
            Console.WriteLine("Next in line: " + nextPerson);

            // Display the queue after dequeue and peek
            Console.WriteLine("Queue after dequeue and peek:");
            foreach (var name in namesQueue)
            {
                Console.WriteLine(name);
            }
            Console.WriteLine();

            // Check if the queue contains a specific element
            bool containsCharlie = namesQueue.Contains("Charlie");
            Console.WriteLine("Contains 'Charlie': " + containsCharlie);

            // Clear all elements from the queue
            namesQueue.Clear();

            // Check if the queue is empty
            bool isEmpty = namesQueue.Count == 0;
            Console.WriteLine("Queue is empty: " + isEmpty);
        }
    }
}
