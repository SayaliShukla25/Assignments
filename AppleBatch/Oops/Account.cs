using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Oops
{
    class Account
    {
        long accno;
        string accname;
        string accounttype;
        long balance;
        public void accept()
        {
            Console.WriteLine("enter accno,accname,accounttype,balance");
            accno = Convert.ToInt64(Console.ReadLine());
            accname = Console.ReadLine();
            accounttype = Console.ReadLine();
            balance = Convert.ToInt64(Console.ReadLine());


        }
        public void withdraw()
        {
            Console.WriteLine("Enter withdraw amount:");
            int wamt = Convert.ToInt32(Console.ReadLine());
            if(balance<wamt)
                Console.WriteLine("insufficient balance");
            else
            {
                balance = balance - wamt;
                Console.WriteLine("withdraw Successful");
                Console.WriteLine("After withdraw balance="+balance);

            }

        }
        public void deposit()
        {
            Console.WriteLine("enter deposit amount");
            int damt = Convert.ToInt32(Console.ReadLine());
            balance = balance + damt;
            Console.WriteLine("Deposit successful after deposit balance is"+balance);


        }
        static void Main(string[] args)
        {
            Account ac = new Account();
            ac.accept();
            ac.withdraw();
            ac.deposit();
                
        }

        

    }
}
