using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class GcdLcm
    {
        static void Main(string[] args)
        {


            int x = 30;
            int y = 25;
            int gcd = 1;
            int temp, lcm;

            if (x > y)
            {
                temp = x;
                x = y;
                y = temp;
            }

            for (int i = 1; i < (x + 1); i++)
            {
                if (x % i == 0 && y % i == 0)
                    gcd = i;
            }

            lcm = (x * y) / gcd;
            Console.WriteLine("LCM of " + x + " and " + y + " is: " + lcm);
        }
    }
}