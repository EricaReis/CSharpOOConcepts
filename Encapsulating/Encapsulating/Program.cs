using System;
using System.Globalization;

namespace ProductStock {
    class Program {
        static void Main(string[] args)
        {
            Product p = new Product("TV", 500.0, 10);

 
            p.SetName("TV 4k");


            Console.WriteLine("Updated data: " + p);
            Console.WriteLine("Updated data: " + p.GetPrice());
        }
    }
}