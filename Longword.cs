using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.ArrayProgram
{
    class Longword
    {
        static void Main(string[] args)
        {

            string text;
            string[] stringList;
            int ni = 0, len, max = 0;


            Console.Write("Enter a string :");
            text = Console.ReadLine();
            stringList = text.Split(' ');
            len = stringList.Length;

            
            for (int i = 0; i < len; i++)
            {
                if (stringList[i].Length > max)
                {
                    max = stringList[i].Length;
                    ni = i;
                }
            }

         
            Console.WriteLine("Longest string:{0} \n Count of count of chrackter:{1}", stringList[ni], max);
            Console.ReadLine();
        }
    }

}

