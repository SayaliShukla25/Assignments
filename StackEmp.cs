using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.Tprograms
{
    class StackEmp
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }

    }
    public class ProgramT
    {
        static void Main(string[] args)
        {

            StackEmp emp1 = new StackEmp()
            {
                ID = 101,
                Name = "Sayali",
                Salary = 20000
            };
            StackEmp emp2 = new StackEmp()

            {
                ID = 102,
                Name = "Priya",
                Salary = 30000
            };
            StackEmp emp3 = new StackEmp()
            {
                ID = 103,
                Name = "Pradnya",
                Salary = 40000
            };
            StackEmp emp4 = new StackEmp()
            {
                ID = 104,
                Name = "Sheetal",
                Salary = 40000
            };
            StackEmp emp5 = new StackEmp()
            {
                ID = 105,
                Name = "Shruti",
                Salary = 50000
            };
            Stack<StackEmp> stackEmployee = new Stack<StackEmp>();
            stackEmployee.Push(emp1);
            stackEmployee.Push(emp2);
            stackEmployee.Push(emp3);
            stackEmployee.Push(emp4);
            stackEmployee.Push(emp5);

            foreach (StackEmp emp in stackEmployee)
            {
                Console.WriteLine(emp.ID + " - " + emp.Name + " -  " + emp.Salary);



            }
           StackEmp  e1 = stackEmployee.Pop();
            Console.WriteLine(e1.ID + " - " + e1.Name + " - " + e1.Salary);
            Console.WriteLine("Items left in the Stack = " + stackEmployee.Count);

          
        }
    }
}
