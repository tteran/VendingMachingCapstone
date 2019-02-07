using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.VendingMachine
{
    public class Candy:VendingMachineProduct
    {
        public Candy(string name, decimal price):base(name, price)
        {

        }

        /// <summary>
        /// Returns the consumed Message
        /// </summary>
        /// <returns></returns>
        public override string ProductSelection()
        {
            return "Munch Munch, Yum!";
        }
    }
}
