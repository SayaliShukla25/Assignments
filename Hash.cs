using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace AccessModifier.MyCollection
{
    class Hash
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("Sayali", 80);
            ht.Add("Shukla", 80);
            ht.Add("sayalishukla@gmail.com", "student");

            foreach (var k in ht.Keys)
                Console.WriteLine("Key=" + k + "value " + ht[k]);




        }
    }
}

