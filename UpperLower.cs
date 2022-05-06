using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.NewPrograms
{
    class UpperLower
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Enter the String in Uppercase :");
            str = Console.ReadLine();
            Console.WriteLine("String in LowerCase : {0}", str.ToLower());
            Console.ReadLine();
        }
    }
}
    

