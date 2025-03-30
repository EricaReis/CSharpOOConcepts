using System;

namespace TriangleIdentifier {
    internal class Triangle {
        public double A;
        public double B;
        public double C;

        //Method:
        public double Area() {
            double p = (A + B + C) / 2;
            double squareRoot = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return squareRoot;
        } 
    }
}
