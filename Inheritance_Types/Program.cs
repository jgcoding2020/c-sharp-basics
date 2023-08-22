using System;

namespace Inheritance_Types
{
    using System;

    // Base class (parent class) - Vehicle
    class Vehicle
    {
        public string Make { get; set; }   // Property to store the make of the vehicle
        public string Model { get; set; }  // Property to store the model of the vehicle

        public void Start()
        {
            Console.WriteLine($"{Make} {Model} is starting.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Make} {Model} is stopping.");
        }
    }

    // Single Inheritance: Car inherits from Vehicle
    class Car : Vehicle
    {
        public void Drive()
        {
            Console.WriteLine($"{Make} {Model} is driving.");
        }
    }

    // Multiple Inheritance: ElectricVehicle inherits from both Vehicle and ElectricDevice
    interface ElectricDevice
    {
        void Charge();
    }

    class ElectricCar : Car, ElectricDevice
    {
        public void Charge()
        {
            Console.WriteLine($"{Make} {Model} is charging.");
        }
    }

    // Multilevel Inheritance: SportsCar inherits from Car
    class SportsCar : Car
    {
        public void Race()
        {
            Console.WriteLine($"{Make} {Model} is racing.");
        }
    }

    // Hierarchical Inheritance: Truck and Bus both inherit from Vehicle
    class Truck : Vehicle
    {
        public void LoadCargo()
        {
            Console.WriteLine($"{Make} {Model} is loading cargo.");
        }
    }

    class Bus : Vehicle
    {
        public void TransportPassengers()
        {
            Console.WriteLine($"{Make} {Model} is transporting passengers.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Single Inheritance
            Car sedan = new Car { Make = "Toyota", Model = "Camry" };
            sedan.Start();
            sedan.Drive();
            sedan.Stop();

            // Multiple Inheritance
            ElectricCar tesla = new ElectricCar { Make = "Tesla", Model = "Model 3" };
            tesla.Start();
            tesla.Drive();
            tesla.Charge();
            tesla.Stop();

            // Multilevel Inheritance
            SportsCar ferrari = new SportsCar { Make = "Ferrari", Model = "488 GTB" };
            ferrari.Start();
            ferrari.Drive();
            ferrari.Race();
            ferrari.Stop();

            // Hierarchical Inheritance
            Truck volvoTruck = new Truck { Make = "Volvo", Model = "VNL 860" };
            volvoTruck.Start();
            volvoTruck.LoadCargo();
            volvoTruck.Stop();

            Bus mercedesBus = new Bus { Make = "Mercedes-Benz", Model = "Sprinter" };
            mercedesBus.Start();
            mercedesBus.TransportPassengers();
            mercedesBus.Stop();
        }
    }


}
