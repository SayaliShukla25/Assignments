using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier
{
    class H
    {
        public void M1()
        {
            Console.WriteLine("B");
        }
    }
    class C : H
    {
        public new void M1()
        {
            Console.WriteLine("B is new");
        }

    }
      class Hdemo
    { 

        static void Main(string[] args)
        {
            H obj = new H();
            obj.M1();

            C p1 = new C();
            p1.M1();

        }
    }
}
    

