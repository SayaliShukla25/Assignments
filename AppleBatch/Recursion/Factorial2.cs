using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Recursion
{
    class Factorial2
    {
        public static int factorial(int n)
        {
            if (n == 1)
                return 1;
            else
            {
                int ans = factorial(n - 1);
                return n * ans;
            }
        }
        static void Main(string[] args)
        {
            int result = factorial(4);
            Console.WriteLine("factorial:"+result);
        }



    }
}




    

