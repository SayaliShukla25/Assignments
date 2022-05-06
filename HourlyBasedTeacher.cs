using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.inherit
{
    class HourlyBasedTeacher:Teacher
    {
        int hrs, rate;
        public HourlyBasedTeacher()
        {
            Console.WriteLine("in hourly default ");
        }

        public HourlyBasedTeacher(int hrs, int rate)
        {
            this.Hrs = hrs;
            this.Rate = rate;
        }

        public int Hrs { get => hrs; set => hrs = value; }
        public int Rate { get => rate; set => rate = value; }
    }
    class Tech
    {
        static void Main(string[] args)
        {
            Teacher t1 = new Teacher();
            t1.Tname = "Deepa";
            t1.Experience = 15;
            t1.Subjects = "c#";

            PermanentTeacher p1 = new PermanentTeacher();
            p1.Tname = "Pooja";
            p1.Experience = 20;
            p1.Subjects = "python";
            p1.Salary = 50000;

            HourlyBasedTeacher h1 = new HourlyBasedTeacher();
            h1.Tname = "Mansi";
            h1.Experience = 10;
            h1.Subjects = "java";
            h1.Hrs = 35;
            h1.Rate = 20000;

            Console.WriteLine(t1.Tname);
            Console.WriteLine(t1.Experience);
            Console.WriteLine(t1.Subjects);

            Console.WriteLine(p1.Tname);
            Console.WriteLine(p1.Experience);
            Console.WriteLine(p1.Subjects);
            Console.WriteLine(p1.Salary);

            Console.WriteLine(h1.Tname);
            Console.WriteLine(h1.Experience);
            Console.WriteLine(h1.Subjects);
            Console.WriteLine(h1.Hrs);
            Console.WriteLine(h1.Rate);

        }







        }

    }
