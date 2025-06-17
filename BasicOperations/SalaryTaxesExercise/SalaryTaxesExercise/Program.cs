using System;
using SalaryTaxesExercise;
using System.Globalization;

namespace SalaryTaxes {
    class Program {
        static void Main(string[] args)
        {
            Employee y;

            y = new Employee();

            Console.WriteLine("Enter employee name: ");
            y.Name = Console.ReadLine();

            Console.WriteLine("Enter employee salary:");
            y.Salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Enter employee Tax:");
            y.Tax = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double finalSalary = y.FinalSalary();
            Console.WriteLine(y.Name + ", $" + finalSalary);

            Console.WriteLine("Enter the percentage to increase the salary: ");
            double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            y.IncreaseSalary(percentage);
            Console.WriteLine("Updated Data:" + y);
        }
    }
}