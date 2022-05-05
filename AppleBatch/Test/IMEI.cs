﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Test
{
    class IMEI
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Is Valid IMEI " + IsValidIMEI("256533912774354"));
            Console.Read();
        }

        static bool IsValidIMEI(string imei)
        {
            int[] n = new int[imei.Length];
            for (int i = 0; i < imei.Length; i++)
            {
                n[i] = int.Parse(imei[i].ToString());
            }

            for (int i = 0; i < imei.Length - 1; i++)
            {
                if (i % 2 == 1)
                {
                    n[i] = n[i] * 2;
                }
            }

            for (int i = 0; i < imei.Length - 1; i++)
            {
                if (i % 2 == 1)
                {
                    if (n[i].ToString().Length > 1)
                        n[i] = int.Parse(n[i].ToString()[0].ToString()) + int.Parse(n[i].ToString()[1].ToString());
                }
            }

            int total = 0;
            for (int i = 0; i < imei.Length - 1; i++)
            {
                total += n[i];
            }

            int mod = total % 10;

            if (mod > 0)
            {
                mod = 10 - mod;
            }

            return (n[imei.Length - 1] == mod);
        }

    }
}




