using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Array1
{
    class PrintB
    {
        public static void printBoundary(int[,] a,
                                     int m,
                                     int n)
        {
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == 0)
                        Console.Write(a[i, j] + " ");
                    else if (i == m - 1)
                        Console.Write(a[i, j] + " ");
                    else if (j == 0)
                        Console.Write(a[i, j] + " ");
                    else if (j == n - 1)
                        Console.Write(a[i, j] + " ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine(" ");
            }
        }

       
        static public void Main()
        {
            int[,] a = { { 1, 2, 3, 4 },
                      { 5, 6, 7, 8 },
                      { 1, 2, 3, 4 },
                      { 5, 6, 7, 8 } };

            printBoundary(a, 4, 4);
        }
    }
}
