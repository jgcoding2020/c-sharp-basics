using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparable_CompareTo
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int CompareTo(Person other)
        {
            // Compare persons based on age
            return this.Age.CompareTo(other.Age);
        }

        public override string ToString()
        {
            return $"{Name}, {Age} years old";
        }
    }

    public class Program
    {
        public static void Main()
        {
            List<Person> people = new List<Person>
        {
            new Person { Name = "Alice", Age = 30 },
            new Person { Name = "Bob", Age = 25 },
            new Person { Name = "Charlie", Age = 35 }
        };

            // Sort people based on age (using IComparable<T>)
            people.Sort();

            Console.WriteLine("Sorted People by Age:");
            foreach (Person person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
