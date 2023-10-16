using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_Unit_Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_Unit_Testing.Tests
{
    [TestClass()]
    public class SavingsTests
    {
        // Arrange

        // Act

        // Assert

        [TestMethod()]
        public void DepositTestSuccess()
        {
            // Arrange
            Savings savings = new Savings(0);
            double depositAmount = 10;
            double expected = 15;
            // Act
            savings.Deposit(depositAmount);
            double outcome = savings._balance;
            // Assert
            // Expected and Actual
            Assert.AreEqual(expected, outcome);
            //Assert.Fail();
        }
        [TestMethod()]
        public void DepositTestNegativeValue()
        {
            // Arrange
            Savings savings = new Savings(0);
            double depositAmount = -10;
            double expected = 0;
            // Act
            savings.Deposit(depositAmount);
            double outcome = savings._balance;
            // Assert
            // Expected and Actual
            Assert.AreEqual(expected, outcome);
        }

        [TestMethod()]
        public void WithdrawTestSuccess()
        {
            // Arrange
            Savings savings = new Savings(100);
            double withdrawAmount = 10;
            double expected = 90;
            // Act
            savings.Withdraw(withdrawAmount);
            double outcome = savings._balance;
            // Assert
            // Expected and Actual
            Assert.AreEqual(expected, outcome);
        }

        [TestMethod()]
        public void WithdrawTestNegativeValue()
        {
            // Arrange
            Savings savings = new Savings(100);
            double withdrawAmount = -10;
            double expected = 100;
            // Act
            savings.Withdraw(withdrawAmount);
            double outcome = savings._balance;
            // Assert
            // Expected and Actual
            Assert.AreEqual(expected, outcome);
        }
    }
}