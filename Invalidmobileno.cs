using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.ExepHandling
{
    class test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter mobile number: ");
            long mb = long.Parse(Console.ReadLine());
            int c = 0;
            while (mb > 0)
            {
                c++;
                mb = mb / 10;
            }
            if (c == 10)
                Console.WriteLine("Valid Mobile number");
            else
                throw new InvalidmobilenoException("wrong mobile number");
        }

    }



    class InvalidmobilenoException : ApplicationException
    {
        public InvalidmobilenoException(string S) : base(S)
        {

        }
    }
}

