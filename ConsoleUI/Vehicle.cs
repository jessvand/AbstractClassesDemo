using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public string Year { get; set; } = "1987";
        public string Make { get; set; } = "Whatever Make";
        public string Model { get; set; } = "Whateva Model";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine("This is my virtual method in Vehicle class");
        }
    }
}
