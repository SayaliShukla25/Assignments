﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Array1
{
    class Merge2
    {
        static void Main(string[] args)
        {

        
        int i = 0;
        int j = 0;

        int[] arr1 = new int[4];
        int[] arr2 = new int[5];
        int[] arr3 = new int[9];

       
            Console.WriteLine("Enter elements of ARR1 : ");
            for (i = 0; i< 4; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr1[i] = int.Parse(Console.ReadLine());
    }

    
            Console.WriteLine("Enter elements of ARR2 : ");
            for (i = 0; i< 5; i++)
            {
                Console.Write("Element[" + (i + 1) + "]: ");
                arr2[i] = int.Parse(Console.ReadLine());
}


              for (i = 0, j = 0; i < 4; i++)
              {
                arr3[j++] = arr1[i];
               }
               for (i = 0; i < 5; i++)
                {
              arr3[j++] = arr2[i];
                 }

                    Console.WriteLine("Elements of ARR3 : ");
                   for (i = 0; i < 9; i++)
                  {
                     Console.WriteLine("Element[" + (i + 1) + "]: " + arr3[i]);

                   }

                Console.WriteLine();
        }
    }
}
    

