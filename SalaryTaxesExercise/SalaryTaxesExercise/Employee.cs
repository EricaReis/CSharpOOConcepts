using System;
using System.Globalization;

namespace SalaryTaxesExercise {
    internal class Employee {
        public string Name;
        public double Salary;
        public double Tax;

        public double FinalSalary() {
            double salary = Salary - Tax;

            return salary;
        }

        public void IncreaseSalary(double percentage)
        {
            Salary = Salary + (Salary * percentage / 100.00);
           
        }

        public override string ToString()
        {
            return Name
                + ", R$"
                + FinalSalary().ToString("F2", CultureInfo.InvariantCulture);
            return base.ToString();
        }
    }
}
