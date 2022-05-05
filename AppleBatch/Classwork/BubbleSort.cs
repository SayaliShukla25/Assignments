using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Classwork
{
    class BubbleSort
    {
        static void Main(string[] args)
        {
            int[] number = { 123,56,-9,8,10,8,4,8 };

            bool flag = true;
            int numLength = number.Length;

            //sorting an array  
            for (int i = 1; (i < (numLength - 1)) && flag; i++)
            {
                flag = false;
                for (int j = 0; j < (numLength - 1); j++)
                {
                    if (number[j + 1] > number[j])
                    {
                       int temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                        flag = true;
                    }
                }
            }

           foreach (int num in number)
            {
                Console.Write("\t {0}", num);
            }
            Console.Read();
        }
    }
}






