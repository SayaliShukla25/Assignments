using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class AlphaDigit
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter any character: ");
            ch = Convert.ToChar(Console.ReadLine());

           
            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + "is  Alphabet. ");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine(ch + "is Digit. ");
            }
            else
            {
                Console.WriteLine(ch + "is Special character.. ");
            }

            Console.ReadLine();
        }
    }
}
    

