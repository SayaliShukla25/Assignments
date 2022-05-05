using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Test
{
    class Trimorphic
    {
        static void Main(string[] args)
        {


            int n = 4;

            int cube = n * n * n;

            while (n != 0)
            {
                if (n % 10 != cube % 10)
                {
                    Console.WriteLine("Not a Trimorphic number");
                    break;
                }

                n = n / 10;

                cube = cube / 10;
            }

            if (n == 0)
            {
                Console.WriteLine("Trimorphic number");

            }
        }
    }
}

    

