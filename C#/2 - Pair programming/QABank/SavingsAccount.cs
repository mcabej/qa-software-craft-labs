using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QABank
{
    public class SavingsAccount : BankAccount
    {
        public SavingsAccount(string customerName, string accountNumber, decimal balance, decimal interestRates) : base(customerName, accountNumber, balance)
        {
            InterestRates = interestRates;
        }

        public decimal InterestRates { get; set; }

        public void AddInterest()
        {
            Balance = Balance + (Balance * InterestRates);
        }
    }
}
