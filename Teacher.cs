using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.inherit
{
   public class Teacher
    {
        string tname;
        int experience;
        string subjects;

        public Teacher()
        {
            Console.WriteLine("in default constructor");
        }

        public Teacher(string tname, int experience, string subjects)
        {
            this.Tname = tname;
            this.Experience = experience;
            this.Subjects = subjects;
        }
        public string Tname
        {
            get { return tname; }
            set { tname = value; }
        }
        public int Experience
        {
            get { return experience; }
            set { experience = value; }

        }
        public string Subjects
        {
            get { return subjects; }
            set { subjects = value; }
        }


    }
    
}
    
