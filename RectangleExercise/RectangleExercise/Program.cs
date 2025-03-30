using System;
using System.Globalization;

namespace RectangleExercise {
    class Program {
        static void Main(string[] args)
        {
            Rectangle y;

            y = new Rectangle();

            Console.WriteLine("Enter width and height of rectangle: ");
            y.Width = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.Height = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Area: " + y.Area().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perimeter: " + y.Perimeter().ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal: " + y.Diagonal().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}