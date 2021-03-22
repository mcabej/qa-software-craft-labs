namespace QABank
{
    public class BankAccount
    {
        public BankAccount(string customerName, string accountNumber, decimal balance)
        {
            CustomerName = customerName;
            AccountNumber = accountNumber;
            Balance = balance;
        }

        public string CustomerName { get; set; }

        public string AccountNumber { get; set; }

        public decimal Balance { get; set; } // Pounds

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public virtual bool Withdraw(decimal amount)
        {
            if (amount > Balance) 
                return false; // Cannot withdraw more than you have

            Balance -= amount;

            return true;
        }
    }    
}