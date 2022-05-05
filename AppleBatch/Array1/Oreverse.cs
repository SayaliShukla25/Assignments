using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Array1
{
    class Oreverse
    {
        static void Main(string[] args)
        {

        
         int[] Array = { 10, 20, 30, 40, 50, 60, 70, 80, 90 };
            Console.WriteLine("Original Array:");
             for(int i=0;i< Array.Length;i++)
                Console.WriteLine(Array[i] + "  ");

            Console.WriteLine(); 

            Console.WriteLine("Original Array printed in reverse order:");
         for(int i=Array.Length-1;i>=0;i--)
                Console.WriteLine(Array[i] + "  ");
    }
}
    }

