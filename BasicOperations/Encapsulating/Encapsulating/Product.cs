using System.Globalization;

namespace ProductStock {
    internal class Product {
        //private variables has this name pattern
        private string _name;
        private double _price;
        private int _quantity;

        public Product() { }

        public Product(string name, double price, int quantity  )
        {
            _name = name;
            _price = price;
            _quantity = quantity;
        }

        // Access product name by Get & Set
        public string GetName() { return _name; }   

        // Validate before edit product name
        public void SetName( string name ) {
            if (name != null && name.Length > 1)
            {
                _name = name;
            }
        }

        public int GetQuantity() { return _quantity; }

        public double GetPrice() { return _price; }


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
