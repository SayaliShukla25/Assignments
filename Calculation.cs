using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.Tprograms
{
    public delegate int MyDelegate(int n1, int n2);
    class Calculation
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }

    class Caltest
    {
        static void Main(string[] args)
        {
            Calculation c = new Calculation();
            MyDelegate mydel = new MyDelegate(c.Add);
            mydel += new MyDelegate(c.Sub);
            mydel += new MyDelegate(c.Multiply);
            mydel -= new MyDelegate(c.Sub);
            Delegate[] list = mydel.GetInvocationList();
            foreach(Delegate d in list)
            {
                Console.WriteLine(d.Method);
                Console.WriteLine(d.DynamicInvoke(45,32));
            }
        }
    }
}
