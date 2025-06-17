using System;
using System.Globalization;

namespace BankExercise {
    class Program()
    {
        static void Main(string[] args)
        {
            BankAccount account;

            Console.WriteLine("Enter the account number: ");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the account name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Will there be an initial deposit? (y/n) ");
            char res = char.Parse(Console.ReadLine());

            if (res == 'y') {
                Console.WriteLine("Enter the initial deposit value: ");
                double initialDeposit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                account = new BankAccount(name, number, initialDeposit);
            }
            else
            {
                account = new BankAccount(name, number);    
            }

            Console.WriteLine();
            Console.WriteLine("Account info: ");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.WriteLine("Enter the amount to deposit: ");
            double amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Deposit(amount);
            Console.WriteLine("Updated account info: ");
            Console.WriteLine(account);

            Console.WriteLine();
            Console.WriteLine("Enter the amount to withdrawal: ");
            amount = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            account.Withdrawal(amount);
            Console.WriteLine("Updated account info: ");
            Console.WriteLine(account);
        }
    }
}