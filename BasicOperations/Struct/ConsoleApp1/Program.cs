using System;

namespace Struct {
    internal class Program {
        static void Main(string[] args) {

            Point p;
            p.x = 10;
            p.y = 20;

            p = new Point();        

            Console.WriteLine(p);
        }
    }
}