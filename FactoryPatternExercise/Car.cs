﻿using System;
namespace FactoryPatternExercise
{
    public class Car : IVehicle
    {
        public Car()
        {
            
        }
        public void Drive()
        {
            Console.WriteLine("Building a new Car!");
        }

    }
}
