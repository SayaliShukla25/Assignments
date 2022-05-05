using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class SwitchSimpleCal
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            string op;
            float answer;

            Console.Write(" enter  first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter the second integer: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write(" enter operator(+, -, /, *): ");
            op = Console.ReadLine();

            switch (op)
            {

                case "-":
                    answer = num1 - num2;
                    break;

                case "+":
                    answer = num1 + num2;
                    break;

                case "/":
                    answer = num1 / num2;
                    break;

                case "*":
                    answer = num1 * num2;
                    break;

                default:
                    answer = 0;
                    break;
            }
            Console.WriteLine(num1.ToString() + " " + op + " " + num2.ToString() + " = " + answer.ToString ());
            Console.ReadLine();

        }

    }
}
    

