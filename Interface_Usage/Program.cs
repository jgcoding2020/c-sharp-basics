using System;

namespace Interface_Usage
{
    // Define an interface called IDriveable
    public interface IDriveable
    {
        void Drive(); // Interface members have no method body
    }

    // Implement the IDriveable interface in two different classes
    public class Car : IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("Driving a car");
        }
    }

    public class Truck : IDriveable
    {
        public void Drive()
        {
            Console.WriteLine("Driving a truck");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create instances of classes that implement the IDriveable interface
            IDriveable car = new Car();
            IDriveable truck = new Truck();

            // Call the Drive method on each instance
            car.Drive();   // Calls the Drive method of Car class
            truck.Drive(); // Calls the Drive method of Truck class
        }
    }
}
