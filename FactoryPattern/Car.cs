using System;
using FactoryPatter;

namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public Car()
        {
            Console.WriteLine("Building a new Car!");
        }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is now driving.");
        }
    }
}
