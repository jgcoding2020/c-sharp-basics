using System;
using System.Collections.Generic;

namespace Generic_Types
{
    // Generic class
    class MyGenericClass<T>
    {
        public T Value { get; set; }

        public MyGenericClass(T value)
        {
            Value = value;
        }
    }

    // Generic method
    class GenericMethods
    {
        public static void Print<T>(T value)
        {
            Console.WriteLine("Value: " + value);
        }

        public static T Max<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) >= 0 ? a : b;
        }
    }

    // Generic interface
    interface IMyGenericInterface<T>
    {
        void Display(T value);
    }

    class MyGenericInterface<T> : IMyGenericInterface<T>
    {
        public void Display(T value)
        {
            Console.WriteLine("Value from interface: " + value);
        }
    }

    // Using generic collections
    class GenericCollections
    {
        public static void ListExample()
        {
            List<string> names = new List<string>();
            names.Add("Alice");
            names.Add("Bob");
            names.Add("Charlie");

            Console.WriteLine("List of Names:");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
        }

        public static void DictionaryExample()
        {
            Dictionary<int, string> students = new Dictionary<int, string>();
            students.Add(1, "Alice");
            students.Add(2, "Bob");
            students.Add(3, "Charlie");

            Console.WriteLine("Dictionary of Students:");
            foreach (KeyValuePair<int, string> student in students)
            {
                Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Generic class
            MyGenericClass<int> intGeneric = new MyGenericClass<int>(42);
            MyGenericClass<string> stringGeneric = new MyGenericClass<string>("Hello, Generics!");

            Console.WriteLine("Generic Class:");
            Console.WriteLine("Integer Value: " + intGeneric.Value);
            Console.WriteLine("String Value: " + stringGeneric.Value);

            // Generic method
            Console.WriteLine("\nGeneric Method:");
            GenericMethods.Print("This is a generic method.");
            Console.WriteLine("Max of 5 and 10: " + GenericMethods.Max(5, 10));
            Console.WriteLine("Max of 'apple' and 'banana': " + GenericMethods.Max("apple", "banana"));

            // Generic interface
            Console.WriteLine("\nGeneric Interface:");
            IMyGenericInterface<double> doubleInterface = new MyGenericInterface<double>();
            doubleInterface.Display(3.14);

            // Using generic collections
            Console.WriteLine("\nGeneric Collections:");
            GenericCollections.ListExample();
            GenericCollections.DictionaryExample();
        }
    }

}
