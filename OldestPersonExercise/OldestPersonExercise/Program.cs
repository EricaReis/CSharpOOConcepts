using System;
using OldestPersonExercise;

namespace OldestPersonIdentifier {
    class Program {
        static void Main(string[] args)
        {
            Person x, y;

            x = new Person();
            y = new Person();

            Console.WriteLine("Type the X person name:");
            x.Name = Console.ReadLine();
            Console.WriteLine("Type the X person age:");
            x.Age = int.Parse(Console.ReadLine());

            Console.WriteLine("Type the Y person name:");
            y.Name = Console.ReadLine();
            Console.WriteLine("Type the Y person age:");
            y.Age = int.Parse(Console.ReadLine());


            if (x.Age > y.Age)
            {
                Console.WriteLine("Oldest person: X: " + x.Name);
            }
            else
            {
                Console.WriteLine("Oldest person: Y: " + y.Name);
            }
        }
    }
}