using DeliveryApp.CLIs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.CLIs
{
    /// <summary>
    /// This is a main menu.
    /// </summary>
    public class MainMenuCLI : CLI
    {
        public override void Run(VendingMachine.VendingMachine vendingMachine)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Vendo-Matic 500");

                Console.WriteLine("Please make a choice");
                Console.WriteLine("1. Display Vending Machine Items");
                Console.WriteLine("2. Purchase");
                Console.WriteLine("3. Quit");
                string choice = GetString("Pick One: ");

                if(choice == "1")
                {
                    vendingMachine.DisplayVendingMachineItems(vendingMachine.inventory);
                    Console.ReadLine();
                }
                else if (choice == "2")
                {
                    PurchaseMenuCLI purchaseMenu = new PurchaseMenuCLI();
                    purchaseMenu.Run(vendingMachine);
                }
                else if (choice == "Q" || choice == "q" || choice == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Option.");
                    Console.ReadLine();
                }
            }
        }
    }
}
