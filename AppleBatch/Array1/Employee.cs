using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Array1
{
    class Employee
    {
        string department,id,salary;
        static void Main(string[] args)
        {

        
       
        Employee sheeran = new Employee();
       
          sheeran .department = "Development";
          Console.WriteLine("Sheeran: " + sheeran.department);

            sheeran.id = "1234";
            Console.WriteLine("Sheeran: " + sheeran.id);

            sheeran.salary = "25000";
            Console.WriteLine("Sheeran: " + sheeran.salary);

         
      Console.ReadLine();
    }
}
}       

        
       