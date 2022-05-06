using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.NewPrograms
{
    class Merge
    {
        static void Main(string[] args)
        {
            
               
                int[] array1 = { 1, 2, 3, 4, 5 };
                int[] array2 = { 6, 7, 8, 9, 10 };
                {

                    int[] array3 = new int[array1.Length + array2.Length];
                    Console.WriteLine(array3.Length);
                    for (int j = 0, i = 0; i < array3.Length; i++)
                    {
                        if (i < array1.Length)
                        {
                            array3[i] = array1[i];
                        }
                        if (i == array1.Length || i > array1.Length)
                        {
                            array3[i] = array2[j];
                            j++;
                        }
                    }
                    foreach (int element in array3)
                    {
                        Console.WriteLine(element);
                    }
                }
            }
        }
    }

    