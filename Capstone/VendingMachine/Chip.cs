using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.VendingMachine
{
    public class Chip:VendingMachineProduct
    {
        public Chip(string name, decimal price) : base(name, price)
        {

        }

        /// <summary>
        /// Returns the consumed message.
        /// </summary>
        /// <returns></returns>
        public override string ProductSelection()
        {
            return "Crunch Crunch, Yum!";
        }

    }
}
