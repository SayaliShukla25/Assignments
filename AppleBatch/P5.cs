using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class P5
    {
        static void Main(string[] args)
        {
            int alphabet = 65;
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write((char)(alphabet + i - 1) + " ");
                }
                Console.WriteLine();
            }
        }
    }

}
        
    

