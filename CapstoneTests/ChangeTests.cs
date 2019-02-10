using Capstone.VMComponents;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapstoneTests
{
    [TestClass]
    public class ChangeTests
    {
        [DataTestMethod]
        [DataRow(1.00, 4)]
        [DataRow(1.15, 4)]
        [DataRow(.15, 0)]
        [DataRow(.05, 0)]
        public void TestMakeChangeMethod_ReturnsCorrectNumberOf_Quraters(double balance, int expectedQuarters)
        {
            Change change = new Change();

            change.MakeChange((decimal)balance);

            Assert.AreEqual(expectedQuarters, change.Quarters, "Quarters");
        }

        [DataTestMethod]
        [DataRow(1.00, 0)]
        [DataRow(1.10, 1)]
        [DataRow(1.15, 1)]
        [DataRow(1.05, 0)]
        [DataRow(0.05, 0)]
        public void TestMakeChangeMethod_ReturnsCorrectNumberOf_Dimes(double balance, int expectedDimes)
        {
            Change change = new Change();

            change.MakeChange((decimal)balance);

            Assert.AreEqual(expectedDimes, change.Dimes, "Dimes");
        }

        [DataTestMethod]
        [DataRow(1.00, 0)]
        [DataRow(1.10, 0)]
        [DataRow(1.15, 1)]
        [DataRow(1.05, 1)]
        public void TestMakeChangeMethod_ReturnsCorrectNumberOf_Nickels(double balance, int expectedNickels)
        {
            Change change = new Change();

            change.MakeChange((decimal)balance);

            Assert.AreEqual(expectedNickels, change.Nickels, "Nickels");
        }
    }
}
