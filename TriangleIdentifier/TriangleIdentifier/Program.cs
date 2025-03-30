using System;
using System.Globalization;

namespace TriangleIdentifier {
    class Program {
        static void Main(string[] args)
        {
            Triangle x, y;

            x = new Triangle();
            y = new Triangle();

            Console.WriteLine("Enter the X triangle's measurements:");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter the Y triangle's measurements:");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = x.Area();

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = x.Area();

            Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Bigger area: X");
            } else
            {
                Console.WriteLine("Bigger area: Y");
            }
        }
    }
}