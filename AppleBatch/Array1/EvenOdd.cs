using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Array1
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[5];
            int[] arr3 = new int[5];
            int i, j = 0, k = 0;

            for (i = 0; i < 5; i++)
            {
                if (arr1[i] % 2 == 0)
                {
                    arr2[j] = arr1[i];
                    j++;
                }
                else
                {
                    arr3[k] = arr1[i];
                    k++;
                }
            }
            Console.WriteLine("Even numbers...");
            for (i = 0; i < j; i++)
            {
                Console.WriteLine(arr2[i]);
            }
            Console.WriteLine("Odd numbers...");
            for (i = 0; i < k; i++)
            {
                Console.WriteLine(arr3[i]);
            }
        }
    }
}