using System;
using System.Collections.Generic;
using System.Text;

namespace Project01
{
    internal class Point3D : IComparable, ICloneable
    {
        public double X { get; set; }
        public double Y { get; set; }
        public double Z { get; set; }
        public Point3D()
        {
            X = 0;
            Y = 0;
            Z = 0;

        }
        public Point3D(double x, double y)
        {
            X = x;
            Y = y;
        }
        public Point3D(double x, double y, double z) : this(x, y)
        {

            Z = z;

        }
        public override string ToString()
        {
            return $"Point Coordinates: ({X},{Y},{Z})";
        }

        public int CompareTo(object? obj)
        {
            Point3D? other = obj as Point3D;

            if (other == null)
                return 1;

            int result = X.CompareTo(other.X);

            if (result == 0)
                result = Y.CompareTo(other.Y);

            return result;
        }


        public object Clone()
        {
            return new Point3D(X, Y, Z);
        }
    }
}
