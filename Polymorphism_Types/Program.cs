using System;

namespace Polymorphism_Types
{
    // Base class representing an Employee
    class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // Constructor to initialize employee details
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        // Virtual method to display employee information
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Employee: {FirstName} {LastName}");
        }
    }

    // Derived class representing a Manager
    class Manager : Employee
    {
        // Constructor for Manager
        public Manager(string firstName, string lastName) : base(firstName, lastName) { }

        // Override the base class method to display manager information
        public override void DisplayInfo()
        {
            Console.WriteLine($"Manager: {FirstName} {LastName}");
        }
    }

    // Derived class representing a Developer
    class Developer : Employee
    {
        // Constructor for Developer
        public Developer(string firstName, string lastName) : base(firstName, lastName) { }

        // Override the base class method to display developer information
        public override void DisplayInfo()
        {
            Console.WriteLine($"Developer: {FirstName} {LastName}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Compile-time Polymorphism (Method Overloading)
            Calculate(5, 10);
            Calculate(3.5, 2.5);

            // Runtime Polymorphism (Method Overriding)
            Employee emp1 = new Employee("John", "Doe");
            Employee emp2 = new Manager("Alice", "Smith");
            Employee emp3 = new Developer("Bob", "Johnson");

            DisplayEmployeeInfo(emp1);
            DisplayEmployeeInfo(emp2);
            DisplayEmployeeInfo(emp3);

            // Operator Overloading (Ad hoc Polymorphism)
            Vector2D v1 = new Vector2D(2, 3);
            Vector2D v2 = new Vector2D(1, 2);
            Vector2D v3 = v1 + v2;

            Console.WriteLine($"Vector Addition: ({v3.X}, {v3.Y})");
        }

        // Compile-time Polymorphism (Method Overloading)
        static void Calculate(int a, int b)
        {
            Console.WriteLine($"Sum (int): {a + b}");
        }

        static void Calculate(double a, double b)
        {
            Console.WriteLine($"Sum (double): {a + b}");
        }

        // Runtime Polymorphism (Method Overriding)
        static void DisplayEmployeeInfo(Employee emp)
        {
            emp.DisplayInfo();
        }
    }

    // Operator Overloading (Ad hoc Polymorphism)
    class Vector2D
    {
        public double X { get; set; }
        public double Y { get; set; }

        // Constructor to initialize vector components
        public Vector2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        // Operator overloading for vector addition
        public static Vector2D operator +(Vector2D v1, Vector2D v2)
        {
            return new Vector2D(v1.X + v2.X, v1.Y + v2.Y);
        }
    }

}
