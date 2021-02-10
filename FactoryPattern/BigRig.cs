using System;
using FactoryPatter;

namespace FactoryPattern
{
    public class BigRig : IVehicle
    {
        public BigRig()
        {
            Console.WriteLine("Building a new BigRig.");
        }

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} is now driving.");
        }
    }
}
