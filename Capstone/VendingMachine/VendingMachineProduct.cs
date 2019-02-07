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
        
        /// <summary>
        /// Gets the price of the product.
        /// </summary>
        public decimal Price { get; }

        public VendingMachineProduct(string name, decimal price)
        {
            this.Quantity = 5;
            this.Name = name;
            this.Price = price;
        }

        public virtual string ProductSelection()
        {
            return "";
        } 
    }
}
