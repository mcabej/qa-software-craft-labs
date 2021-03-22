using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QABank
{
    public class CurrentAccount : BankAccount
    {
        public CurrentAccount(string customerName, string accountNumber, decimal balance, decimal overdraft) : base(customerName, accountNumber, balance)
        {
            Overdraft = overdraft;
        }

        public decimal Overdraft { get; set; }

        public override bool Withdraw(decimal amount)
        {
            if (amount > Overdraft) return false;           

            return base.Withdraw(amount);
        }
    }
}
