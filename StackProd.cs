using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.Tprograms
{
    class StackProd
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Price{ get; set; }

    }
    public class prodT
    {
        static void Main(string[] args)
        {

            StackProd p1 = new StackProd()
            {
                ID = 101,
                Name = "hp laptop",
                Price = 80000
            };
            StackProd p2 = new StackProd()

            {
                ID = 102,
                Name = "Dell laptop",
                Price = 50000
            };
            StackProd p3 = new StackProd()


            {
                ID = 103,
                Name = "Lenovo Laptop",
                Price = 40000
            };
            StackProd p4 = new StackProd()
            {
                ID = 104,
                Name = "Asus",
                Price = 40000
            };
            
            Stack<StackProd> stackproduct = new Stack<StackProd>();
            stackproduct.Push(p1);
            stackproduct.Push(p2);
            stackproduct.Push(p3);
            stackproduct.Push(p4);
            

            foreach (StackProd p in stackproduct)
            {
                Console.WriteLine(p.ID + " - " + p.Name + " -  " + p.Price);



            }
            StackProd s1 = stackproduct.Pop();
            Console.WriteLine(s1.ID + " - " + s1.Name + " - " + s1.Price);
            Console.WriteLine("Items left in the Stack = " + stackproduct.Count);


        }
    }
}
    

