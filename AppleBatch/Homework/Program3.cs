using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class Program3
    {
        static void Main(string[] args)
        {

        
        Console.Write("Enter a number : ");
        int number = Convert.ToInt32(Console.ReadLine());
        if (CheckAutomorphicNumber (number))
        {
         Console.WriteLine("Automorphic Number");
        }
        else
        {
         Console.WriteLine("Not Automorphic Number");
        }
Console.ReadLine();
    }
    public static bool CheckAutomorphicNumber(int no)
{
    int square = no * no;
    while (no > 0)
    {
        if (no % 10 != square % 10)
        {
            return false;
        }
        no = no / 10;
        square = square / 10;
    }
    return true;
}
}
    }

