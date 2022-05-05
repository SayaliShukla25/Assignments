using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Test
{
    class TwinPrime
    {
        static void Main(string[] args)
        {

            int a, b;
            
            Console.WriteLine("Enter first number: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number: ");
            b= Convert.ToInt32(Console.ReadLine());

            Boolean isAPrime = true;

            for (int i = 2; i <= a / 2; i++)
            {

                if (a % i == 0)
                {
                    isAPrime = false;
                    break;
                }

            }

            if (isAPrime && Math.Abs(a - b) == 2)
            {

                Boolean isBPrime = true;

                for (int i = 2; i <= b / 2; i++)
                {

                    if (b % i == 0)
                    {
                        isBPrime = false;
                        break;
                    }

                }

                if (isBPrime)
                    Console.WriteLine(a + " and " + b + " are twin prime");
                else
                    Console.WriteLine(a + " and " + b + " are not twin prime");
            }
            else
                Console.WriteLine(a + " and " + b + " are not twin prime");
        }
    }
}
    