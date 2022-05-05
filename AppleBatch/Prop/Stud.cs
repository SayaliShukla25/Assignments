using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Prop
{
    class Stud
    {
        int sid;
        string name;
        int percent;
        int passoutyr;
        string email;

        public Stud()
        {

        }
        public Stud(int id, string nm, int p)
        {
            sid = id;
            name = nm;
            percent = p;

        }
        public Stud(int id, string nm, int p, int yr) : this(id, nm, p)
        {
            sid = id;
            name = nm;
            percent = p;
            passoutyr = yr;

        }
        public Stud(int id, string nm, int p, int yr, string em) : this(id, nm, p, yr)

        {

            email = em;
        }

        static void Main(string[] args)
        {
            Stud s1 = new Stud(1, "sayali", 55, 2022, "s@gmai.com");
        }
    








    }
}

