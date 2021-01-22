using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodePractice
{
    class IntegerPractice
    {

        static public class Solution
        {
            /// <summary>
            /// Given a signed 32-bit integer x, return x with its digits reversed. 
            /// If reversing x causes the value to go outside the signed 32-bit integer range [-231, 231 - 1], then return 0.
            /// Assume the environment does not allow you to store 64-bit integers(signed or unsigned).
            /// </summary>
            /// <param name="x"></param>
            /// <returns></returns>
            public static int Reverse(int x)
            {
                if (x > Int32.MaxValue || x < Int32.MinValue)
                    return 0;

                int result = 0;

                while (x != 0)
                {
                    
                    if (result > Int32.MaxValue/10 ) return 0; //because to be overflowed result> Int32.MaxValue/10
                    if (result < Int32.MinValue/10) return 0;  // if this is not the case, I can multiply
                    result *= 10;
                    result += x % 10;

                    x/= 10;
                }
               
                return result;
            }
            /// <summary>
            /// Given an integer x, return true if x is palindrome integer.
            /// An integer is a palindrome when it reads the same backward as forward.For example, 121 is palindrome while 123 is not.
            /// </summary>
            /// <param name="x"></param>
            /// <returns></returns>
            static public bool IsPalindrome(int x)
            {
                if (x == 0)
                    return true;
                if (x < 0 || x%10==0) // negatives and 1,2,3,4,5,6,7,8,9
                    return false;

                int reverted = 0;

                while (x > reverted)
                {
                    reverted = reverted * 10 + (x % 10);
                    x /= 10;
                }

                return (x == reverted || x == reverted / 10); //second case if reverted has n extra digit




            }
        

        static public void Main(string[] args)
            {
                //Console.WriteLine(Reverse(-2147483412));
                Console.WriteLine(IsPalindrome(100));


//                Console.WriteLine(Reverse(1534236469));
            }
        }
    }
}

