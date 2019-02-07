using DeliveryApp.CLIs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.CLIs
{
    /// <summary>
    /// This is a main menu.
    /// </summary>
    class MainMenuCLI : CLI
    {
        public override void Run()
        {
            while (true)
            {
                Console.WriteLine("Welcome to the Vendo-Matic 500");

                Console.WriteLine("Please make a choice");
                Console.WriteLine("1. Display Vending Machine Items");
                Console.WriteLine("2. Purchase");
                Console.WriteLine("3. Quit");
                string choice = GetString("Pick One: ");

                if(choice == "1")
                {
                    // Displays inventory to user.

                }
                else if (choice == "2")
                {
                    PurchaseMenuCLI purchaseMenu = new PurchaseMenuCLI();
                    purchaseMenu.Run();
                }
                else if (choice == "Q" || choice == "q")
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
