using System;
using System.Collections.Generic;
using System.Text;

namespace AccessModifier.inherit
{
    class Pen
    {
        int caplength;
        string brand;
        public Refill r = new Refill();

        public Pen()
        {
            Console.WriteLine(" in pen default constructor");
        }

        public Pen(int capLength, string brand, Refill refill)
        {
            this.caplength = capLength;
            this.brand = brand;
            this.r = r;
        }

        public void SetCapLength(int caplength)
        {
            this.caplength = caplength;
        }
        public int GetCapLength()
        {
            return caplength;
        }

        public void SetBrand(string brand)
        {
            this.brand = brand;
        }
        public string GetBrand()
        {
            return brand;
        }

        public void SetR(Refill r)
        {
            this.r = r;
        }

        public Refill GetR()
        {
            return this.r;
        }

    }

    class Refill
    {
        string color;
        int length;
        public Nib n = new Nib();

        public Refill()
        {

        }

        public Refill(string Color, int length, Nib n)
        {
            this.color = color;
            this.length = length;
            this.n = n;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }
        public string GetColor()
        {
            return color;
        }

        public void SetLength(int l)
        {
            length = l;
        }
        public int GetLength()
        {
            return length;
        }

        public void SetN(Nib n)
        {
            this.n = n;
        }

        public Nib GetN()
        {
            return this.n;
        }
    }
    class Nib
    {
        String materialtype;
        int width;
        public Nib()
        {

        }

        public Nib(string materialtype, int width)
        {
            this.materialtype = materialtype;
            this.width = width;
        }
        public void SetMaterialtype(string materialtype)
        {
            this.materialtype = materialtype;
        }
        public void SetWidth(int width)
        {
            this.width = width;
        }
        public string GetMaterialtype()
        {
            return this.materialtype;
        }
        public int GetWidth()
        {
            return this.width;
        }

    }
    class Pentest
    {
        static void Main(string[] args)
        {
            Pen p1 = new Pen();
            p1.SetCapLength(12);
            p1.SetBrand("trimax");
            p1.r.SetColor("blue");
            p1.r.SetLength(11);
            p1.r.n.SetMaterialtype("Hard");
            p1.r.n.SetWidth(4);

            Console.WriteLine(p1.GetCapLength());
            Console.WriteLine(p1.GetBrand());
            Console.WriteLine(p1.r.GetColor());
            Console.WriteLine(p1.r.GetLength());
            Console.WriteLine(p1.r.n.GetMaterialtype());
            Console.WriteLine(p1.r.n.GetWidth());

        }


    }
}


