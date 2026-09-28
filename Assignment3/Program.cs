using System.Text;

namespace Assignment3
{


    enum WeekDays
    {
        Monday , Tuesday , wednesday , Thursday , Friday , Saturday , Sunday
    }
    enum Season
    {
        Spring , Summer , Autumn , Winter
    }
    enum Permissions
    {
        Read = 1, Write = 2, Delete = 4, Execute = 8
    }
    enum Colors
    {
        Red , Green , Blue
    }

    struct Person
    {
        public int Age;
        public string Name;

    }

    struct Point
    {
        public double X;
        public double Y;

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
    internal class Program
    {


        static void Change(int x)
        {
            x = 100;
        }
        static void Change(ref int x)
        {
            x = 245;
        }
        static void ChangeString(string message)
        {
            message = "Suiii";
        }
        static void ChangeString(ref string message)
        {
            message = "Kamel";
        }
        static void SumSub(int n1 , int n2 , out int sumRes , out int subRes)
        {
            sumRes = n1 + n2;
            subRes = n1 - n2;
        }
        static int sum_of_individual_digits(int number)
        {
            int res = 0;
            while (number != 0 )
            {
                int mod = number % 10;
                res += mod;
                number /= 10;
            }
            return res;
        }
        static bool IsPrime(int num)
        {
            for (int i = 2; i*i <= num; i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
        static void MinMaxArray(out int minVal , out int maxVal , int[]arr)
        {
            minVal = arr.Min();
            maxVal = arr.Max();
        }
        static int fact(int n)
        {
            int res = 1;
            for (int i = 2; i <= n; i++)
            {
                res *= i;
            }
            return res;
        }
        static void ChangeChar(ref string s , char c, int pos)
        {
            StringBuilder newStr = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                if (i == pos)
                    newStr.Append(c);
                else
                    newStr.Append(s[i]);
            }
            s = newStr.ToString();
        }
        static void Main(string[] args)
        {

            #region Functions
            #region Q1
            //Passing by value: It passes a copy of the variable
            //Passing by reference: It passes a reference to the variable


            int ValueVar = 4;
            Change(ValueVar);
            Console.WriteLine("Value of ValueVar after passing by value: " + ValueVar);
            Change(ref ValueVar);
            Console.WriteLine("Value of ValueVar after passing by reference: " + ValueVar);
            #endregion

            #region Q2
            // By value: It sends a copy of the reference.
            // By reference: It sends the reference to the original variable.

            string refVal = "Mostafa";
            ChangeString(refVal);
            Console.WriteLine("Value of refVal after passing by value: " + refVal);
            ChangeString(ref refVal);
            Console.WriteLine("Value of refVal after passing by reference: " + refVal);


            #endregion

            #region Q3
            int n1 = 8, n2 = 3;
            int sumRes, subRes;
            SumSub(n1, n2, out sumRes, out subRes);
            Console.WriteLine($"{n1} + {n2} = {sumRes}");
            Console.WriteLine($"{n1} - {n2} = {subRes}");
            #endregion

            #region Q4
            int num = 259178;
            Console.WriteLine("the sum of the individual digits to " + num + " is: " + sum_of_individual_digits(num));
            #endregion

            #region Q5
            int primeCheck = 7;
            Console.WriteLine(IsPrime(primeCheck)); // true: 7 is a prime number 
            #endregion


            #region Q6
            int[] arr = { 4, 1, 2, 9, 7, 4, 6, 8 };
            int minV, maxV;
            MinMaxArray(out minV, out maxV, arr);
            Console.WriteLine($"Minimum: {minV} \nMaximum: {maxV}");
            #endregion

            #region Q7
            int factNum = 5;
            Console.WriteLine(fact(factNum));
            #endregion


            #region Q8
            string s = "Mustafa";
            Console.WriteLine(s);
            ChangeChar(ref s, 'o', 1);
            Console.WriteLine(s);

            #endregion
            #endregion


            #region Enum & Struct 

            #region Q1
            WeekDays WD = WeekDays.Monday;
            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(WD++);
            }
            #endregion


            #region Q2

            Person[] p = new Person[3];
            p[0].Name = "Ahmed";
            p[0].Age = 26;
            p[1].Name = "Mahmoud";
            p[1].Age = 24;
            p[2].Name = "Moustafa";
            p[2].Age = 21;

            for (int i = 0; i < p.Length; i++)
            {
                Console.WriteLine($"Person {i + 1}:");
                Console.WriteLine($"   Name:{p[i].Name}");
                Console.WriteLine($"   Age:{p[i].Age}");
            }
            #endregion


            #region Q3

            Console.WriteLine("Enter the season name: ");

            string seasonName = Console.ReadLine().ToLower();

            if (seasonName == "spring")
                Console.WriteLine("March to May");
            else if (seasonName == "summer")
                Console.WriteLine("June to August");
            else if (seasonName == "sutumn")
                Console.WriteLine("September to November");
            else if (seasonName == "winter")
                Console.WriteLine("December to February");
            else
                Console.WriteLine("Invalid input");
            #endregion

            #region Q4
            Permissions perm = Permissions.Read | Permissions.Write;
            if (Permissions.Write == (perm & Permissions.Write))
            {
                Console.WriteLine("User has Write permission");
            }

            #endregion
            #region Q5

            Console.WriteLine("Enter color name: ");
            string input = Console.ReadLine();
            if (Enum.TryParse(input, true, out Colors myColor))
            {
                Console.WriteLine($"{myColor} is a primary color");

            }
            else
                Console.WriteLine($"{myColor} is not a primary color");
            #endregion


            #region Q6
            Console.WriteLine("Enter Point 1: (X & Y)");
            Point p1 = new Point();
            p1.X = Convert.ToDouble(Console.ReadLine());
            p1.Y = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Point : (X & Y)");
            Point p2 = new Point();
            p2.X = Convert.ToDouble(Console.ReadLine());
            p2.Y = Convert.ToDouble(Console.ReadLine());

            double distance = Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
            Console.WriteLine($"The distance between the two points is: {distance:F2}");
            #endregion


            #region Q7

            Person[] pesrons = new Person[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"Enter name of person{i + 1}:");
                pesrons[i].Name = Console.ReadLine();
                Console.WriteLine($"Enter age of person{i + 1}:");
                pesrons[i].Age = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"The oldest Person:");
            Console.WriteLine($"   Name:{pesrons[0].Name}");
            Console.WriteLine($"   Age:{pesrons[0].Age}");

            #endregion

            #endregion




        }
    }
}
