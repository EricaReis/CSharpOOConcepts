using System;
using System.Globalization ;

namespace TernaryExpression {
    class Program {
        static void Main(string[] args)
        {
            double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double discount = (price < 20.0) ? price * 0.1 : price * 0.05;

            Console.WriteLine(discount);
        }
    }
}
