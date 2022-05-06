using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.inherit
{
    public class PermanentTeacher:Teacher
    {

        int salary;

        public PermanentTeacher() 
        {
            Console.WriteLine("in default of permanent");
        }

       public PermanentTeacher(string tname, int experience, string subject, int Salary):base(tname,experience,subject)
        {
            this.salary = salary;

        }

        public int Salary { get => salary; set => salary = value; }
    }

}