using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Array1
{
    class Pair
    {
        public static void getPairsCount(int[] arr, int sum)
        {

            int count = 0;
            for (int i = 0; i < arr.Length; i++)
                for (int j = i + 1; j < arr.Length; j++)
                    if ((arr[i] + arr[j]) == sum)
                        count++;

            Console.WriteLine("Count of pairs is " + count);
        }
            static public void Main()
        {
            int[] arr = { 2, 4, 3, 5, 6, -2, 4, 7, 8};
            int sum = 7;
            getPairsCount(arr, sum);
        }
    }
}


        