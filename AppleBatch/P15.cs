using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class P15
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }

        }

    }
}