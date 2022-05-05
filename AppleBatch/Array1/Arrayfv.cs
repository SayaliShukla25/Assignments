using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Array1
{
    class Arrayfv
    {
        static void Main(string[] args)
        {

        
        int[][] jag = new int[3][];

         jag[0] = new int[] { 12, 34, 5, 6, 7 };
         jag[1] = new int[] { 15, 52 };
         jag[2] = new int[] { 1, 2, 3 };

        for (int i = 0; i < 3; i++)
        {
          for (int j = 0; j < jag[i].Length; j++)
        {
           Console.Write("{0}\t", jag[i][j]);
        }
              Console.WriteLine();
     }

          Console.ReadLine();
        }
    }
}
    

