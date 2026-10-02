using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    internal class Ship : IMoveable
    {
        public void MoveForward()
        {
            Console.WriteLine("Ship moves forward on the sea.");
        }

        public void MoveBackward()
        {
            Console.WriteLine("Ship moves backward on the sea.");
        }

    }
}
