using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.VMComponents
{
    /// <summary>
    /// Represents a Gum vending product
    /// </summary>
    public class Gum: VendingMachineProduct
    {
        /// <summary>
        /// Creates a gum product
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public Gum(string name, string price) : base(name, price) { }
   
        /// <summary>
        /// Returns the consumed message.
        /// </summary>
        /// <returns></returns>
        public override string ConsumedMessage()
        {
            return "Chew Chew, Yum!";
        }
    }
}
