using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ohce.Helpers
{
    static public class Extensions
    {
        public static bool IsPalindrome(this string str1, string str2)
        {
            return str1 == str2;
        }
        public static string ReverseString(this string str)
        {
            char[] charsArray = str.ToCharArray();
            string reversedString = string.Empty;
            for (int i = charsArray.Length - 1; i >= 0; i--)
            {
                reversedString += charsArray[i];
            }
                
            return reversedString;
        }
    }
}
