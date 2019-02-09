using Capstone.VMComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace CapstoneTests
{
    [TestClass]
    public class FeedMoneyMethodTests
    {
        [TestMethod]
        public void CurrentMoneyProvidedUpdatesCorrectly()
        {
            // Arrange
            VendingMachine vendingMachine = new VendingMachine();
            int dollarsPutIn = 5;

            // Act
            vendingMachine.FeedMoney(dollarsPutIn);

            // Assert
            Assert.AreEqual(dollarsPutIn, vendingMachine.CurrentBalance);
        }

        [TestMethod]
        public void BillsProvidedAreValidBills()
        {
            // Arrange
            VendingMachine vendingMachine = new VendingMachine();
            int dollarsPutIn = 3;

            // Act
            vendingMachine.FeedMoney(dollarsPutIn);

            // Assert
            Assert.AreEqual(0, vendingMachine.CurrentBalance, "Input Invalid.");
        }
        
    }
}
