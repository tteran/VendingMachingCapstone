using Capstone.VendingMachine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CapstoneTests
{
    [TestClass]
    public class ChangeTests
    {
        [DataTestMethod]
        [DataRow(5.00, 20, 0, 0)]
        [DataRow(3.15, 12, 1, 1)]
        [DataRow(3.15, 12, 1, 1)]
        [DataRow(3.55, 12, 1, 1)]
        public void TestMakeChangeMethod(double balance, int expectedQuarters, int expectedDimes, int expectedNickels)
        {
            Change change = new Change();

            change.MakeChange((decimal)balance);

            Assert.AreEqual(expectedQuarters, change.Quarters);
        }
    }
}
