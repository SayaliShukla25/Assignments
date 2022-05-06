using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.Stringtest
{
    class Acend
    {

        static void sort(String[] s, int n)
        {
            for (int i = 1; i < n; i++)
            {
                String temp = s[i];

               
                int j = i - 1;
                while (j >= 0 && temp.Length < s[j].Length)
                {
                    s[j + 1] = s[j];
                    j--;
                }
                s[j + 1] = temp;
            }
        }
      static void printArraystring(String[] str, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(str[i] + " ");
        }
         static void Main(string[] args)
        {

            String[] arr = { "Love", "I", "India", "Country" };
            int n = arr.Length;
           sort(arr, n);
           printArraystring(arr, n);

        }
    }
}


 