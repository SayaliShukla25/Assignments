﻿using System;
using System.Collections.Generic;
using System.Text;
//swap
namespace AccessModifier.Stringtest
{
    class Prog2
    {
        static void Main(string[] args)
        {
            int[] item = test(new[] { 1, 5, 7, 9, 11, 13 });
            Console.Write("After swapping first two and last two elements: ");
            foreach (var i in item)
            {
                Console.Write(i.ToString() + " ");
            }
        }
        static int[] test(int[] numbers)
        {
            int first = numbers[0];
            numbers[0] = numbers[numbers.Length - 1];
            numbers[numbers.Length - 1] = first;

            

            return numbers;
        }
    }
}

    

