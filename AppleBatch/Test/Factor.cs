using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Test
{
    class Factor
    {
        static void Main(string[] args)
        {
            int number; ;

            Console.WriteLine("Enter the number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Factors of " + number + " are: ");
            for (int i = 1; i <= number; ++i)
            {

                if (number % i == 0)
                {
                    Console.WriteLine(i + " ");
                }
            }
        }
    }
}
