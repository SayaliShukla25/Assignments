using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Oops
{
    class Student1
    {
        int id;
        string name;
        string hobbies;

        static void Main(string[] args)
        {
            Student1 s1 = new Student1();
            s1.id = 25;
            s1.name = "sayali";
            s1.hobbies = "travelling";

            Student1 s2= new Student1();
            s2.id = 45;
            s2.name = "sayali";
            s2.hobbies = "reading books";


            Console.WriteLine($"name={s1.name} id={s1.id} /nhobbies={s1.hobbies}");

        }
    }
}


    

