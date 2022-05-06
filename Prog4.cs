using System;
using System.Collections.Generic;
using System.Text;
//alternate positive negative
namespace AccessModifier.Stringtest
{
    class Prog4
    {
        static void rightrotate(int[] arr, int n,
                            int limit, int cur)
        {
            int tmp = arr[cur];
            for (int i = cur; i > limit; i--)
                arr[i] = arr[i - 1];
            arr[limit] = tmp;
        }
         static void rearrange(int[] arr, int n)
        {
            int limit = -1;

            for (int index = 0; index < n; index++)
            {
                if (limit >= 0)
                {
                    if (((arr[index] >= 0)&& (arr[limit] < 0))|| ((arr[index] < 0)&& (arr[limit] >= 0)))
                    {
                        rightrotate(arr, n, limit, index);

                       
                        if (index -limit > 2)
                            limit = limit+ 2;
                        else
                            limit= -1;
                    }
                }

                if (limit == -1)
                {
                   
                    if (((arr[index] >= 0)&& ((index & 0x01) == 0))|| ((arr[index] < 0) && (index & 0x01) == 1))
                        limit = index;
                }
            }
        }
        static void printArray(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(arr[i] + " ");
            Console.WriteLine("");
        }
       static void Main(string[] args)
        {
                
        int[] arr = { 1, 2, 3, -4, -1, 4 };
            int n = arr.Length;

            Console.WriteLine();
            printArray(arr, n);

            rearrange(arr, n);

            Console.WriteLine();
            printArray(arr, n);
        }
    }
}
