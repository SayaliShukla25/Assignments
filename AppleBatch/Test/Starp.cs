using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Test
{
    class Starp
    {
        static void Main(string[] args)
        {


            for (int i = 5 - 1; i >= 0; i--)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

    

