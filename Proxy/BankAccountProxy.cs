namespace Bank
{
    public class BankAccountProxy : IBankAccount
    {
        private readonly BankAccount _bankAccount;
        private readonly string _password;

        public BankAccountProxy(string password)
        {
            _bankAccount = new BankAccount();
            _password = password;
        }

        private bool Authenticate(string password)
        {
            return password == _password;
        }

        public void Deposit(decimal amount)
        {
            Console.Write("Enter password to deposit: ");
            string inputPassword = Console.ReadLine();
            if (Authenticate(inputPassword))
            {
                _bankAccount.Deposit(amount);
            }
            else
            {
                Console.WriteLine("Authentication failed. Access denied.");
            }
        }

        public void Withdraw(decimal amount)
        {
            Console.Write("Enter password to withdraw: ");
            string inputPassword = Console.ReadLine();
            if (Authenticate(inputPassword))
            {
                _bankAccount.Withdraw(amount);
            }
            else
            {
                Console.WriteLine("Authentication failed. Access denied.");
            }
        }

        public decimal GetBalance()
        {
            Console.Write("Enter password to view balance: ");
            string inputPassword = Console.ReadLine();
            if (Authenticate(inputPassword))
            {
                return _bankAccount.GetBalance();
            }
            else
            {
                Console.WriteLine("Authentication failed. Access denied.");
                return 0;
            }
        }
    }
}
