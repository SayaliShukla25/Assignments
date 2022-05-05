using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Array1
{
    class MERGE
    {
        static void Main(string[] args)
        {


            int[] a = { 1, 2, 3, 4 };
            int[] b = { 90, 91, 92, 93, 94 };


            int[] array3 = new int[a.Length + b.Length];
            Console.WriteLine(array3.Length);
            for (int j = 0, i = 0; i < array3.Length; i++)
            {
                if (i < a.Length)
                {
                    array3[i] = a[i];
                }
                if (i == a.Length || i > a.Length)
                {
                    array3[i] = b[j];
                    j++;
                }
            }
            foreach (int element in array3)
            {
                Console.WriteLine(element);
            }
        }
    }
}
