using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.Stringtest
{
    class Unique1
    {
        static public int Frequency(string str, char ch)
        {
            int c = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                    c++;
            }
            return c;
        }
        static void Main(string[] args)
        {
            string s1 = "ankita";
            string s2 = "adii";
            bool ispresent = true;

            for (int i = 0; i < s2.Length; i++)
            {
                char search = s2[i];
                int c1 = Frequency(s1, search);
                int c2 = Frequency(s2, search);

                if (c1 != c2)
                {
                    ispresent = false;
                    break;
                }

            }
            if (ispresent == true)
                Console.WriteLine("Formed");
            else
                Console.WriteLine("not");
            if (ispresent)
                Console.WriteLine($"{s2}can be formed {s1}");
            else
                Console.WriteLine("Can't be formed");

        }
    }
}

    
