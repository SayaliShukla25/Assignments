using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class VowelCo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a alphabet:");
            char input = Convert.ToChar(Console.ReadLine());
            if (input == 'a' || input == 'A' || input == 'e' || input == 'E' || input == 'i' || input == 'I' || input == 'o'
                    || input == 'O' || input == 'u' || input == 'U')
            {
                Console.WriteLine("It is a vowel");
            }
            else if ((input >= 'a' && input <= 'z') || (input >= 'A' && input <= 'Z'))
            {

                Console.WriteLine("Its is a consonant");
            }
            else
            {
                Console.WriteLine("Invalid input ");
            }
        }
    }
}
    

