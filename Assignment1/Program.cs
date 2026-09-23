namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"Number is: {number}");
            #endregion

            #region Q2
            string s = "123ae";
            int x = Convert.ToInt32(s);
            Console.WriteLine(x);
            // Unhandled exception. System.FormatException: The input string '123ae' was not in a correct format.
            #endregion

            #region Q3
            float num1 = 2.5f;
            float num2 = 7.5f;
            float res = num1 * num2;
            Console.WriteLine(res); // res is 18.75 , Correct
            #endregion

            #region Q4
            string myName = "Mostafa Kamel";

            string sub = myName.Substring(0, 7);
            Console.WriteLine(sub);

            #endregion

            #region Q5
            int val1 = 10;
            int val2 = 20;
            val1 = val2; // val1 updated to 20 , val2 still 20
            val2 = 47; // val2 updated to 47 , val1 still 20
            Console.WriteLine(val1); // 20
            Console.WriteLine(val2); // 47

            #endregion

            #region Q6
            int[] a1 = new int[4] { 1, 2, 3, 4 };
            int[] a2 = a1;
            a1[2] = 75638;
            Console.WriteLine(a1[2]); // 75638
            Console.WriteLine(a2[2]); // 75638
            // modifying the object via arr2  reflected when using arr1
            #endregion

            #region Q7
            Console.WriteLine("Enter first string:");
            string? Fstr = Console.ReadLine();

            Console.WriteLine("Enter second string:");
            string? Sstr = Console.ReadLine();
            string stringAll = $"{Fstr}  {Sstr}";

            Console.WriteLine(stringAll);
            #endregion

            #region Q8
            int d;
            d = Convert.ToInt32(!(30 < 20));
            //A value 0 will be assigned to d.

            #endregion


            #region Q9
            Console.WriteLine(13 / 2 + " " + 13 % 2);
            // 6 1 => int/int = int  
            #endregion

            #region Q10
            int num = 1, z = 5;
            if (!(num <= 0)) // if(!(false)) so condition is true
                Console.WriteLine(++num + z++ + " " + ++z); // 2 + 5  6 =>  7  7
            else
                Console.WriteLine(--num + z-- + " " + --z);


            #endregion
        }
    }
}
