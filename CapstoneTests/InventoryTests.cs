using Capstone.VMComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentAssertions;

namespace CapstoneTests
{
    [TestClass]
    public class InventoryTests
    {
        /// <summary>
        /// This tests the reflection inside stockMachine method.
        /// </summary>
        [TestMethod]
        public void TestInventory_ShouldReturnCorrectItemString()
        {
            Inventory inventory = new Inventory();
            Dictionary<string, VendingMachineProduct> actualOutput = new Dictionary<string, VendingMachineProduct>();
            Dictionary<string, VendingMachineProduct> expectedReturn = new Dictionary<string, VendingMachineProduct>()
            {
                { "A1", new Chip("Potato Crisps", "3.05") },
                { "A2", new Chip("Stackers", "1.45") },
                { "A3", new Chip("Grain Waves", "2.75") },
                { "A4", new Chip("Cloud Popcorn", "3.65") },
                { "B1", new Candy("Moonpie", "1.80") },
                { "B2", new Candy("Cowtales", "1.50") },
                { "B3", new Candy("Wonka Bar", "1.50") },
                { "B4", new Candy("Crunchie", "1.75") },
                { "C1", new Drink("Cola", "1.25") },
                { "C2", new Drink("Dr. Salt", "1.50") },
                { "C3", new Drink("Mountain Melter", "1.50") },
                { "C4", new Drink("Heavy", "1.50") },
                { "D1", new Gum("U-Chews", "0.85") },
                { "D2", new Gum("Little League Chew", "0.95") },
                { "D3", new Gum("Chiclets", "0.75") },
                { "D4", new Gum("Triplemint", "0.75") }
            };

            inventory.StockMachine(actualOutput);

            foreach (KeyValuePair<string, VendingMachineProduct> kv in expectedReturn)
            {
                string expectedKey = kv.Key;
                
                // Tests if key exists
                bool hasKey = actualOutput.TryGetValue(expectedKey, out VendingMachineProduct actualValue);
                Assert.IsTrue(hasKey);

                // Tests if actual object value is not null
                Assert.IsNotNull(actualValue);

                // Tests if objects are the same, with the same properties
                VendingMachineProduct expectedValue = kv.Value;
                expectedValue.Should().BeEquivalentTo(actualValue);
            }
        }

        [DataTestMethod]
        [DataRow("A1")]
        [DataRow("A2")]
        [DataRow("A3")]
        [DataRow("A4")]
        [DataRow("B1")]
        [DataRow("B2")]
        [DataRow("B3")]
        [DataRow("B4")]
        [DataRow("C1")]
        [DataRow("C2")]
        [DataRow("C3")]
        [DataRow("C4")]
        [DataRow("D1")]
        [DataRow("D2")]
        [DataRow("D3")]
        [DataRow("D4")]
        public void TestInventory_Check_If_Key_Is_Generated(string expectedKey)
        {
            string str = @"FakeInventories\FakeInvProper.csv";
            Inventory inventory = new Inventory();
            Dictionary<string, VendingMachineProduct> stubInventory = new Dictionary<string, VendingMachineProduct>();

            inventory.StockMachine(stubInventory, str);
            // Tests if key exists
            bool hasKey = stubInventory.ContainsKey(expectedKey);

            Assert.IsTrue(hasKey);
        }

        [DataTestMethod]
        [DataRow("A1", true)]
        [DataRow("A2", true)]
        [DataRow("A4", true)]
        public void TestInventory_Check_If_ThereAreNo_With_NullValuesForThe_Values_Of_KeyValuePairs(string expectedKey, bool isNotNull)
        {
            string str = @"FakeInventories\FakeInvNulls.csv";
            Inventory inventory = new Inventory();
            Dictionary<string, VendingMachineProduct> stubInventory = new Dictionary<string, VendingMachineProduct>();

            inventory.StockMachine(stubInventory, str);
            // Tests if key exists
            bool hasKey = stubInventory.TryGetValue(expectedKey, out VendingMachineProduct mockValue);

            Assert.IsNotNull(mockValue);
        }

        [DataTestMethod]
        [DataRow("A3")]
        public void TestInventory_Check_IfNullKeyValuesPairs_With_NullValues_HaveBeenRemoved(string expectedKey)
        {
            string str = @"FakeInventories\FakeInvNulls.csv";
            Inventory inventory = new Inventory();
            Dictionary<string, VendingMachineProduct> stubInventory = new Dictionary<string, VendingMachineProduct>();

            inventory.StockMachine(stubInventory, str);
            // Tests if key exists
            bool hasKey = stubInventory.ContainsKey(expectedKey);

            Assert.IsFalse(hasKey);
        }

        [DataTestMethod]
        [DataRow("A1", "Chip")]
        [DataRow("A2", "Chip")]
        [DataRow("A3", "Chip")]
        [DataRow("A4", "Chip")]
        [DataRow("B1", "Candy")]
        [DataRow("B2", "Candy")]
        [DataRow("B3", "Candy")]
        [DataRow("B4", "Candy")]
        [DataRow("C1", "Drink")]
        [DataRow("C2", "Drink")]
        [DataRow("C3", "Drink")]
        [DataRow("C4", "Drink")]
        [DataRow("D1", "Gum")]
        [DataRow("D2", "Gum")]
        [DataRow("D3", "Gum")]
        [DataRow("D4", "Gum")]
        public void TestInventory_Check_If_Type_was_Deserialzied(string expectedKey, string expectedType)
        {
            string str = @"FakeInventories\FakeInvProper.csv";
            Inventory inventory = new Inventory();
            Dictionary<string, VendingMachineProduct> mockInventory = new Dictionary<string, VendingMachineProduct>();

            inventory.StockMachine(mockInventory, str);

            // Tests if key exists
            bool hasKey = mockInventory.ContainsKey(expectedKey);

            Assert.AreEqual(mockInventory[expectedKey].GetType().Name, expectedType);
        }

        [DataTestMethod]
        [DataRow("A1", "Potato Crisps")]
        [DataRow("A2", "Stackers")]
        [DataRow("A3", "Grain Waves")]
        [DataRow("A4", "Cloud Popcorn")]
        [DataRow("B1", "Moonpie")]
        [DataRow("B2", "Cowtales")]
        [DataRow("B3", "Wonka Bar")]
        [DataRow("B4", "Crunchie")]
        [DataRow("C1", "Cola")]
        [DataRow("C2", "Dr. Salt")]
        [DataRow("C3", "Mountain Melter")]
        [DataRow("C4", "Heavy")]
        [DataRow("D1", "U-Chews")]
        [DataRow("D2", "Little League Chew")]
        [DataRow("D3", "Chiclets")]
        [DataRow("D4", "Triplemint")]
        public void TestInventory_Check_If_Name_was_Deserialzied(string expectedKey, string expectedName)
        {
            string str = @"FakeInventories\FakeInvProper.csv";
            Inventory inventory = new Inventory();
            Dictionary<string, VendingMachineProduct> mockInventory = new Dictionary<string, VendingMachineProduct>();

            inventory.StockMachine(mockInventory, str);

            Assert.AreEqual(mockInventory[expectedKey].Name, expectedName);
        }

        [DataTestMethod]
        [DataRow("A1", 3.05)]
        [DataRow("A2", 1.45)]
        [DataRow("A3", 2.75)]
        [DataRow("A4", 3.65)]
        [DataRow("B1", 1.80)]
        [DataRow("B2", 1.50)]
        [DataRow("B3", 1.50)]
        [DataRow("B4", 1.75)]
        [DataRow("C1", 1.25)]
        [DataRow("C2", 1.50)]
        [DataRow("C3", 1.50)]
        [DataRow("C4", 1.50)]
        [DataRow("D1", 0.85)]
        [DataRow("D2", 0.95)]
        [DataRow("D3", 0.75)]
        [DataRow("D4", 0.75)]
        public void TestInventory_Check_If_Price_was_Deserialzied(string expectedKey, double expectedPrice)
        {
            string str = @"FakeInventories\FakeInvProper.csv";
            Inventory inventory = new Inventory();
            Dictionary<string, VendingMachineProduct> mockInventory = new Dictionary<string, VendingMachineProduct>();

            inventory.StockMachine(mockInventory, str);

            Assert.AreEqual(mockInventory[expectedKey].Price, (decimal)expectedPrice);
        }

    }
}
