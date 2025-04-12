using System.Globalization;
using System.Xml.Linq;

namespace ProductStock {
    internal class Product {
        // Auto Properties
        public string _name;
        public double Price { get; private set; }
        public int Quantity { get; private set; }

        

        public Product() { }

        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        // Propertie get&set
        public string Name
        {
            get { return _name; }
            set
            {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }
    }
}
