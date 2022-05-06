using System;
using System.Collections.Generic;
using System.Text;
//max in row 2d array
namespace AccessModifier.Stringtest
{
    class Prog7
    {
        static void Main(string[] args)
        {

            int[,] arr2d = { { 22, 31, 9 }, { 12, 25, 16 } };
            int max;
            for (int r = 0; r < arr2d.GetLength(0); r++)
            {
                max = int.MinValue;
                for (int c = 0; c < arr2d.GetLength(1); c++)
                {
                    if (arr2d[r, c] > max)
                        max = arr2d[r, c];


                }
                Console.WriteLine(max);
            }
        }
    }
}
