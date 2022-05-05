using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Oops
{
    class Employee1
    {
        int id;
        string name;
        string salary;

        static void Main(string[] args)
        {
            Employee1 e1 = new Employee1();
            e1.id = 25;
            e1.name = "sayali";
            e1.salary = "30000";

            


            Console.WriteLine($"name={e1.name} id={e1.id} salary={e1.salary}");


        }
    }
}
