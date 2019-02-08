using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Capstone.VendingMachine
{
    /// <summary>
    /// Represents a Vending Machine
    /// </summary>
    public class VendingMachine
    {
        /// <summary>
        /// The current balance for the machine
        /// </summary>
        public decimal CurrentBalance { get; private set; }

        /// <summary>
        /// A List that represents the products purchased by the customer BEFORE the finish transaction method is called
        /// </summary>
        protected List<VendingMachineProduct> purchasedProducts = new List<VendingMachineProduct>();

        /// <summary>
        /// Represents the inventory of the machine based on slotCode and product
        /// </summary>
        public Dictionary<string, VendingMachineProduct> inventory = new Dictionary<string, VendingMachineProduct>();
        //{
        //    get
        //    {
        //        // Create a Dictionary
        //        return new Dictionary<string, VendingMachineProduct>();
        //    }
        //}


        /// <summary>
        /// Creates a Vending Machine
        /// </summary>
        public VendingMachine()
        {
            this.CurrentBalance = 0;
            Inventory inv = new Inventory();
            inv.StockMachine(inventory);
        }

        /// <summary>
        /// Method for adding money to Vending Machine.
        /// </summary>
        public void FeedMoney(int dollarsPutIn)
        {
            int currentMoneyProvided = 0;

            int[] validTender = new int[4] { 1, 2, 5, 10 };

            if (!validTender.Contains(dollarsPutIn))
            {
                Console.Write("Please enter a valid bill ($1, $2, $5, $10)");
            }
            else
            {
                
                currentMoneyProvided += dollarsPutIn;
               
            }

            this.CurrentBalance += currentMoneyProvided;

        }

        public void Buy(string slotCode)
        {
            // TODO add method code for Buy method

            if (inventory.TryGetValue(slotCode.ToUpper(), out VendingMachineProduct selectedProduct))
            {
                // Check if sold out
                if (selectedProduct == null)
                {
                    Console.WriteLine("Product does not exist.");
                    return;
                }
                if (selectedProduct.Quantity == 0)
                {
                    Console.WriteLine("Product is SOLD OUT.");
                    return;
                }
                 
                // Check if the user has enough money to buy the product.
                if (this.CurrentBalance < selectedProduct.Price)
                {
                    Console.WriteLine("Not enough credits.");
                    return;
                }

                //Console.WriteLine(selectedProduct.ProductSelection());
                this.CurrentBalance -= selectedProduct.Price;
                selectedProduct.Quantity--;

                // Adds selected product to customer's inventory.
                this.purchasedProducts.Add(selectedProduct);

                // At the end of the buy method we reasigned the updated version of that product 
                this.inventory[slotCode] = selectedProduct;
            }
            else
            {
                Console.WriteLine("Not a valid slot code.");
            }
        }

        /// <summary>
        /// This finalizes the transaction.
        /// </summary>
        /// <returns></returns>
        public void FinishTransaction()
        {
            // Call change method.
            Change change = new Change();
            change.MakeChange(this.CurrentBalance);

            // Set machine's current balance to 0.
            this.CurrentBalance = 0;

            // Print message based on snacks purchased.
            foreach (VendingMachineProduct product in purchasedProducts)
            {
                Console.WriteLine($"{product.ProductSelection()}");
            }

            // Gets list ready for next transaction.
            purchasedProducts.Clear();
            Console.ReadLine();
        }
    }

}
