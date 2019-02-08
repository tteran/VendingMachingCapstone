using Capstone.VMComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapstoneTests
{
    [TestClass]
    public class InventoryTests
    {
        /// <summary>
        /// This (unsuccessfully) tests the reflection inside stockMachine method.
        /// </summary>
        [TestMethod]
        public void TestInventory_ShouldReturnCorrectItemString()
        {
            Inventory inventory = new Inventory();
            Dictionary<string, VendingMachineProduct> actualOutput = new Dictionary<string, VendingMachineProduct>();
            Dictionary<string, VendingMachineProduct> expectedReturn = new Dictionary<string, VendingMachineProduct>()
            {
                {"A1", new Chip("Potato Crisps", "3.05") },
                {"A2", new Chip("Stackers", "1.45") },
                {"A3", new Chip("Grain Waves", "2.75") },
                {"A4", new Chip("Cloud Popcorn", "3.65") },
                {"B1", new Candy("Moonpie", "1.80") },
                {"B2", new Candy("Cowtales", "1.50") },
                {"B3", new Candy("Wonka Bar", "1.50") },
                {"B4", new Candy("Crunchie", "1.75") },
                {"C1", new Drink("Cola", "1.25") },
                {"C2", new Drink("Dr. Salt", "1.50") },
                {"C3", new Drink("Mountain Melter", "1.50") },
                {"C4", new Drink("Heavy", "1.50") },
                {"D1", new Gum("U-Chews", "0.85") },
                {"D2", new Gum("Little League Chew", "0.95") },
                {"D3", new Gum("Chiclets", "0.75") },
                {"D4", new Gum("Triplemint", "0.75") }
            };

            inventory.StockMachine(actualOutput);

            foreach (KeyValuePair<string, VendingMachineProduct> kv in expectedReturn)
            {
                string expectedKey = kv.Key;
                bool hasKey = actualOutput.TryGetValue(expectedKey, out VendingMachineProduct actualValue);
                Assert.IsTrue(hasKey);
                VendingMachineProduct expectedValue = kv.Value;
                Assert.AreEqual(expectedValue, actualValue);
            }
        }
    }
}
