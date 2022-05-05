using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Test
{
    class Even1
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("even number: " + i);
                }
                else
                {
                    Console.WriteLine("Odd number: " + i*i);
                }
            }
        }
    }
}





