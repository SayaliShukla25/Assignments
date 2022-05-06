using System;
using System.Collections;
using System.Text;

namespace AccessModifier.Tprograms
{
    class EEmp : IComparable
    {
        private int id;
        private string name;
        private int salary;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Salary { get => salary; set => salary = value; }
        
        public int CompareTo(object obj)
        {
            EEmp e2 = (EEmp)obj;

            if(this.Salary> e2.Salary)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
          
          
    }
    public class test
    {
        static void Main(string[] args)
        {
            EEmp e1 = new EEmp { Id = 20, Name = "sayali", Salary = 30000 };
            EEmp e2= new EEmp { Id = 20, Name = "swati", Salary = 25000 };
            int result=e1.CompareTo(e2);
            if(result==1)
            {
                Console.WriteLine("sayali has more salary than swati");
            }
            else
            {

                Console.WriteLine("swati has more salary than sayali");
            }
        }


        }
    }

