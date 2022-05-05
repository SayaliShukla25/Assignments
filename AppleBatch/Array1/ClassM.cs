using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Array1
{ 
 class ClassM
    {
        static public void main(String[] args)
        {

            Console.WriteLine("Enter the 10 floating point numbers:");
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("The average is " + average(array));

        }

       public static int average(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum / array.Length;

        }

        public static double average(double[] array)
        {
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            return sum / array.Length;
        }

    }
}