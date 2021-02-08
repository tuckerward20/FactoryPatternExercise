using System;

namespace FactoryPatternExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many wheels does your vehicle have?");
            int userVehicle = Convert.ToInt32(Console.ReadLine());

            IVehicle vehicle = VehicleFactory.GetVehicle(userVehicle);
            vehicle.Drive();
            Console.ReadLine();
        }
    }
}
