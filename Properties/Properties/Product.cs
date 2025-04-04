using System.Globalization;
using System.Xml.Linq;

namespace ProductStock {
    internal class Product {
        //private variables has this name pattern
        private string _name;
        private double _price;
        private int _quantity;

        public Product() { }

        public Product(string name, double price, int quantity)
        {
            _name = name;
            _price = price;
            _quantity = quantity;
        }

        // Propertie get&set
        public string Name {
            get { return _name; }
            set {
                if (value != null && value.Length > 1)
                {
                    _name = value;
                }
            }
        }

        public double Price
        {
            get { return _price; }  
        }

        public int Quantity
        {
            get { return _quantity; }
        }


        public double TotalValueInStock()
        {
            return _price * _quantity;
        }

        public void AddProducts(int quantity)
        {
            _quantity += quantity;
        }

        public void RemoveProducts(int quantity)
        {
            _quantity -= quantity;
        }

        public override string ToString()
        {
            return _name + ", $" + _price.ToString("F2", CultureInfo.InvariantCulture)
                + ", " + _quantity + " units, Total: $"
                + TotalValueInStock().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
