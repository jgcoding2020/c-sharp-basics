using System;
using System.Collections.Generic;

namespace Stack_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a stack of integers
            Stack<int> numberStack = new Stack<int>();

            // Push (add) elements to the stack
            numberStack.Push(10);
            numberStack.Push(20);
            numberStack.Push(30);
            numberStack.Push(40);

            // Display the stack
            Console.WriteLine("Stack:");
            foreach (var number in numberStack)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            // Pop (remove and return) elements from the stack
            int topNumber = numberStack.Pop();
            Console.WriteLine("Popped: " + topNumber);

            // Peek at the top element without removing it
            int peekedNumber = numberStack.Peek();
            Console.WriteLine("Top element: " + peekedNumber);

            // Display the stack after pop and peek
            Console.WriteLine("Stack after pop and peek:");
            foreach (var number in numberStack)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();

            // Check if the stack contains a specific element
            bool contains30 = numberStack.Contains(30);
            Console.WriteLine("Contains 30: " + contains30);

            // Clear all elements from the stack
            numberStack.Clear();

            // Check if the stack is empty
            bool isEmpty = numberStack.Count == 0;
            Console.WriteLine("Stack is empty: " + isEmpty);
        }
    }
}
