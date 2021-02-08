using System;
namespace FactoryPatternExercise
{
    static class VehicleFactory
    {
        public static IVehicle GetVehicle(int numberOfTires)
        {
            switch (numberOfTires)
            {
                case 2:
                    return new Motorcycle();
                case 4:
                    return new Car();
                default:
                    return new Car();
            }
        }
    }
}
