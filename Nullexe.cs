using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.ExepHandling
{
    class Nullexe
    {
        static void Main(string[] args)
        {
            Nullexe n = new Nullexe();
            string str = null;
            try
            {
                Console.WriteLine(str.ToCharArray());
            }
            catch (NullReferenceException err)
            {
                Console.WriteLine("Please check the string str.");

                Console.WriteLine(err.Message);
            }

        }
    }
}


