using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.ExepHandling
{
    class Userdefined
    {
       
      static void Main(string[] args)
        {
            Fitness f = new Fitness();
            try
            {
                f.showResult();
            }
            catch (FitnessTestFailedException e)
            {
                Console.WriteLine("User defined exception: {0}", e.Message);
            }
            Console.ReadKey();
        }
    }
}

public class FitnessTestFailedException : Exception
{
    public FitnessTestFailedException(string m) : base(m)
    {
    }
}

public class Fitness
{
    int points = 0;

    public void showResult()
    {

        if (points < 100)
        {
            throw (new FitnessTestFailedException("Player failed the fitness test"));
        }
        else
        {
            Console.WriteLine("Player passed the fitness test!");
        }
    }
}
    

