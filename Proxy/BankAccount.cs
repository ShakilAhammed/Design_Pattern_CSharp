namespace Bank
{
    public class BankAccount : IBankAccount
    {
        private decimal _balance;

        public void Deposit(decimal amount)
        {
            _balance += amount;
            Console.WriteLine($"Deposited {amount:C}, new balance is {_balance:C}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= _balance)
            {
                _balance -= amount;
                Console.WriteLine($"Withdrew {amount:C}, new balance is {_balance:C}");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public decimal GetBalance()
        {
            return _balance;
        }

    }
}
