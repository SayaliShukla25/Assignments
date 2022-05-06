using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier
{
    class A
    {
        public virtual void M1()
        {
            Console.WriteLine("B");
        }
    }

      class B : A
        {
            public override void M1()
            {
                Console.WriteLine("B is new");
            }

        }
        class Atest
        {
            static void Main(string[] args)
            {
                B c = new B();
                c.M1();

                A p1 = new A();
                p1.M1();

            }
        }
    }


