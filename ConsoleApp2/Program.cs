using ConsoleApp2;
using ConsoleApp2.Classes;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            admin kullanici1 = new admin();
            customer kullanici2 = new customer();


            kullanici1.Name = "Ahmet ";
            kullanici2.Name = "Mehmet ";


            Console.Write(kullanici1.Name);
            kullanici1.add();


            Console.Write(kullanici2.Name);
            kullanici2.buy();

        }
    }
}