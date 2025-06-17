using System;
using AverageSalaryExercise;
using System.Globalization;

namespace AverageSalary {
    class Program {
        static void Main(string[] args)
        {
            Employee a = new Employee();
            Employee b = new Employee();

            Console.WriteLine("Enter the A employee name:");
            a.Name = Console.ReadLine();
            Console.WriteLine("Enter the A employee salary:");
            a.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter the B employee name:");
            b.Name = Console.ReadLine();
            Console.WriteLine("Enter the B employee salary:");
            b.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double average = (a.Salary + b.Salary) / 2.0;

            Console.WriteLine("Average Salary: of employees: " + average.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}