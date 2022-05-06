using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.inherit
{
    class Person
    {
        int id;
        string name;
        Vehicle var = new Vehicle();

        public Person()
        {
            Console.WriteLine("in person default constructor");
        }
        public Person(int id, string name, Vehicle var)
        {
            this.Id = id;
            this.Name = name;
            this.V = var;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public Vehicle V { get => var; set => var = value; }
    }
    class Vehicle
    {
        int vid;
        string vname;

        public Vehicle()
        {
            Console.WriteLine("In vehicle default constructor");
        }

        public Vehicle(int vid, string vname)
        {
            this.Vid = vid;
            this.Vname = vname;
        }

        public int Vid { get => vid; set => vid = value; }
        public string Vname { get => vname; set => vname = value; }
    }

    class Persontest
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();

            p1.Id = 564;
            p1.Name = "Sayali";
            p1.V.Vid = 7885;
            p1.V.Vname = "Scooty";

            Person p2 = new Person();

            p2.Id = 600;
            p2.Name = "Pooja";
            p2.V.Vid = 2599;
            p2.V.Vname = "car";

            Console.WriteLine(p1.Id);
            Console.WriteLine(p1.Name);
            Console.WriteLine(p1.V.Vid);
            Console.WriteLine(p1.V.Vname);

            Console.WriteLine(p2.Id);
            Console.WriteLine(p2.Name);
            Console.WriteLine(p2.V.Vid);
            Console.WriteLine(p2.V.Vname);

        }
    }
}


        
    

