using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.VMComponents
{
    /// <summary>
    /// Represents a Chip vending product
    /// </summary>
    public class Chip:VendingMachineProduct
    {
        /// <summary>
        /// Creates a Chip product
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public Chip(string name, string price) : base(name, price)
        {

        }

        /// <summary>
        /// Returns the consumed message.
        /// </summary>
        /// <returns></returns>
        public override string ConsumedMessage()
        {
            return "Crunch Crunch, Yum!";
        }

    }
}
