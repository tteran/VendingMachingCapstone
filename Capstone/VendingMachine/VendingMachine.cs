using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.VendingMachine
{
    /// <summary>
    /// Represents a Vending Machine
    /// </summary>
    public class VendingMachine
    {
        public decimal CurrentBalance { get; private set; }

        public Dictionary<string, VendingMachineProduct> Inventory
        {
            get
            {
                // Create a Dictionary
                return new Dictionary<string, VendingMachineProduct>();
            }
        }

        public VendingMachine()
        {
            this.CurrentBalance = 0;
        }

        public void Buy(string slotCode)
        {
            VendingMachineProduct selectedProduct = this.Inventory[slotCode];

        }
    }
}
