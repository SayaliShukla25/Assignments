﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Test
{
    class Amicable
    {
        static void Main(string[] args)
        {
            int num1, num2, sum1 = 0, sum2 = 0, i;
            Console.WriteLine("Enter First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number : ");
            num2 = int.Parse(Console.ReadLine());
            for (i = 1; i < num1; i++)
            {
                if (num1 % i == 0)
                {
                    sum1 = sum1 + i;
                }
            }
            for (i = 1; i < num2; i++)
            {
                if (num2 % i == 0)
                {
                    sum2 = sum2 + i;
                }
            }
            if (num1 == sum2 && num2 == sum1)
            {
                Console.WriteLine("They are a Pair of Amicable Numbers");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("They are not Amicable Numbers");
                Console.ReadLine();
            }
        }
    }
}       
        
    

