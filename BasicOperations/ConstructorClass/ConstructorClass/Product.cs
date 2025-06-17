using System.Globalization;

namespace ProductStock {
    internal class Product {
        public string Name;
        public double Price;
        public int Quantity;

      
        // Constructor overload
        public Product(string name, double price): this()
        {
            Name = name;
            Price = price;
        }

        // Constructor:
        public Product (string name, double price, int quantity) : this(name, price)
        {
            Quantity = quantity;
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
