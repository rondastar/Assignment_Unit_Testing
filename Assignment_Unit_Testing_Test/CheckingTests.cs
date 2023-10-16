using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment_Unit_Testing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace Assignment_Unit_Testing.Tests
{
    [TestClass()]
    public class CheckingTests
    {
        [TestMethod()]
        public void DepositTestSuccess()
        {
            // Arrange
            Checking checking = new Checking(0);
            double depositAmount = 10;
            double expected = 10;
            // Act
            checking.Deposit(depositAmount);
            double outcome = checking._balance;
            // Assert
            // Expected and Actual
            Assert.AreEqual(expected, outcome);
        }
        [TestMethod()]
        public void DepositTestNegativeValue()
        {
            // Arrange
            Checking checking = new Checking(100);
            double depositAmount = -5;
            double expected = 100;
            // Act
            checking.Deposit(depositAmount);
            double outcome = checking._balance;
            // Assert
            // Expected and Actual
            Assert.AreEqual(expected, outcome);
        }
        [TestMethod()]
        public void WithdrawTestPositiveBalance()
        {
            // Arrange
            Checking checking = new Checking(100);
            double withdrawAmount = 10;
            double expected = 90;
            // Act
            checking.Withdraw(withdrawAmount);
            double outcome = checking._balance;
            // Assert
            // Expected and Actual
            Assert.AreEqual(expected, outcome);
        }
        [TestMethod()]
        public void WithdrawTestOverdraftFee()
        {
            // Arrange
            Checking checking = new Checking(100);
            double withdrawAmount = 110;
            double expected = 85;
            // Act
            checking.Withdraw(withdrawAmount);
            double outcome = checking._balance;
            // Assert
            // Expected and Actual
            Assert.AreEqual(expected, outcome);
        }
    }
}