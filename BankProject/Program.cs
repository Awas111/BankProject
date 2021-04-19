using System;


namespace BankAccountNS
{
   
    public class BankAccount
    {
        private readonly string customerName;
        private double bank_balance;

        private BankAccount() { }

        public BankAccount(string customerName, double balance)
        {
            this.customerName = customerName;
            bank_balance = balance;
        }

        public string CustomerName
        {
            get { return customerName; }
        }

        public double Balance
        {
            get { return bank_balance; }
        }

        public void Debit(double amount)
        {
            if (amount > bank_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            bank_balance -= amount; 
        }

        public void Credit(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            bank_balance += amount;
        }

        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr. Rayyan", 500.50);

            ba.Credit(00.50);
            ba.Debit(50.00);
            Console.WriteLine("Current balance is ${0}", ba.Balance);
        }
    }
}

