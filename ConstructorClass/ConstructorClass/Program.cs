using System;
using System.Globalization;

namespace ProductStock {
    class Program {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter product data: ");
            Console.WriteLine("Name: ");
            string  name = Console.ReadLine();

            Console.WriteLine("Price: ");
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantity: ");
            int quantity = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            // Calling the Constructor
            Product p = new Product(name, price, quantity);

            // Overload
            Product p2 = new Product(name, price);
            Product p3 = new Product();

            // Object syntax
            Product p4 = new Product { Name = "TV", Price = 20, Quantity = 2 };

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