using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class P19
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 5; j >= i; j--)
                {
                    Console.Write((char)(65 + j - 1) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
    

