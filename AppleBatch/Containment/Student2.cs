using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Containment
{
    class Student2
    {
        int studid;
        string name;
        int percent;
        Batch batch1 = new Batch();
        Address1 addr = new Address1();

        public Student2()
        {

        }


        public Student2(int studid, string name, int percent, Batch batch1, Address1 addr)
        {
            this.Studid = studid;
            this.Name = name;
            this.Percent = percent;
            this.Batch1 = batch1;
            this.Addr = addr;
        }

        public int Studid { get => studid; set => studid = value; }
        public string Name { get => name; set => name = value; }
        public int Percent { get => percent; set => percent = value; }
        public Batch Batch1 { get => batch1; set => batch1 = value; }
        public Address1 Addr { get => addr; set => addr = value; }


    }
    class Batch
    {
        string batchname;
        string subjects;
        public Batch()
        {

        }

        public Batch(string batchname, string subjects)
        {
            this.Batchname = batchname;
            this.Subjects = subjects;
        }

        public string Batchname { get => batchname; set => batchname = value; }
        public string Subjects { get => subjects; set => subjects = value; }
    }
    class Address1
    {
        string street;
        string city;

        public Address1()
        {

        }
        public Address1(string street, string city)
        {
            this.Street = street;
            this.City = city;
        }

        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }


        static void Main(string[] args)
        {
            Student2 s2 = new Student2();
            s2.Studid = 125;
            s2.Name = "Sayali";
            s2.Percent = 80;
            s2.Batch1.Batchname = "apple";
            s2.Batch1.Subjects = "C#";

            s2.Addr.Street = "MG ROAD";
            s2.Addr.City = "PUNE";
        }
    }
}
    



