using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_Statements
{
    class Program
    {
        static void Main(string[] args)
        {
            // Example of an if statement
            int number = 10;
            if (number > 0)
            {
                Console.WriteLine("Number is positive.");
            }

            // Example of an if-else statement
            int age = 17;
            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are not yet an adult.");
            }

            // Example of an if-else if-else statement
            int score = 75;
            if (score >= 90)
            {
                Console.WriteLine("Excellent!");
            }
            else if (score >= 70)
            {
                Console.WriteLine("Good job!");
            }
            else
            {
                Console.WriteLine("You need to improve.");
            }

            // Example of a switch statement
            char grade = 'B';
            switch (grade)
            {
                case 'A':
                    Console.WriteLine("Excellent!");
                    break;
                case 'B':
                    Console.WriteLine("Good job!");
                    break;
                case 'C':
                    Console.WriteLine("Average.");
                    break;
                default:
                    Console.WriteLine("Needs improvement.");
                    break;
            }

            // Example of the conditional (ternary) operator
            bool isEven = (number % 2 == 0) ? true : false;
            Console.WriteLine("Is the number even? " + isEven);
        }
    }
}
