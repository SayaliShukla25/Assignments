using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.inherit
{
    class Volum
    {
        double volume(double r)
        {
            double vol = (4 / 3.0) * (22 / 7.0) * r * r * r;
            return vol;
        }
        double volume(double h,double r)
        {
            double vol = (22 / 7.0) * r * r * h;
            return vol;
        }

        double volume(double l, double b,double h)
        {
            double vol = l * b * h;
            return vol;
        }
        static void Main(string[] args)
        {
            Volum v1 = new Volum();
            Console.WriteLine("Sphere Volume=" +v1.volume(8));
            Console.WriteLine("Cylinder Volume=" + v1.volume(7,6.5));
            Console.WriteLine("Coboid Volume=" + v1.volume(2.5,4.2,8));

        }


    }
}
