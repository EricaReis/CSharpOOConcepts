using System.Globalization;

namespace ProductStock {
    internal class Product {
        public string Name;
        public double Price;
        public int Quantity;

        // Constructor:
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        // Constructor Overload
        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public Product()
        {
        }

        public double TotalValueInStock()
        {
            return Price * Quantity;
        }

        public void AddProducts(int quantity)
        {
            Quantity += quantity;
        }

        public void RemoveProducts(int quantity)
        {
            Quantity -= quantity;
        }

        public override string ToString()
        {
            return Name + ", $" + Price.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + Quantity + " units, Total: $"
                + TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
