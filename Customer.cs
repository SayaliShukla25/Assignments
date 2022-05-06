using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.Tprograms
{
    public class Customer
    {
        public int CusId { get; set; }
        public string CusName { get; set; }
        public string CusAdd { get; set; }

        public List<Accounts> AccList = new List<Accounts>();
    }
    public class Accounts
    {
        public string AccType { get; set; }
        public long Accno { get; set; }

        public List<Loan> LoanList = new List<Loan>();

    }
    public class Loan
    {
        public string LoanType { get; set; }
    }
    class CustomerTest
    {
        static void Main(string[] args)
        {
            List<Customer> Clist = new List<Customer>()
            {
                new Customer{ CusId=101,CusName="Sayali",CusAdd="Pune",AccList={new Accounts{Accno=12345,AccType="Saving",
                              LoanList={ new Loan { LoanType="Personal Loan"} } } }
                },
                new Customer{CusId=102,CusName="sneha",CusAdd="Pune",AccList={new Accounts{Accno=54321,AccType="Saving",
                    LoanList={ new Loan { LoanType="Car Loan"} } } }
                }
            };

            foreach (Customer c in Clist)
            {
                Console.WriteLine($"Id: {c.CusId} Name: {c.CusName} Location: {c.CusAdd}");
                foreach (Accounts a in c.AccList)
                {
                    Console.WriteLine($"\n\tAccountno: {a.Accno} \t AccountType: {a.AccType}");
                    foreach (Loan l in a.LoanList)
                    {
                        Console.WriteLine($"\n\t Loan: {l.LoanType}");
                    }
                }
            }
        }
    }
}

