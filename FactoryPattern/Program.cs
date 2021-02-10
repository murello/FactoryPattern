using System;
using FactoryPatter;

namespace FactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels will your vehicle have?");
            var numberOfWheels = Console.ReadLine();

            IVehicle vehicle1 = VehicleFactory.GetVehicle(numberOfWheels);
            Console.WriteLine();

            vehicle1.Drive();
        }
    }
}
