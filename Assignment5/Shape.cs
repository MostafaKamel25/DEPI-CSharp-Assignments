using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment5
{
    internal class Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Shape(double width , double height)
        {
            Width = width;
            Height = height;

        }
        public double Area()
        {
            return Width * Height;
        }
        public override string ToString()
        {
            return $"(Width = {Width}, Height = {Height})";
        }

    }
}
