using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Array1
{
    class Reverse
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 2, 3, 4, 5 };

            Console.WriteLine("Original array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();

            Console.WriteLine("Array in reverse order: ");
        
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine(" \n");

             Console.WriteLine("Alternate elements of a given array \n");

            for (int i = 0; i < 5; i += 2)

            {
                Console.Write(arr[i] + " ");
            }

        }
    }
}






