using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Array
{
    class minmax
    {
        static void Main(string[] args)
        {

            int i, mx, mn, n;
            int[] arr1 = new int[7];
            Console.Write("enter elements:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }


            mx = arr1[0];
            mn = arr1[0];

            for (i = 1; i < n; i++)
            {
                if (arr1[i] > mx)
                {
                    mx = arr1[i];
                }
                if (arr1[i] < mn)
                {
                    mn = arr1[i];
                }
            }
            Console.Write("Maximum element is : {0}", mx);
            Console.Write("Minimum element is : {0}", mn);
        }
    }
}



    

