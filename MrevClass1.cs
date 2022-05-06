using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.Stringtest
{
    class MrevClass1
    {
        static String reverseWord(String str)
        {
            int len = str.Length;
            int i = 1;
            int j = str.Length - 2;
            char[] strchar = str.ToCharArray();
            while (i < j)
            {
                char temp = strchar[i];
                strchar[i] = strchar[j];
                strchar[j] = temp;
                i++;
                j--;
            }
            str = new String(strchar);
            return str;
        }

        static void reverseWords(String str)
        {
            String[] tok = str.Split(' ');
            foreach (String w in tok)
            {
                Console.Write(reverseWord(w) + " ");
            }
        }
        public static void Main(String[] args)
        {
            String str = " Hi how are you students ";
            reverseWords(str);
        }

    }
}


