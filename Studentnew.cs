using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AccessModifier.Tprograms
{
    class Studentnew
    {
        public int Rollno { get; set; }
        public string Name { get; set; }
        public float Percentage  { get; set; }
        public string Branch { get; set; }
        

    }
    class Studtest
    {
        static void Main(string[] args)
        {
            List<Studentnew> stud = new List<Studentnew>()
            {
                    new Studentnew{Rollno=10,Name="Sayali",Percentage=80,Branch="Electronics"},
                    new Studentnew{Rollno=11,Name="Snehal",Percentage=82,Branch="IT"},
                    new Studentnew{Rollno=45,Name="kalyani",Percentage=62,Branch="IT"},
                    new Studentnew{Rollno=32,Name="chitra",Percentage=85,Branch="Computer"},
                    new Studentnew{Rollno=55,Name="Mahi",Percentage=92,Branch="Electronics"},
                    new Studentnew{Rollno=10,Name="Riya",Percentage=82,Branch="Electronics"},
            };
            
            var result1 = from s in stud
                          where s.Percentage > 84
                          select s;
            foreach (Studentnew s in result1)
            {
                Console.WriteLine($"{s.Rollno}\t{s.Name}\t{s.Percentage}\t{s.Branch}");
            }
            Console.WriteLine("*********************************************************");
            var result2 = from s  in stud
                          orderby s.Percentage descending
                          select s;
            foreach (Studentnew s in result2)
            {
                Console.WriteLine($"{s.Rollno}\t{s.Name}\t{s.Percentage}\t{s.Branch}");
            }
            Console.WriteLine("*********************************************************");

            var result3 = from s in stud
                          orderby s.Branch.Contains("IT")
                          select s;
            foreach (Studentnew s in result3)
            {
                Console.WriteLine($"{s.Rollno}\t{s.Name}\t{s.Percentage}\t{s.Branch}");
            }
            Console.WriteLine("*********************************************************");

            var result4 = from s in stud
                          orderby s.Branch.Contains("Electronics") && s.Percentage > 80
                          select s;
            foreach (Studentnew s in result4)
            {
                Console.WriteLine($"{s.Rollno}\t{s.Name}\t{s.Percentage}\t{s.Branch}");
            }
            Console.WriteLine("*********************************************************");

            var result5 = from s in stud
                          orderby s.Name
                          select s;
            foreach (Studentnew s in result5)
            {
                Console.WriteLine($"{s.Rollno}\t{s.Name}\t{s.Percentage}\t{s.Branch}");
            }
            Console.WriteLine("*********************************************************");


        }
    }
}
