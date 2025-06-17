using System;
using System.Globalization;

namespace CalculateCircleAndSphereData {
    class Program {
        static double Pi = 3.14;

        static void Main(string[] args)
        {

            Console.WriteLine("Enter the radius: ");
            double radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circ = Circumference(radius);
            double volumn = Volumn(radius);

            Console.WriteLine("Circumference: " + circ.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volumn: " + volumn.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Pi value: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

        static double Circumference(double radius)
        {
            return 2.0 * Pi * radius;
        }

        static double Volumn(double r)
        {
            return 4.0 / 3.0 * Pi * r * r * r;
        }
    }
}