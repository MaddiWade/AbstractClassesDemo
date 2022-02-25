using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motercycle : Vehicle
    {
        public Motercycle()
        {
        }

        public bool HasSideCar = false;
        public override void DriveAbstract()
        {
            Console.WriteLine("This motercycle can drive");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine($"This {GetType().Name} is a { GetType().BaseType.Name} that is virtually in drive");
        }


    }

}
