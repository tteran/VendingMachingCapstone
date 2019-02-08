using DeliveryApp.CLIs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.CLIs
{
    class PurchaseMenuCLI : CLI
    {
        public override void Run()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Purchasing Process Menu");
                Console.WriteLine("1. Feed Money");
                Console.WriteLine("2. Select Product");
                Console.WriteLine("3. Finish Transaction");
                Console.WriteLine($"Current money provided:");
                string choice = GetString("Pick One: ");

                if(choice == "1")
                {
                    while(true)
                    {
                        vendingMachine.FeedMoney();
                      
                        string yesno = GetString("Would you like to add more money (y/n)?");
                        
                        if(yesno.ToLower().StartsWith('n'))
                        {
                            break;
                        }
                    }
                }
                else if(choice == "2")
                {

                }
                else if(choice == "3")
                {

                }
            }
        }
    }
}
