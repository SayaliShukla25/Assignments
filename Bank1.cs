using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace AccessModifier.Tprograms
{
    public delegate void Delegate1();
    public class Bank1
    {
        int balance = 10000;
        public int Balance
        {
            get { return balance; }
        }

        public event Delegate1 Event1;
        public event Delegate1 Event2;
        public void WithDraw(int debitamt)
        {
            if (balance == debitamt)
            {
                Event1();
            }
            if (balance < debitamt)
            {
                Event2();
                return;
            }
            balance -= debitamt;

            Console.WriteLine($"Balance after Withdraw is:{balance}");
        }
    }
    public class BDiposit
    {
        static void Error1()
        {
            Console.WriteLine("Balance zero after withdrawl");
        }
        static void Error2()
        {
            Console.WriteLine("Balance is low  cannot withdraw");
        }


        static void Main(string[] args)
        {
            Bank1 b = new Bank1();
            Console.WriteLine($" balance is:{b.Balance}");
            Console.WriteLine("enter amount to be withdrawn");
            int w = Convert.ToInt32(Console.ReadLine());
            b.Event1 += new Delegate1(Error1);
            b.Event2 += new Delegate1(Error2);

            b.WithDraw(w);

        }
    }
}


    

  
    
        
    
        
    

        
        