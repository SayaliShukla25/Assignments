using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier
{
    class Parent
    {
        public virtual void study()
        {
            Console.WriteLine("studying");
        }
    }
    class Child : Parent
    {
        public override void study()
        {
            Console.WriteLine("learning from online videos");
        }

        class subchild : Parent
        {
            public override void study()
            {
                Console.WriteLine("learning videos");
            }
          
    }
        static void Main(string[] args)
        {
            Child c = new Child();
            c.study();

            Parent p1 = new Parent();
            p1.study();

            

            Parent p2 = new subchild();
            p1.study();
        }
    }


}
