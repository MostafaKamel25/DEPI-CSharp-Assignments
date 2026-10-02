using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    internal class Car : IMoveable
    {
        public void MoveForward()
        {
            Console.WriteLine("Car moves forward");
        }

        public void MoveBackward()
        {
            Console.WriteLine("Car moves backward");
        }
    }
}
