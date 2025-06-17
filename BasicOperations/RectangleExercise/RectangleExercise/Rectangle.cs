using System;

namespace RectangleExercise {
    internal class Rectangle {
        public double Width;
        public double Height;

        public double Area()
        {
            double p = Width * Height;

            return p;
        }

        public double Perimeter()
        {
            double p = 2 * (Width + Height);

            return p;
        }

        public double Diagonal()
        {
            double p = Math.Sqrt(Math.Pow(Width, 2) + Math.Pow(Height, 2));

            return p;
        }
    }
}
