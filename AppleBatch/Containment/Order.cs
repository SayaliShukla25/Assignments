using System;
using System.Collections.Generic;
using System.Text;

namespace AppleBatch.Containment
{
    class Order
    {
        int orderid;
        int orderdate;
        Customer c=new Customer();
        Item item=new Item();
        public Order()
        {

        }

        public Order(int orderid, int orderdate, Customer c, Item item)
        {
            this.Orderid = orderid;
            this.Orderdate = orderdate;
            this.C = c;
            this.Item = item;
        }

        public int Orderid { get => orderid; set => orderid = value; }
        public int Orderdate { get => orderdate; set => orderdate = value; }
        public Customer C { get => c; set => c = value; }
        public Item Item { get => item; set => item = value; }
    }
    class Customer
    {
        string cusname;
        int phoneno;
        Address addr=new Address();
        public Customer()
        {

        }
            
        public Customer(string cusname, int phoneno, Address addr)
        {
            this.Cusname = cusname;
            this.Phoneno = phoneno;
            this.Addr = addr;
        }

        public string Cusname { get => cusname; set => cusname = value; }
        public int Phoneno { get => phoneno; set => phoneno = value; }
        public Address Addr { get => addr; set => addr = value; }
    }

    class Address
    {
        string countryname;
        string city;
        string street;
        public Address()
        {

        }

        public Address(string countryname, string city, string street)
        {
            this.Countryname = countryname;
            this.City = city;
            this.Street = street;
        }

        public string Countryname { get => countryname; set => countryname = value; }
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
    }
    class Item
    {
        string itemname;
        int quantity;
        int price;

        public Item()
        {

        }

        public Item(string itemname, int quantity, int price)
        {
            this.itemname = itemname;
            this.quantity = quantity;
            this.price = price;
        }

        public string Itemname { get => itemname; set => itemname = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int Price { get => price; set => price = value; }
    }
    class Ordertest
    { 
    static void Main(string[] args)
    {

            Order o1= new Order();
            o1.Orderid = 125;
            o1.Orderdate =7042022;
            o1.C.Cusname = "Sayali";
            o1.C.Phoneno = 914588564;
            
            o1.C.Addr.Countryname = "india";
            o1.C.Addr.City = "Pune";
            o1.C.Addr.Street = "Sinhagad Road";

            o1.Item.Itemname = "books";
            o1.Item.Price = 400;
            o1.Item.Quantity = 2;


            Console.WriteLine(o1.Orderid);
            Console.WriteLine(o1.Orderdate);
            Console.WriteLine(o1.C.Cusname);
            Console.WriteLine(o1.C.Phoneno);
            Console.WriteLine(o1.C.Addr.Countryname);
            Console.WriteLine(o1.C.Addr.City);
            Console.WriteLine(o1.C.Addr.Street);
            Console.WriteLine(o1.Item.Itemname);
            Console.WriteLine(o1.Item.Price);
            Console.WriteLine(o1.Item.Quantity);



        }
    }
}

    


    

