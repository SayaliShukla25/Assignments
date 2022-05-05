using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Array1
{
    class Class100
    {
        static void Main(string[] args)
        {
            int n, r, sum = 0, temp;
             n = Convert.ToInt32(Console.ReadLine());
            temp = n;
            while (n > 0)
            {
                r = n % 10;
                sum = (sum * 10) + r;
                n = n / 10;
            }
            if (temp == sum)
                Console.WriteLine(" is Palindrome.");
            else
                Console.WriteLine(" not Palindrome");
        }
    }
    }

