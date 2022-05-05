using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Oops
{
    class Movie
    {

        string moviename;
        string directorname;
        string Producer;
        string actorname;
        int rating;
        string MovieRating;

        public Movie()
        {
            Console.WriteLine("in movie default constructor");
        }
        public void SetMoviename(string name)
        {
            moviename = name;
        }
        public string GetMoviename()
        {
            return moviename;
        }

        public void SetDirectorname(string nm)
        {
            directorname = nm;

        }
        public string GetDirectorname()
        {
            return directorname;
        }

        public void Setproducer(string pr)
        {
            Producer = pr;

        }
        public string Getproducer()
        {
            return Producer;
        }
        public void SetActorname(string ar)
        {
            actorname = ar;

        }
        public string GetActorname()
        {
            return actorname;
        }

        public void SetRating(int rat)
        {
            rating = rat;

        }
        public int GetRating()
        {
            return rating;
        }

        public string Movierating()
        {
            if (rating >= 7)
                return "superhit";
            else if (rating >= 5)
                return "hit";
            else 
                return "flop";
            
        }
    
    

        static void Main(string[] args)
        {
            Movie m1 = new Movie();
            Console.WriteLine("enter movie name,directorname,producername,actor name,rating");
            string name = Console.ReadLine();
            m1.SetMoviename(name);

            string nm = Console.ReadLine();
            m1.SetDirectorname(nm);

            string pr = Console.ReadLine();
            m1.Setproducer(pr);

            string ar = Console.ReadLine();
            m1.SetActorname(ar);

            int rat = Convert.ToInt32(Console.ReadLine());
            m1.SetRating(rat);

            Console.WriteLine(m1.GetMoviename());
            Console.WriteLine(m1.GetDirectorname());
            Console.WriteLine(m1.Getproducer());
            Console.WriteLine(m1.GetRating());
            Console.WriteLine(m1.GetActorname());
            Console.WriteLine(m1.Movierating());






        }
    }
}

