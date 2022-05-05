using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter a number  : ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
              Console.WriteLine(" even number");
            }
            else
            {
              Console.WriteLine("  odd number");
            }
        }
    }
}
       
    

