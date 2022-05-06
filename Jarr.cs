using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.Stringtest
{
    class Jarr
    {
        static void Main(string[] args)
        {
            int[][] jaggedarr = new int[3][];

            jaggedarr[0] = new int[] { 1, 2, 3, 4 };
            jaggedarr[1] = new int[] { 11, 34, 67 };
            jaggedarr[2] = new int[] { 89, 23 };
            

            
            for (int i= 0; i < jaggedarr.Length; i++)
            {

              
                System.Console.Write("Row({0}): ", i);

                for (int c = 0; c< jaggedarr[i].Length; c++)
                {

                   
                    System.Console.Write("{0} ", jaggedarr[i][c]);
                }
                System.Console.WriteLine();
            }
        }
    }
}