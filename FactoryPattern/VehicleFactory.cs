using System;
using FactoryPatter;

namespace FactoryPattern
{
    public static class VehicleFactory 
    {
        public static IVehicle GetVehicle(string wheels)
        {
            switch (wheels)
            {
                case "4":
                    return new Car();
                case "2":
                    return new Motorcycle();
                case "18":
                    return new BigRig();
                default:
                    return new Car();
                


            }

        }


    }


}

