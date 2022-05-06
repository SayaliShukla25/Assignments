using System;
using System.Collections.Generic;
using System.Text;
// merging of array
namespace AccessModifier.Stringtest
{
    class Prog1
    {
        static void alternateMerge(int[] arr1, int[] arr2,
                           int n1, int n2, int[] arr3)
        {
            int i = 0, j = 0, k = 0;

           
            while (i < n1 && j < n2)
            {
                arr3[k++] = arr1[i++];
                arr3[k++] = arr2[j++];
            }

           
            while (i < n1)
                arr3[k++] = arr1[i++];

           
            while (j < n2)
                arr3[k++] = arr2[j++];
        }

  
        public static void Main()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            int n1 = arr1.Length;

            int[] arr2 = new int[] { 11, 22, 33, 44 };
            int n2 = arr2.Length;

            int[] arr3 = new int[n1 + n2];
            alternateMerge(arr1, arr2, n1, n2, arr3);

            Console.WriteLine();
            for (int i = 0; i < n1 + n2; i++)
                Console.Write(arr3[i] + " ");
        }
    }
}

