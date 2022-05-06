using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace AccessModifier.Tprograms
{
    class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Fees { get; set; }

    }

    class Coursetest
    {
        static void Main(string[] args)
        {
            List<Course> coursenew = new List<Course>()
            {
                new Course { Id = 100, Name = "Csharp", Fees =50000 },
                new Course { Id = 101, Name = "Java", Fees = 60000 },
                new Course { Id = 203, Name = "Full Stack", Fees = 80000 },
                new Course { Id = 103, Name = "C++", Fees = 55000 },
                new Course { Id = 504, Name = "Java", Fees = 40000 },
                new Course { Id = 105, Name = "Angular", Fees = 80000 },
            };
            // display all courses id in decending order
            var result1 = from d in coursenew
                          orderby d.Id descending
                          select d;
            foreach (Course d in result1)
            {
                Console.WriteLine($"{d.Id}\t{d.Name}\t{d.Fees}");
            }

            Console.WriteLine("*************************************");

            // display course whose fees is less than 80000

            var result2 = from d in coursenew
                          where d.Fees < 80000
                          select d;
            foreach (Course d in result2)
            {
                Console.WriteLine($"{d.Id}\t{d.Name}\t{d.Fees}");
            }
            Console.WriteLine("**************************************");

            //display course with name and fees less than 70000
            var result3 = from d in coursenew
                          orderby d.Name.Contains("Angular") && d.Fees <70000
                          select d;
            foreach (Course d in result3)
            {
                Console.WriteLine($"{d.Id}\t{d.Name}\t{d.Fees}");
            }
            Console.WriteLine("**************************************");

            //display the courses  in ascending order by course id
            var result4 = from d in coursenew
                          orderby d.Id
                          select d;
            foreach (Course d in result4)
            {
                Console.WriteLine($"{d.Id}\t{d.Name}\t{d.Fees}");
            }
            Console.WriteLine("**************************************");
            // display course whose fees is greater than 55000

            var result5 = from d in coursenew
                          where d.Fees>55000
                          select d;
            foreach (Course d in result5)
            {
                Console.WriteLine($"{d.Id}\t{d.Name}\t{d.Fees}");
            }
        }
    }
}
