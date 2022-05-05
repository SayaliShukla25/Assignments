using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch
{
    class Areaofshapes
    {
        static void Main(string[] args)
        {
            int choice, r, l, w, b, h,a;
            double area = 0,rad=0;
            Console.Write("A menu driven program to compute the area of various geometrical shape:\n");
            
           Console.WriteLine("Input 1 for area of circle\n");
            Console.WriteLine("Input 2 for area of rectangle\n");
            Console.WriteLine("Input 3 for area of triangle\n");
            Console.WriteLine("Input 4 for area of square\n");
            Console.WriteLine("Input 5 for perimeter of square\n");
            Console.WriteLine("Input 6 for circumference of circle\n");
            Console.WriteLine("Input your choice : ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Input radius of the circle : ");
                    r = Convert.ToInt32(Console.ReadLine());
                    area = 3.14 * r * r;
                    break;
                case 2:
                    Console.WriteLine("Input length  of the rectangle : ");
                    l = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input  width of the rectangle : ");
                    w = Convert.ToInt32(Console.ReadLine());
                    area = l * w;
                    break;
                case 3:
                    Console.WriteLine("Input the base of the triangle :");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Input the hight of the triangle :");
                    h = Convert.ToInt32(Console.ReadLine());
                    area = .5 * b * h;
                    break;
                case 4:
                    Console.WriteLine("Enter the side of the square :");
                    a = Convert.ToInt32(Console.ReadLine());
                     area = a * a;
                    break;

                case 5:
                    Console.WriteLine("Enter the side of the square :");
                    a = Convert.ToInt32(Console.ReadLine());
                    double perimeter = 4 * a;
                    break;
               case 6:
                    Console.WriteLine("Enter radius of circle :");
                    a = Convert.ToInt32(Console.ReadLine());
                   double ci = 2 * 3.14 * rad;
                    break;

            }
            Console.Write("The area is : {0}\n", area);
        }
    }
}
    

