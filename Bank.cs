using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.inherit
{
    class Bank
    {
        public void withdraw()
        {
            Console.WriteLine("in withdraw");
        }

        public void deposit()
        {
            Console.WriteLine("in deposit");

        }
    }
    class HDFC : Bank
    {
        static void Main(string[] args)
        {
            HDFC h = new HDFC();
            h.withdraw();
        }
    }
}
    

    
        
