using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{ 
    class PositiveNegative

    {
        static void Main(string[] args)
        {
            int n;
           Console.WriteLine("Enter a number : ");
            n = Convert.ToInt32(Console.ReadLine());
           
            if (n == 0)
            {
                Console.WriteLine(n + " is zero.");
            }
            else if (n > 0)
            {
                
                Console.WriteLine(n + " is a positive number.");
            }
            else
            {
                //6
                Console.WriteLine(n + " is a negative number.");
            }
        }
    }
}
        
    

