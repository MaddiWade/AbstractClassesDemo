using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "1990";
        public string Make { get; set; } = "Default";
        public string Model { get; set; } = "Default";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is virtually in drive");
        }
        

        
    }

}
