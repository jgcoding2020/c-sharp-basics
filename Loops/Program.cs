using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example of a for loop
            Console.WriteLine("Example of a for loop:");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Iteration: " + i);
            }

            // Example of a while loop
            Console.WriteLine("\nExample of a while loop:");
            int count = 1;
            while (count <= 5)
            {
                Console.WriteLine("Count: " + count);
                count++;
            }

            // Example of a do-while loop
            Console.WriteLine("\nExample of a do-while loop:");
            int number;
            do
            {
                Console.Write("Enter a positive number (greater than 0): ");
            } while (!int.TryParse(Console.ReadLine(), out number) || number <= 0);
            Console.WriteLine("You entered a positive number: " + number);

            // Example of a foreach loop
            Console.WriteLine("\nExample of a foreach loop:");
            string[] fruits = { "Apple", "Banana", "Cherry" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine("Fruit: " + fruit);
            }
        }
    }
}
