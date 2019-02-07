using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.VendingMachine
{
    public abstract class VendingMachineProduct
    {
        /// <summary>
        /// Gets the name of the product.
        /// </summary>
        public string Name { get; }
        
        /// <summary>
        /// Gets the quantity of the product.
        /// </summary>
        public int Quantity { get; private set; }
        // TODO The "Private Set" in the VMProduct Class might prevent us from modifing this prop in vending Machine Class


        /// <summary>
        /// Gets the price of the product.
        /// </summary>
        public decimal Price { get; }

        /// <summary>
        /// Creates a Vending machine product
        /// </summary>
        /// <param name="name"></param>
        /// <param name="price"></param>
        public VendingMachineProduct(string name, decimal price)
        {
            this.Quantity = 5;
            this.Name = name;
            this.Price = price;
        }

        /// <summary>
        /// Returns the consumed Message
        /// </summary>
        /// <returns></returns>
        //public virtual string ProductSelection()
        //{
        //    return "";
        //} 

        public abstract string ProductSelection();
    }
}
