using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Containment
{
    class Flat
    {
        int flatno;
        string buildingname;
        Member memberobj = new Member();

        public Flat()
        {

        }

        public Flat(int flatno, string buildingname, Member memberobj)
        {
            this.Flatno = flatno;
            this.Buildingname = buildingname;
            this.Memberobj = memberobj;
        }

        public int Flatno { get => flatno; set => flatno = value; }
        public string Buildingname { get => buildingname; set => buildingname = value; }
        public Member Memberobj { get => memberobj; set => memberobj = value; }
    }
    class Member
    {
        string membername;
        string gender;
        int age;
        string profession;
        public Member()

        {

        }


        public Member(string membername, string gender, int age, string profession)
        {
            this.Membername = membername;
            this.Gender = gender;
            this.Age = age;
            this.Profession = profession;
        }

        public string Membername { get => membername; set => membername = value; }
        public string Gender { get => gender; set => gender = value; }
        public int Age { get => age; set => age = value; }
        public string Profession { get => profession; set => profession = value; }
    }
    class Ftest
    {



        static void Main(string[] args)
        {
            Flat f1 = new Flat();
            f1.Flatno = 1006;
            f1.Buildingname = "RAJYOG";
            f1.Memberobj.Membername = "SAYALI";
            f1.Memberobj.Gender = "female";
            f1.Memberobj.Age = 26;
            f1.Memberobj.Profession = "engineer";

            Console.WriteLine(f1.Flatno);
            Console.WriteLine(f1.Buildingname);
            Console.WriteLine(f1.Memberobj.Membername);
            Console.WriteLine(f1.Memberobj.Gender);
            Console.WriteLine(f1.Memberobj.Age);
            Console.WriteLine(f1.Memberobj.Profession);



        }

    }
}
    




    

