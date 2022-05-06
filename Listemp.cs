using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.Tprograms
{
    class Listemp
    {
        private int id;
        private string name;
        private int salary;

        public Listemp(int id, string name, int salary)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Salary { get => salary; set => salary = value; }

        public override string ToString()
        {
            return $"emp name={Name},emp Id={Id},emp salary={Salary}";

        }
    }
    class Test12
    {
        static void Main(string[] args)
        {
            List<Listemp> e = new List<Listemp>()
            {
                new Listemp(100, "sayali", 30000),
                new Listemp(101, "Riya", 40000),
                new Listemp(103, "Neha", 20000),

            };

            foreach (Listemp a in e)
            {
                Console.WriteLine(a);
            }
        }
    }
}
