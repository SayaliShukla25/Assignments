using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Array1
{
    class Maxcol2d
    {
        static void Main(string[] args)
        {
            int[,] arr2d = { { 3, 4, 1, 8 }, { 1, 4, 9, 11 }, { 76, 34, 21, 1 }, { 2, 1, 4, 5 } };
            int max;
            for (int c = 0; c < arr2d.GetLength(0); c++)
            {
                max = int.MinValue;
                for (int r = 0; r < arr2d.GetLength(1); r++)
                {
                    if (arr2d[r, c] > max)
                        max = arr2d[r, c];


                }
                Console.WriteLine($"Max on column{c} is  {max}");
            }
        }
    }
}
        
    

