using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Oops
{
    class Country
    {
        string countryname;
        int states;
        int nooflanguages;
        string capital;

        public string Countryname
        {
            get { return countryname; }
            set { countryname = value; }
        }
        public int States
        {
            get { return states; }
            set { states = value ; }

        }
        public string Capital
        {
            get { return capital; }
            set { capital = value; }

        }
        public int Nooflanguages
        {
            get { return nooflanguages; }
            set { nooflanguages = value; }

        }

        static void Main(string[] args)
        {
            Country c = new Country();
            c.Countryname = "India";
            c.States = 28;
            c.Capital = "Delhi";
            c.Nooflanguages = 6;
            
            Console.WriteLine(c.Countryname);
            Console.WriteLine(c.States);
            Console.WriteLine(c.Capital);
            Console.WriteLine(c.Nooflanguages);

        }
        


    }
}
