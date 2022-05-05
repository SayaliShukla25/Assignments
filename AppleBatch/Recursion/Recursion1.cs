using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Recursion
{
    class Recursion1
    {
        static void printrev(int n)
        {
            if (n<= 0)
            {
                return;
            }
            else
            {
                Console.WriteLine(n+ "");
                printrev(n - 1);
            }
        }

        static void Main(string[] args)
        {
            int n = 5;
            printrev(5);
            
           
        }
    }
}
