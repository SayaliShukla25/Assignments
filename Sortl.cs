using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.Stringtest
{
    class Sortl
    {
        static void Main(string[] args)
        {


            string[] name = { "om", "ajay", "tiya", "priya" };
            foreach (string value in name)
            {
                Console.Write(value);
                Console.Write(' ');

            }
            Array.Sort(name);
            Console.WriteLine("\nsorted....");
            foreach (string value in name)
            {
                Console.Write(value);
                Console.Write(' ');
            }
            Console.WriteLine();
        }
    }
}
