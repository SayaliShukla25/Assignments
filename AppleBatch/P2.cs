using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class P2
    {
        static void Main(string[] args)
        {

            int alphabet = 65;
            

            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write((char)(alphabet + j - 1) + " ");
                }
                Console.WriteLine();
            }
        }
    }

}