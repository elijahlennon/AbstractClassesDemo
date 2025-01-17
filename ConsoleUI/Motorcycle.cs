﻿using System;
namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
        }
        public bool HasSideCar { get; set; } = false;

        public override void DriveAbstract()
        {
            Console.WriteLine("This motorcycle might fall apart!");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name} that is driving virtually!");
        }
    }
}
