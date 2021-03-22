using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using QABank;

namespace QABank.Test
{
    [TestClass]
    public class BankAccountTest
    {
        [TestMethod]
        public void Deposit()
        {
            // Arrange
            BankAccount bankAccount = new BankAccount("QA", "1234", 500.00M);

            // Act
            bankAccount.Deposit(25.00M);

            // Assert
            Assert.AreEqual(bankAccount.Balance, 525.00M);
        }

        [TestMethod]
        public void Withdraw()
        {
            // Arrange
            BankAccount bankAccount = new BankAccount("QA", "1234", 500.00M);

            // Act & Assert
            Assert.IsTrue(bankAccount.Withdraw(25.00M));
        }

        [TestMethod]
        public void AddInterest()
        {
            // Arrange
            SavingsAccount bankAccount = new SavingsAccount("QA", "1234", 500.00M, 0.1M);

            // Act
            bankAccount.AddInterest();

            // Assert
            Assert.AreEqual(bankAccount.Balance, 550.00M);
        }

        [TestMethod]
        public void OverdraftLimit()
        {
            CurrentAccount currentAccount = new CurrentAccount("QA", "1234", 500.00M, 100.00M);

            Assert.IsFalse(currentAccount.Withdraw(100.01M));
        }
    }
}
