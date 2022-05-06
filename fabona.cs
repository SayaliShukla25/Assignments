using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier
{
    class fabona
    {
        static void Main(string[] args)
        {


            int n, t1 = 0, t2 = 1, nextTerm = 0, i;
            Console.WriteLine("Enter the n value: ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n == 0 || n == 1)
                Console.WriteLine(n);
            else
                nextTerm = t1 + t2;
            for (i = 3; i <= n; ++i)
            {
                t1 = t2;
                t2 = nextTerm;
                nextTerm = t1 + t2;
            }
            Console.WriteLine(t2);
        }
    }
}    




     
  
            
    

