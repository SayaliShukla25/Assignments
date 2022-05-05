using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class Odd
    {

        static void Main(string[] args)
        {
            for (int n = 512; n >= 229; n--)
            {
                if (n % 2 != 0)
                {
                    Console.WriteLine(n.ToString());

                }
            }
        }
    }
}