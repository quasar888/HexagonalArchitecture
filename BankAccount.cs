namespace Domain.Entities
{
    public class BankAccount
    {
        public int AccountId { get; set; }
        public decimal Balance { get; private set; }

        public BankAccount(int accountId, decimal initialBalance)
        {
            AccountId = accountId;
            Balance = initialBalance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Deposit amount must be positive.");

            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Withdraw amount must be positive.");
            if (amount > Balance)
                throw new InvalidOperationException("Insufficient balance.");

            Balance -= amount;
        }
    }
}
