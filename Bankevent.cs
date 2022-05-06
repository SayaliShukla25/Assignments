using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.Tprograms
{
    public delegate void bankDelegate();
    class Bankevent
    {
        private double balance;
        public event bankDelegate CreditInAcc;
        public event bankDelegate LowBal;
        public event bankDelegate ZeroBal;

        public Bankevent()
        {
            balance = 5000;
        }

        public void CreditAmount(double amt)
        {
            balance = balance + amt;
            CreditInAcc();  //raise an event
        }

        public void Debit(double debit)
        {
            if (balance == 0)
            {
                ZeroBal();
            }
            else if (balance < debit)
            {
                LowBal();
            }
            else
            {
                balance = balance - debit;
            }
            Console.WriteLine($"Current balance {balance}");
        }
    }

    public class Msg
    {
        public void CreditMsg()
        {
            Console.WriteLine("You account has been credited");
        }
        public void LowBalMsg()
        {
            Console.WriteLine("You account have no balance to debit the amount");
        }

        public void ZeroBalMsg()
        {
            Console.WriteLine("You account has zero balance");
        }
    }

    class BankEventtest
    {
        static void Main(string[] args)
        {
            Bankevent bank = new Bankevent();
            Msg msg = new Msg();
            bank.CreditInAcc += new bankDelegate(msg.CreditMsg);
            bank.LowBal += new bankDelegate(msg.LowBalMsg);
            bank.ZeroBal += new bankDelegate(msg.ZeroBalMsg);
            bank.CreditAmount(1000);
            bank.Debit(8000);
        }
    }

}

