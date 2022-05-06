using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AccessModifier.Tprograms
{
    class Empnew
    {
       public int Id { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public double Salary { get; set; }
        public string Dept { get; set; }


    }

    class Emptest
    {
        static void Main(string[] args)
        {

            List<Empnew> empp = new List<Empnew>()
            {
                    new Empnew{Name="Sayali",Id=40,City="Pune",Salary=32000,Dept="IT"},
                    new Empnew{Name="Shehal",Id=40,City="solapur",Salary=38000,Dept="electronics"},
                    new Empnew{Name="Kiran",Id=40,City="delhi",Salary=49000,Dept="mech"},
                    new Empnew{Name="Ankita",Id=40,City="Pune",Salary=48000,Dept="IT"},
            };
            
            var result2 = from a in empp
                          where a.Salary > 45000
                          select a;
            foreach (Empnew a in result2)
            {
                Console.WriteLine($"{a.Name}{a.Id}{a.City}{a.Salary}{a.Dept}");
            }
            
            Console.WriteLine("*****************************");
            
            var result3 = from a in empp
                          orderby a.Name
                          select a;
            foreach(Empnew a in result3)
            {
                Console.WriteLine($"{a.Name}{a.Id}{a.City}{a.Salary}{a.Dept}");
            }
            
            Console.WriteLine("*****************************");
            
            var result4 = from a in empp
                          orderby a.City.Contains("Pune")
                          select a;
            foreach (Empnew a in result4)
            {
                Console.WriteLine($"{a.Name}{a.Id}{a.City}{a.Salary}{a.Dept}");
            }
            Console.WriteLine("*****************************");
            
            var result5 = from a in empp
                          orderby a.Salary descending
                          select a;
            foreach (Empnew a in result5)
            {
                Console.WriteLine($"{a.Name}{a.Id}{a.City}{a.Salary}{a.Dept}");
            }
            
            Console.WriteLine("*****************************");
            
            var result6 = from a in empp
                          orderby a.Name.StartsWith('A')||a.Name.StartsWith('K')
                          select a;
            foreach (Empnew a in result6)
            {
                Console.WriteLine($"{a.Name}{a.Id}{a.City}{a.Salary}{a.Dept}");
            }
            Console.WriteLine("*****************************");
            var result7 = from a in empp
                          orderby a.City.Contains("Pune") && a.Salary<35000
                          select a;
            foreach (Empnew a in result6)
            {
                Console.WriteLine($"{a.Name}{a.Id}{a.City}{a.Salary}{a.Dept}");
            }












        }
    }
}
