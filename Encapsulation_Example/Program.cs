using System;

namespace Encapsulation_Example
{
    class Student
    {
        // Private fields (attributes)
        private string name;
        private int age;

        // Public methods (getters and setters)
        public string GetName()
        {
            return name;
        }

        public void SetName(string studentName)
        {
            name = studentName;
        }

        public int GetAge()
        {
            return age;
        }

        public void SetAge(int studentAge)
        {
            if (studentAge < 0)
            {
                Console.WriteLine("Age cannot be negative.");
            }
            else
            {
                age = studentAge;
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Create a Student object
            Student student1 = new Student();

            // Set student information using the public methods
            student1.SetName("Alice");
            student1.SetAge(20);

            // Access student information using the public methods
            Console.WriteLine("Student Name: " + student1.GetName());
            Console.WriteLine("Student Age: " + student1.GetAge());

            // Try setting an invalid age
            student1.SetAge(-5); // This will not change the age because it's negative

            // Access the age again to confirm it hasn't changed
            Console.WriteLine("Student Age (after invalid change): " + student1.GetAge());
        }
    }
}
