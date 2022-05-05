using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Oops
{
    class Employee
    {
        int employeeid;
        string employeename;
        int salary;
        public void SetEmployeeid(int id)
        {
            employeeid = id;
        }
        public int GetEmployeeid()
        {
            return employeeid;
        }

        public void SetEmployeename(string name)
        {
            employeename = name;
        }
        public string GetEmployeename()
        {
            return employeename;
        }

        public void SetSalary(int sal)
        {
            salary = sal;
        }

        public int GetSalary()
        {
            return salary;
        }
    
     static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Console.WriteLine("Enter name ,id,salary");

            int id =Convert.ToInt32(Console.ReadLine());
            e1.SetEmployeeid(id);

            string name = Console.ReadLine();
            e1.SetEmployeename(name);

            int salary = Convert.ToInt32(Console.ReadLine());
            e1.SetEmployeeid(salary);

            Console.WriteLine(e1.GetEmployeeid());
            Console.WriteLine(e1.GetEmployeename());
            Console.WriteLine(e1.GetSalary());


        }




    }
}
