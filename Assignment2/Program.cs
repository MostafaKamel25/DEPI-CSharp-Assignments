using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            if (number % 3 == 0 && number % 4 == 0)
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");
            #endregion

            #region Q2 
            Console.WriteLine("Enter your number: ");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
                Console.WriteLine("Negative");
            else
                Console.WriteLine("Positive");

            #endregion


            #region Q3
            Console.WriteLine("Enter 3 numbers: ");
            int min = int.MaxValue;
            for (int i = 0; i < 3; i++)
            {
                int nums = int.Parse(Console.ReadLine());
                if (nums < min)
                    min = n;
            }
            Console.WriteLine($"Min: {min}");
            #endregion

            #region Q4 
            Console.WriteLine("Enter your number: ");
            int n1 = int.Parse(Console.ReadLine());
            if (n1 % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");

            #endregion

            #region Q5
            string s = Console.ReadLine();
            if (s == "a" || s == "e" || s == "e" || s == "o" || s == "u")
                Console.WriteLine("vowel");
            else
                Console.WriteLine("Consonant");

            #endregion

            #region Q6
            Console.WriteLine("Enter integer: ");

            int n2 = int.Parse(Console.ReadLine());
            n2 = (n2 > 1) ? n2 : 1;
            for (int i = 1; i <= n2; i++)
                Console.WriteLine(i);
            #endregion

            #region Q7
            Console.WriteLine("Enter a number: ");
            int multiplicationNum = int.Parse(Console.ReadLine());
            for (int i = multiplicationNum; i <= multiplicationNum * 12; i += multiplicationNum)
                Console.WriteLine(i);
            #endregion

            #region Q8

            Console.Write("Enter a number: ");
            int evenLimit = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= evenLimit; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            #endregion


            #region Q9

            Console.WriteLine("Enter two integers: ");
            int Base = Convert.ToInt32(Console.ReadLine());
            int Power = Convert.ToInt32(Console.ReadLine());
            int res = 1;

            for (int i = 1; i <= Power; i++)
            {
                res *= Base;
            }

            Console.WriteLine("Result = " + res);

            #endregion


            #region Q10

            Console.WriteLine("Enter Marks of five subjects: ");
            int[] marks = new int[5];
            int marksTotal = 0;
            for (int i = 0; i < 5; i++)
            {
                marks[i] = Convert.ToInt32(Console.ReadLine());
                marksTotal += marks[i];
            }

            int marksAverage = marksTotal / 5;
            double marksPercentage = (marksTotal / 500.0) * 100;

            Console.WriteLine("Total marks = " + marksTotal);
            Console.WriteLine("Average Marks = " + marksAverage);
            Console.WriteLine("Percentage = " + marksPercentage);

            #endregion


            #region Q11

            Console.Write("Enter Month Number: ");
            int monthNumber = Convert.ToInt32(Console.ReadLine());
            int daysInMonth;

            switch (monthNumber)
            {
                case 1:
                    daysInMonth = 31;
                    break;

                case 2:
                    daysInMonth = 28;
                    break;

                case 3:
                    daysInMonth = 31;
                    break;

                case 4:
                    daysInMonth = 30;
                    break;

                case 5:
                    daysInMonth = 31;
                    break;

                case 6:
                    daysInMonth = 30;
                    break;

                case 7:
                    daysInMonth = 31;
                    break;

                case 8:
                    daysInMonth = 31;
                    break;

                case 9:
                    daysInMonth = 30;
                    break;

                case 10:
                    daysInMonth = 31;
                    break;

                case 11:
                    daysInMonth = 30;
                    break;

                case 12:
                    daysInMonth = 31;
                    break;

                default:
                    daysInMonth = 0;
                    break;
            }

            if (daysInMonth != 0)
                Console.WriteLine("Days in Month: " + daysInMonth);
            else
                Console.WriteLine("Invalid Month Number");

            #endregion


            #region Q12

            char ans;
            do
            {
                Console.Write("Enter first number: ");
                double calculatorNumber1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter operator (+, -, *, /): ");
                char calculatorOperator = Convert.ToChar(Console.ReadLine());

                Console.Write("Enter second number: ");
                double calculatorNumber2 = Convert.ToDouble(Console.ReadLine());

                double calculatorResult = 0;

                switch (calculatorOperator)
                {
                    case '+':
                        calculatorResult = calculatorNumber1 + calculatorNumber2;
                        break;

                    case '-':
                        calculatorResult = calculatorNumber1 - calculatorNumber2;
                        break;

                    case '*':
                        calculatorResult = calculatorNumber1 * calculatorNumber2;
                        break;

                    case '/':
                        if (calculatorNumber2 != 0)
                            calculatorResult = calculatorNumber1 / calculatorNumber2;
                        else
                            Console.WriteLine("Cannot divide by zero.");
                        break;

                    default:
                        Console.WriteLine("Invalid operator.");
                        break;
                }

                Console.WriteLine("Result = " + calculatorResult);

                Console.WriteLine("For another operation, press 'y'; to exit, press anything else");
                ans = Convert.ToChar(Console.ReadLine());
            }
            while (ans == 'y');



            #endregion


            #region Q13

            Console.Write("Enter a string: ");
            string str = Console.ReadLine();

            string reversedStr = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversedStr += str[i];
            }

            Console.WriteLine("Reverse = " + reversedStr);

            #endregion


            #region Q14


            Console.Write("Enter an integer: ");
            int Number = Convert.ToInt32(Console.ReadLine());
            int ReversedNumber = 0;
            int mod;
            while (Number != 0)
            {
                mod = Number % 10;
                Number /= 10;
                ReversedNumber = ReversedNumber * 10 + mod;

            }

            Console.WriteLine("Reversed = " + ReversedNumber);

            #endregion

            #region Q15

            Console.WriteLine("Enter two numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            num1 = (num1 <= 1) ? 2 : num1;

            for (int i = num1; i <= num2; i++)
            {
                bool isPrime = true;
                for (int j = 2; j * j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                    Console.WriteLine(i);
            }

            #endregion


            #region Q16
            int myNum = Convert.ToInt32(Console.ReadLine());
            string binaryStr = "";
            while (myNum != 0)
            {
                int rem = myNum % 2;
                binaryStr = rem + binaryStr;
                myNum /= 2;
            }

            Console.WriteLine(binaryStr);

            #endregion

            #region Q17

            Console.Write("Enter Point1 X&Y: ");
            Point p1 = new Point();
            p1.X = Convert.ToInt32(Console.ReadLine());
            p1.Y = Convert.ToInt32(Console.ReadLine());


            Console.Write("Enter Point2 X&Y: ");
            Point p2 = new Point();
            p2.X = Convert.ToInt32(Console.ReadLine());
            p2.Y = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Point3 X&Y: ");
            Point p3 = new Point();
            p3.X = Convert.ToInt32(Console.ReadLine());
            p3.Y = Convert.ToInt32(Console.ReadLine());

            if ((p2.Y - p1.Y) * (p3.X - p2.X) ==
                (p3.Y - p2.Y) * (p2.X - p1.X))
            {
                Console.WriteLine("The points lie on a single straight line.");
            }
            else
            {
                Console.WriteLine("The points do not lie on a single straight line.");
            }

            #endregion


            #region Q18
            Console.Write("Enter the time: ");
            double Hours = Convert.ToDouble(Console.ReadLine());

            if (Hours >= 2 && Hours <= 3)
            {
                Console.WriteLine("Highly efficient.");
            }
            else if (Hours > 3 && Hours <= 4)
            {
                Console.WriteLine("You are instructed to increase your speed.");
            }
            else if (Hours > 4 && Hours <= 5)
            {
                Console.WriteLine("You need training to enhance your speed.");
            }
            else if (Hours > 5)
            {
                Console.WriteLine("You are required to leave the company.");
            }
            else
            {
                Console.WriteLine("Invalid time.");
            }

            #endregion

            #region Q19
            Console.Write("Enter the size: ");
            int matrixSize = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    if (i == j)
                        Console.Write("1 ");
                    else
                        Console.Write("0 ");
                }

                Console.WriteLine();
            }
            #endregion


            #region Q20

            Console.Write("Enter array size: ");
            int ArrSize = Convert.ToInt32(Console.ReadLine());

            int[] sumArray = new int[ArrSize];

            int Total = 0;

            Console.WriteLine("Enter array elements:");

            for (int i = 0; i < ArrSize; i++)
            {
                sumArray[i] = Convert.ToInt32(Console.ReadLine());
                Total += sumArray[i];
            }

            Console.WriteLine("Sum = " + Total);

            #endregion


            #region Q21
            Console.WriteLine("Enter the size: ");
            int sze = Convert.ToInt32(Console.ReadLine());
            int[] arr1 = new int[sze];
            Console.WriteLine("Enter first array: ");
            for (int i = 0; i < sze; i++)
            {
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            int[] arr2 = new int[sze];
            Console.WriteLine("Enter second array: ");
            for (int i = 0; i < sze; i++)
            {
                arr2[i] = Convert.ToInt32(Console.ReadLine());
            }


            int cnt1 = 0, cnt2 = 0;
            int totalSze = sze * 2;
            int[] arrRes = new int[totalSze];
            int cntRes = 0;
            while (cntRes < totalSze)
            {
                if (cnt1 >= sze)
                    arrRes[cntRes++] = arr2[cnt2++];
                else if (cnt2 >= sze)
                    arrRes[cntRes++] = arr1[cnt1++];


                else if (arr1[cnt1] < arr2[cnt2])
                {
                    arrRes[cntRes++] = arr1[cnt1++];
                }
                else
                {
                    arrRes[cntRes++] = arr2[cnt2++];
                }

            }

            Console.Write("merged array: ");
            for (int i = 0; i < totalSze; i++)
            {
                Console.Write(arrRes[i] + " ");
            }
            #endregion






            #region Q22

            int[] numbers = { 1, 2, 4, 1, 2, 1, 5, 4, 8, 98, 4, 1, 2 };
            bool[] visited = new bool[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (visited[i])
                    continue;

                int count = 1;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] == numbers[j])
                    {
                        visited[j] = true;
                        count++;
                    }
                }

                Console.WriteLine($"Element {numbers[i]} occurs {count}");
            }
            #endregion

            #region Q23


            int[] minMaxArray = { 4, 7, 8, 9, 1, 2, 3, 5, 4, 1, 78 };
            int minElement = minMaxArray[0];
            int maxElement = minMaxArray[0];

            for (int i = 1; i < minMaxArray.Length; i++)
            {
                if (minMaxArray[i] < minElement)
                {
                    minElement = minMaxArray[i];
                }

                if (minMaxArray[i] > maxElement)
                {
                    maxElement = minMaxArray[i];
                }
            }

            Console.WriteLine("Minimum = " + minElement);
            Console.WriteLine("Maximum = " + maxElement);

            #endregion


            #region Q24

            int[] elemnets = { 7, 8, 9, 12, 47, 36, 11 };
            int Fmax = int.MinValue, Smax = int.MinValue;
            for (int i = 0; i < elemnets.Length; i++)
            {
                if (elemnets[i] > Smax)
                {
                    if (elemnets[i] > Fmax)
                    {
                        Smax = Fmax;
                        Fmax = elemnets[i];
                    }
                    else
                        Smax = elemnets[i];
                }
            }
            Console.WriteLine("The second largest number is: " + Smax);


            #endregion

            #region Q25

            int[] distanceArr = { 7, 0, 0, 0, 5, 6, 7, 5, 0, 7, 5, 3 };

            int longest = 0;

            for (int i = 0; i < distanceArr.Length; i++)
            {
                for (int j = i + 1; j < distanceArr.Length; j++)
                {
                    if (distanceArr[i] == distanceArr[j])
                    {
                        int current = j - i - 1;

                        if (current > longest)
                        {
                            longest = current;
                        }
                    }
                }
            }

            Console.WriteLine("Longest distance = " + longest);

            #endregion

            #region Q26

            Console.Write("Enter words: ");
            string words = Console.ReadLine();

            string[] wordsStr = words.Split(' ');

            string reversed = "";

            for (int i = wordsStr.Length - 1; i >= 0; i--)
                reversed += wordsStr[i] + " ";


            Console.WriteLine(reversed);
            #endregion


            #region Q27

            Console.Write("Enter number of Row: ");
            int Row = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number of columns: ");
            int Col = Convert.ToInt32(Console.ReadLine());

            int[,] firstArr = new int[Row, Col];
            int[,] secondArr = new int[Row, Col];

            Console.WriteLine("Enter first matrix elements:");

            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    firstArr[i, j] =
                        Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    secondArr[i, j] =
                        firstArr[i, j];
                }
            }

            Console.WriteLine("Second matrix:");

            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Col; j++)
                {
                    Console.Write(secondArr[i, j] + " ");
                }

                Console.WriteLine();
            }

            #endregion


            #region Q28

            int[] reverseArray = { 4, 5, 8, 7, 9, 12, 4, 56, 16, 19 };


            Console.WriteLine("Array:");

            for (int i = 0; i < reverseArray.Length; i++)

            {
                Console.Write(reverseArray[i] + " ");
            }

            Console.WriteLine();


            Console.WriteLine("Array in reverse order:");

            for (int i = reverseArray.Length - 1; i >= 0; i--)

            {
                Console.Write(reverseArray[i] + " ");
            }

            Console.WriteLine();

            #endregion

        }




    }
}
