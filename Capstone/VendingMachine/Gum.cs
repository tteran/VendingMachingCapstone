using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.VendingMachine
{
    public class Gum: VendingMachineProduct
    {
        public Gum(string name, decimal price) : base(name, price)
        {

        }

        /// <summary>
        /// Returns the consumed Message
        /// </summary>
        /// <returns></returns>
        public override string ProductSelection()
        {
            return "Chew Chew, Yum!";
        }
    }
}
