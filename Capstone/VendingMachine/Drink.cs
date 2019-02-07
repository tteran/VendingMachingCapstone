using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.VendingMachine
{
    public class Drink: VendingMachineProduct
    {
        public Drink(string name, decimal price) : base(name, price)
        {

        }

        /// <summary>
        /// Returns the consumed message.
        /// </summary>
        /// <returns></returns>
        public override string ProductSelection()
        {
            return "Glug Glug, Yum!";
        }
    }
}
