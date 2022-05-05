using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Test
{
    class Pyramid1222
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 4 - i; j >= 1; j--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= 2 * i - 1; j++)
                {
                    Console.Write(i); ;
                }
                Console.WriteLine();
            }
        }
    }
}

