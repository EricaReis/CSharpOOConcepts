using System;
using System.Globalization;

namespace ProductStock {
    class Program {
        static void Main(string[] args)
        {
            Product p = new Product("TV", 500.0, 10);


            p.Name = "T";


            Console.WriteLine("Updated data: " + p.Name);
            Console.WriteLine("Updated data: " + p.Price);
        }
    }
}