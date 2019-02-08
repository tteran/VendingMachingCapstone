using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.VMComponents
{
    /// <summary>
    /// Represents a Candy vending product
    /// </summary>
    public class Candy:VendingMachineProduct
    {
        /// <summary>
        /// Creates a Candy product
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public Candy(string name, string price):base(name, price)
        {

        }

        /// <summary>
        /// Returns the consumed message.
        /// </summary>
        /// <returns></returns>
        public override string ConsumedMessage()
        {
            return "Munch Munch, Yum!";
        }
    }
}
