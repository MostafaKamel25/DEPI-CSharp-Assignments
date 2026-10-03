using System;
using System.Collections.Generic;
using System.Text;

namespace Session09_Assignment
{
    public static class TextHelper
    {
        public static bool IsShorterThan(this string value, int length)
        {
            return value.Length < length;
        }

        public static string Repeat(this string value, int times)
        {
            string result = "";

            for (int i = 0; i < times; i++)
            {
                result += value;
            }

            return result;
        }
    }
}
