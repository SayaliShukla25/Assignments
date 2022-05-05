using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Homework
{
    class Bouncy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter  number: ");
            int a = Convert.ToInt32(Console.ReadLine());


            Boolean isIncreasing = true;
            Boolean isDecreasing = true;


            int next = a % 10;
            a = a / 10;

            while (a > 0)
            {
                int prev = a % 10;
                if (prev > next)
                {
                    isIncreasing = false;

                }

                if (prev < next)
                {
                    isDecreasing = false;

                }
                a = a / 10;
                next = prev;
            }

            if (isIncreasing && isDecreasing)
                Console.WriteLine("AII ARE EQUAL");
            else if (isDecreasing)
                Console.WriteLine("number is decreasing");
            else if (isIncreasing)
                Console.WriteLine("number is increasing");
            else
                Console.WriteLine("bouncy");

        }
    }
}