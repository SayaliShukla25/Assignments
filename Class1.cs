using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier
{
    class Class1
    {
        static int id;
        string name;
        int number;

        internal Class1()
        {
            Console.WriteLine(" in default constructor");
        }

        internal Class1(string name, int number)
        {
            this.name = name;
            this.number = number;
            Console.WriteLine(name + "" + number);
        }

        static Class1()
        {
            Console.WriteLine("IN STATIC CONSTRUCTOR");
            id = 1566;
            Console.WriteLine(id);
        }



        class classtest
        {
            static void Main(string[] args)
            {
                Class1 c = new Class1("sayali", 565);
            }

        }
    }
}
    

