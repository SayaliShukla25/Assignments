using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.String
{
    class Stringnew
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter name");
            string s2 = Console.ReadLine();
            int idx = s2.IndexOf('i');
            int lastidx = s2.LastIndexOf('a');
             
            Console.WriteLine(idx);
            Console.WriteLine(lastidx);
            string ss = "thinkquotient";
            Console.WriteLine(ss.Substring(3));
            Console.WriteLine(ss.Substring(3,2));

        }
    }
}
