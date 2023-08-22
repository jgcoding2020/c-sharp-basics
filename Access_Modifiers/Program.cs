using System;

namespace AccessModifierExample
{
    public class MyClass
    {
        // Public field (accessible from anywhere)
        public int PublicField = 10;

        // Private field (accessible only within the class)
        private int PrivateField = 20;

        // Protected field (accessible within the class and derived classes)
        protected int ProtectedField = 30;

        // Internal field (accessible within the same assembly)
        internal int InternalField = 40;

        // Protected internal field (accessible within the same assembly and derived classes)
        protected internal int ProtectedInternalField = 50;

        // Private protected field (C# 7.2 and later, accessible within the same assembly and derived classes)
        private protected int PrivateProtectedField = 60;

        // Public constructor (accessible from anywhere)
        public MyClass()
        {
            Console.WriteLine("Public Constructor");
        }

        // Private constructor (accessible only within the class)
        private MyClass(int value)
        {
            Console.WriteLine("Private Constructor with Value: " + value);
        }

        // Public method (accessible from anywhere)
        public void PublicMethod()
        {
            Console.WriteLine("Public Method");
        }

        // Private method (accessible only within the class)
        private void PrivateMethod()
        {
            Console.WriteLine("Private Method");
        }

        // Protected method (accessible within the class and derived classes)
        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected Method");
        }

        // Internal method (accessible within the same assembly)
        internal void InternalMethod()
        {
            Console.WriteLine("Internal Method");
        }

        // Protected internal method (accessible within the same assembly and derived classes)
        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("Protected Internal Method");
        }

        // Private protected method (C# 7.2 and later, accessible within the same assembly and derived classes)
        private protected void PrivateProtectedMethod()
        {
            Console.WriteLine("Private Protected Method");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of MyClass
            MyClass myObject = new MyClass();

            // Access members of MyClass with different access modifiers
            Console.WriteLine("Public Field: " + myObject.PublicField);
            // Console.WriteLine("Private Field: " + myObject.PrivateField); // Error, private field is not accessible from here
            // Console.WriteLine("Protected Field: " + myObject.ProtectedField); // Error, protected field is not accessible from here
            Console.WriteLine("Internal Field: " + myObject.InternalField);
            Console.WriteLine("Protected Internal Field: " + myObject.ProtectedInternalField);
            // Console.WriteLine("Private Protected Field: " + myObject.PrivateProtectedField); // Error, private protected field is not accessible from here

            myObject.PublicMethod();
            // myObject.PrivateMethod(); // Error, private method is not accessible from here
            // myObject.ProtectedMethod(); // Error, protected method is not accessible from here
            myObject.InternalMethod();
            myObject.ProtectedInternalMethod();
            // myObject.PrivateProtectedMethod(); // Error, private protected method is not accessible from here
        }
    }
}

