using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Array1
{
    class NewArr
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 }; 
            int[] arr2 = new int[arr1.Length];
  
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            } 
            Console.WriteLine("Elements of original array: ");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }

            Console.WriteLine(); 
            Console.WriteLine("Elements of new array: ");
            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
        }
    }
}
    

