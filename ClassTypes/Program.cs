using System;

namespace ClassTypesExample
{
    // Regular class
    class RegularClass
    {
        // A regular method that can be called on instances of this class
        public void RegularMethod()
        {
            Console.WriteLine("This is a regular class.");
        }
    }

    // Abstract class
    abstract class AbstractClass
    {
        // An abstract method that must be implemented by derived classes
        public abstract void AbstractMethod();
    }

    // Derived class from AbstractClass
    class DerivedClass : AbstractClass
    {
        // Implementation of the abstract method from the base class
        public override void AbstractMethod()
        {
            Console.WriteLine("This is a derived class from an abstract class.");
        }
    }

    // Sealed class
    sealed class SealedClass
    {
        // A method within a sealed class that can be called directly
        public void SealedMethod()
        {
            Console.WriteLine("This is a sealed class.");
        }
    }

    // Static class
    static class StaticClass
    {
        // A static method within a static class that can be called directly on the class
        public static void StaticMethod()
        {
            Console.WriteLine("This is a static class.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of each class type
            RegularClass regularObj = new RegularClass();
            DerivedClass derivedObj = new DerivedClass();
            SealedClass sealedObj = new SealedClass();

            // Call methods of each class
            regularObj.RegularMethod();
            derivedObj.AbstractMethod();
            sealedObj.SealedMethod();

            // Call the static method of the static class
            StaticClass.StaticMethod();
        }
    }
}
