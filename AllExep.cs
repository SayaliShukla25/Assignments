using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.ExepHandling
{
    class AllExep
    {
        static void Main(string[] args)
        {
            try
            {
                int num = int.Parse(Console.ReadLine());

                int result = 100 / num;

                Console.WriteLine("100 / {0} = {1}", num, result);
            }
            catch (DivideByZeroException e)
            {
                Console.Write("Cannot divide by zero");
            }
            catch (InvalidOperationException e)
            {
                Console.Write("Invalid operation");
            }
            catch (FormatException e)
            {
                Console.Write("Not a valid format");
            }
            catch (Exception e)
            {
                Console.Write("Error occurred");
            }
        }

    }
}

