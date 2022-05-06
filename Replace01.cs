using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.NewPrograms
{
    class Replace01
    {
        static int reverseTheNumber(int temp)
        {
            int ans = 0;
            while (temp > 0)
            {
                int rem = temp % 10;
                ans = ans * 10 + rem;
                temp = temp / 10;
            }
            return ans;
        }

        static int convert0To1(int num)
        {
            
                 if (num == 0)
                 return 1;

            else
            {
                int temp = 0;

                while (num > 0)
                {
                    int digit = num % 10;
                   
                    if (digit == 0)
                        digit = 1;

                    temp = temp * 10 + digit;
                    num = num / 10;
                }

                
                return reverseTheNumber(temp);
            }
        }
           public static void Main(string[] args)
        {
            int num = 8090650;
            Console.Write(convert0To1(num));

        }
    }
}

