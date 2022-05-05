using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Array1
{
    class Arr2D
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int[,] a2 = new int[3, 4];
            Console.WriteLine(a2.Length);

            for (int r = 0; r < 3; r++)
            {
                Console.WriteLine("enter the elements on row" + r);
                for (int c = 0; c < 4; c++)
                {
                    a2[r, c] = int.Parse(Console.ReadLine());

                }
            }
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write(a2[r, c] + "");
                }
                Console.WriteLine();
            }
        }
    }
}
            

