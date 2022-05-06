using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.Tprograms
{
    public class Empp
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
    public class Dept
    {
        public string DeptName { get; set; }


        public List<Empp> Empps = new List<Empp>();
    }

    class Testemp
    {
        static void Main(string[] args)
        {
            List<Dept> depts = new List<Dept>()
            {
                new Dept{DeptName="IT",Empps={
                    new Empp{Name="Sayali",Id=40},
                    new Empp{Name="Snehal",Id=41},
                    new Empp{Name="Swati",Id=42}
                    }

                },
                new Dept{DeptName="Electronics",Empps={
                    new Empp{Name="Sneha",Id=50},
                    new Empp{Name="Ria",Id=51},
                    new Empp{Name="sai",Id=52}
                    }
                },
            };

            foreach (Dept d in depts)
            {
                Console.WriteLine(d.DeptName);
                foreach(Empp e in d.Empps)

                {
                    Console.WriteLine($"\t{e.Name}{e.Id}");
                }
            }

        }
    }


}
