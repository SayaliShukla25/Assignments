﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Test
{
    class Harshad1
    {
        static void Main(string[] args)
        {
            int num = 156;
            int rem = 0, sum = 0, n;


            n = num;


            while (num > 0)
            {
                rem = num % 10;
                sum = sum + rem;
                num = num / 10;
            }


            if (n % sum == 0)
                Console.WriteLine(n + " is a harshad number");
            else
                Console.WriteLine(n + " is not a harshad number");
        }
    }
}
    


    

