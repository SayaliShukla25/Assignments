using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class Sumevenodd
    {
        static void Main(string[] args)
        {
            int n, totaleven = 0, totalodd = 0,num;
            Console.WriteLine("enter n value for even odd: ");
            n = Convert.ToInt32(Console.ReadLine());
            for ( num = 0; num < n; num++)
            {
                if (num % 2 == 0)
                {
                    Console.Write( num);
                    totaleven = totaleven + num;
                }
                else
                {
                    Console.WriteLine( num);
                    totalodd = totalodd + num;
                }
            }


            Console.WriteLine(" \n sum of all even numbers are : {0} \n sum of all odd numbers are : {1}", totaleven, totalodd);
        }
    }
}
    

