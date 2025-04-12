using System;
using System.Globalization;


namespace BankExercise {
    internal class BankAccount {
        public string Name { get; set; }
        public int Number {  get; private set; }
        public double Amount { get; private set; }

        public BankAccount(string name, int number)
        {
            Name = name;
            Number = number;
            Amount = 0;
        }

        public BankAccount(string name, int number, double initialDeposit) {
            {
                Deposit(initialDeposit);
            }
        }

        public void Deposit(double amount)
        {
            Amount += amount;   
        }

        public void Withdrawal(double amount)
        {
            Amount -= amount;
            Amount -= 5.0;
        }

        public override string ToString()
        {
            return "Account " + Number + ", Name: " + Name + ", Amount: $" + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
