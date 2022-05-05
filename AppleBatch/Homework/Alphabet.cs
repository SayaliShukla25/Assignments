using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class Alphabet
    {
        static void Main(string[] args)
        {
            char ch;

            Console.WriteLine("Alphabets from a - z are: ");
            for (ch = 'a'; ch <= 'z'; ch++)
            {
               
                Console.Write(ch + " ");
            }

            Console.ReadLine();
        }
    }
}
    

