using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    internal class Vehicle
    {
        public virtual void MoveForward()
        {
            Console.WriteLine("Vehicle moves forward.");
        }

        public virtual void MoveBackward()
        {
            Console.WriteLine("Vehicle moves backward.");
        }

        public virtual void MoveUp()
        {
            Console.WriteLine("Vehicle moves up.");
        }

        public virtual void MoveDown()
        {
            Console.WriteLine("Vehicle moves down.");
        }

    }
    // IVehicle gathered all the contracts.
}
