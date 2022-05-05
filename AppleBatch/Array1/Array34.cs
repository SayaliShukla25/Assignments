﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Array1
{
    class Array34
    {
        static void Main(string[] args)
        {
            int i, j;
            int[,] arr1 = new int[3, 4];

            Console.Write("Input elements in the matrix :\n");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 4; j++)
                {
                    Console.Write("element - [{0},{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("\nThe matrix is : \n");
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine("");
                for (j = 0; j < 4; j++)
                    Console.Write("{0}\t", arr1[i, j]);
            }
            Console.Write("\n\n");
        }
    }
}      