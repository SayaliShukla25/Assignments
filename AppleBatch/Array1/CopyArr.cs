﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Array1
{
    class CopyArr
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            int i, n;

            Console.Write("enter number of elements :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input {0} elements in the array :\n", n);
            for (i = 0; i < 5; i++)
            {
                Console.Write("element - {0} : ", i);
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (i = 0; i < 5; i++)
            {
                arr2[i] = arr1[i];
            }

            Console.Write("\nThe elements stored in the first array are :\n");
            for (i = 0; i < 5; i++)
            {
                Console.Write("{0}  ", arr1[i]);

                Console.Write("\n\nThe elements copied into the second array are :\n");
                for (i = 0; i < 5; i++)
                {
                    Console.Write("{0}  ", arr2[i]);
                }
                Console.Write("\n\n");
            }
        }
    }
}
    


    
