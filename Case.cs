using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.Tprograms
{
    public delegate void MDelegate(string name);
    class Case
    {
        public void UpperCase(string name)
        {
            Console.WriteLine(name.ToUpper());
        }
        public void LowerCase(string name)
        {
            Console.WriteLine(name.ToLower());
        }


    }
    class Casetest
    {
        static void Main(string[] args)
        {
            Case c = new Case();
            MDelegate del = new MDelegate(c.UpperCase);
            del += new MDelegate(c.LowerCase);

            Delegate[] list2 = del.GetInvocationList();
            foreach (Delegate d in list2)
            {
                Console.WriteLine(d.Method);
                d.DynamicInvoke("Sayali");
            }

        }
    }
}
