using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.VMComponents
{
    /// <summary>
    /// Represents a Drink vending product
    /// </summary>
    public class Drink: VendingMachineProduct
    {
        /// <summary>
        /// Creates a Drink product
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public Drink(string name, string price) : base(name, price)
        {

        }

        /// <summary>
        /// Returns the consumed message.
        /// </summary>
        /// <returns></returns>
        public override string ConsumedMessage()
        {
            return "Glug Glug, Yum!";
        }
    }
}
