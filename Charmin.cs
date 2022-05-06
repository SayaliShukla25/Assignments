using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.NewPrograms
{
    class Charmin
    {
       static char smallest_alphabet(String a,
                                      int n)
        {

            char min = 'z';
            for (int i = 0; i < n - 1; i++)
                if (a[i] < min)
                    min = a[i];
                    return min;
        }

        
        public static void Main()
        {
            String a = "AdayR";
            int size = a.Length;

            Console.Write(smallest_alphabet(a, size));
        }
    }
}

