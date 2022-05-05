using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Oops
{
    class CricketPlayer
    {
        string playername;
        int wickets;
        int runs;
        int age;
        static string countryname;

        public void accept()
        {
            Console.WriteLine("enter name,no. of wickets,runs,age");
            playername = Console.ReadLine();
            wickets = Convert.ToInt32(Console.ReadLine());
            runs = Convert.ToInt32(Console.ReadLine());
            age = Convert.ToInt32(Console.ReadLine());


        }
        public void display()
        {
            Console.WriteLine($"Player name:{playername}");
            Console.WriteLine($"Player wickets taken:{wickets}");
            Console.WriteLine($"Player runs:{runs}");
            Console.WriteLine($"Player age:{age}");

        }
        static void Main(string[] args)
        {
            CricketPlayer c1 = new CricketPlayer();
            c1.accept();
            c1.display();

            CricketPlayer c2 = new CricketPlayer();
            c2.accept();
            c2.display();


        }
    }
}

