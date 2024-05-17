using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle: Vehicle
    {   public bool HasDogSeat { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("Here is abstract method in Motorcycle class");
    
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Here's my virtual method in Motorcycle class ");
        }
    }

    
}
