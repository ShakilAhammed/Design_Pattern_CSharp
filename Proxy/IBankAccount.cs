namespace Bank{
    public interface IBankAccount{
        void Withdraw(decimal amount);
        void Deposit(decimal amount);
        decimal GetBalance();
    }
}
