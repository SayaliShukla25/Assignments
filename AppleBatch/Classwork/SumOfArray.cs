using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Classwork
{
    class SumOfArray
    {
        static void Main(string[] args)
        {

            const int n = 5;
            int[] a = new int[n] { 10, 20, 30, 40, 50 };

            int[] b = new int[n] { 5, 4, 3, 2, 1 };

            int[] arr = new int[n];

            for (int i = 0, j = 0; i < a.Length; i++, j++)

            {
                arr[i] = a[i] + b[j];

            }

            for (int i = 0; i < arr.Length; i++)

            {

                Console.Write(arr[i] + " ");

            }

            Console.Read();

        }



    }

}

