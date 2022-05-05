using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class Count
    {
        static void Main(string[] args)
        {

        
        int num = 1234;
        int count = 0;
         
       
        while(num!=0) {
            num = num/10; 
            count++;
        }

            
            Console.WriteLine(count);
}

   }


    }

