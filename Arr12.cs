using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace AccessModifier.MyCollection
{
    class Arr12
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            Console.WriteLine(al.Count);
            Console.WriteLine(al.Capacity);
            
            al.Add("sayali");
            al.Add(20);
            al.Add("Pune");
            al.Add("sayalishukla@gmail.com");
            al.Add(true);
            al.Remove("sayali");
            al.RemoveAt(2);
            al.Insert(1,"shukla");
            al.Reverse();
            
            for(int i=0;i<al.Count;i++)
            {
                Console.WriteLine(al[i]);
            }
            foreach(var i in al)
                Console.WriteLine(i);
        }
    }
}
