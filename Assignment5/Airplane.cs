using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    internal class Airplane : IMoveable, IFlyable
    {
        public void MoveForward()
        {
            Console.WriteLine("Airplane moves forward in the air.");
        }

        public void MoveBackward()
        {
            Console.WriteLine("Airplane moves backward in the air.");
        }

        public void MoveUp()
        {
            Console.WriteLine("Airplane moves up.");
        }
        public void MoveDown()
        {
            Console.WriteLine("Airplane moves down.");
        }
    }
}
