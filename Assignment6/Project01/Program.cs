namespace Project01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 & 2
            Point3D P = new Point3D(10, 10, 10);

            Console.WriteLine(P.ToString());


            // 3
            Point3D P1 = new Point3D();
            Point3D P2 = new Point3D();

            Console.Write("Enter P1 X: ");
            P1.X = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter P1 Y: ");
            P1.Y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter P1 Z: ");
            P1.Z = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter P2 X: ");
            P2.X = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter P2 Y: ");
            P2.Y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter P2 Z: ");
            P2.Z = Convert.ToInt32(Console.ReadLine());


            // 4
            if (P1 == P2)
                Console.WriteLine("P1 and P2 are equal");
            else
                Console.WriteLine("P1 and P2 are NOT equal");


            // 5
            Point3D[] points =
            {
                new Point3D(5, 10, 20),
                new Point3D(2, 30, 40),
                new Point3D(5, 5, 50),
                new Point3D(1, 20, 60)
            };

            Array.Sort(points);

            Console.WriteLine("\nSorted Points:");

            foreach (Point3D point in points)
            {
                Console.WriteLine(point);
            }


            // 6
            Point3D P3 = (Point3D)P1.Clone();

            Console.WriteLine("\nOriginal:");
            Console.WriteLine(P1);

            Console.WriteLine("Clone:");
            Console.WriteLine(P3);
        }
    }

}
