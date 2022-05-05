using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Homework
{
    class Occ
    {
        static void Main(string[] args)
        {
            int num, tNum, digit, cnt;
            int rem;

            Console.WriteLine("Enter a number  : ");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter digit to search: ");
            digit = Convert.ToInt32(Console.ReadLine());


            cnt = 0;
            tNum = num;

            while (tNum > 0)
            {
                rem = tNum % 10;
                if (rem == digit)
                    cnt++;
                tNum /= 10;
            }


            Console.WriteLine("Total occurrence of item " + num + " is : " + cnt);

            Console.WriteLine();
        }

    }
    }

