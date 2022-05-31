using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.Tprograms
{
    class Studentt
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public string Course { get; set; }
    }
    class StudTest
    {
        static void Main(string[] args)
        {
            Studentt s1 = new Studentt()
            {
                ID = 10,
                Name = "Sayali",
                Department = "Entc",
                Course = "microprocessor"
            };
            Studentt s2 = new Studentt()
            {
                ID = 20,
                Name = "Swati",
                Department = "Computer",
                Course="java"
                
            };
            Studentt s3 = new Studentt()
            {
                ID = 30,
                Name = "Sneha",
                Department = "Mechanical",
                Course="Mechanics"
                 
            };
            Studentt s4 = new Studentt()
            {
                ID = 40,
                Name = "Sai",
                Department = "Civil",
                Course="Structural Analysis"
                
            };

            Queue<Studentt> queuestudent = new Queue<Studentt>();

            queuestudent.Enqueue(s1);
            queuestudent.Enqueue(s2);
            queuestudent.Enqueue(s3);
            queuestudent.Enqueue(s4);

            foreach (Studentt s in queuestudent)
            {
                Console.WriteLine(s.ID + " - " + s.Name + " - " + s.Department+"-"+s.Course );
                Console.WriteLine("Items left in the Queue = " + queuestudent.Count);
            }

            
            Studentt S1 = queuestudent.Dequeue();
            Console.WriteLine(S1.ID + " - " + S1.Name + " - " + S1.Department + "-" + S1.Course);
            Console.WriteLine("Items left in the Queue = " + queuestudent.Count);

            Studentt S2 = queuestudent.Dequeue();
            Console.WriteLine(S2.ID + " - " + S2.Name + " - " + S2.Department + "-" + S1.Course);
            Console.WriteLine("Items left in the Queue = " + queuestudent.Count);

            if (queuestudent.Contains(s1))
            {
                Console.WriteLine("s1 is in Queue");
            }
            else
            {
                Console.WriteLine("s1 is not in queue");
            }

            
        }
    }

}
    