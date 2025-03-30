using System;
using System.Globalization;

namespace ProductStock {
    class Program {
        static void Main(string[] args)
        {
            Product p = new Product();


            Console.WriteLine("Enter product data: ");
            Console.WriteLine("Name: ");
            p.Name = Console.ReadLine();

            Console.WriteLine("Price: ");
            p.Price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantity: ");
            p.Quantity = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Product info: " + p);

            Console.WriteLine();
            Console.WriteLine("Enter the quantity of products to add: ");
            int qty = int.Parse(Console.ReadLine());

            p.AddProducts(qty);

            Console.WriteLine();
            Console.WriteLine("Updated data: " + p);


            Console.WriteLine("Enter the quantity of products to remove: ");
            qty = int.Parse(Console.ReadLine());
            p.RemoveProducts(qty);
            Console.WriteLine();
            Console.WriteLine("Updated data: " + p);
        }
    }
}