using System;

namespace Overriding_Example
{
    using System;

    // Base class
    class Plant
    {
        public virtual void Grow()
        {
            Console.WriteLine("A plant is growing");
        }
    }

    // Derived class
    class Flower : Plant
    {
        public override void Grow()
        {
            Console.WriteLine("A flower is growing");
        }
    }

    class Program
    {
        static void Main()
        {
            Plant plant = new Plant();
            Flower flower = new Flower();

            // Calls the Grow method of the base class
            plant.Grow(); // Output: A plant is growing

            // Calls the overridden Grow method of the derived class
            flower.Grow(); // Output: A flower is growing

            // Polymorphism in action
            Plant polymorphicPlant = new Flower();
            polymorphicPlant.Grow(); // Output: A flower is growing
        }
    }

}
