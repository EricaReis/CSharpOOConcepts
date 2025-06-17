using System;
using System.Globalization;
using HostelExercise;

namespace Hostel {
    class Program
    {
        static void Main(string[] args) {
            RentedRoom[] vect = new RentedRoom[10];


            Console.WriteLine("How many rooms will be rented? (1 - 10)");
            int studentsQty = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            for (int i = 0; i < studentsQty; i++) {
                Console.WriteLine("Enter the name for the student number " + i + ":");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the e-mail for the student number " + i + ":");
                string email = Console.ReadLine();

                Console.WriteLine("Enter the number of the bedroom (1-10) for the student number " + i + ":");
                int bedroom = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (vect[bedroom] == null)
                {
                    vect[bedroom] = new RentedRoom(name, email);
                }
            }

            Console.WriteLine();

            Console.WriteLine("Busy Bedrooms: ");

            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);
                }
            }
        }
    }
}