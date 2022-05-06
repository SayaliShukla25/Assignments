using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.Stringtest
{
    class Student
    {
        public Student(string nm, int per)
        {
          string  name = nm;
           int p = per;
            Console.WriteLine(name + "" + p);
        }
      
            static void Main(string[] args)
            {
                Student[] sarr = new Student[5];
                for (int i = 0; i < sarr.Length; i++)
                {
                    Console.WriteLine("enter name,percent");
                    string nm = Console.ReadLine();
                    int per = int.Parse(Console.ReadLine());
                    sarr[i] = new Student(nm, per);
                }
            }
        }
    }

