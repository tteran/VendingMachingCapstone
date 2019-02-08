using DeliveryApp.CLIs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.CLIs
{
    class PurchaseMenuCLI : CLI
    {
        public override void Run(VendingMachine.VendingMachine vendingMachine)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Purchasing Process Menu");
                Console.WriteLine("1. Feed Money");
                Console.WriteLine("2. Select Product");
                Console.WriteLine("3. Finish Transaction");
                Console.WriteLine($"Current money provided: {vendingMachine.CurrentBalance:C2}");
                string choice = GetString("Pick One: ");

                if(choice == "1")
                {
                    while(true)
                    {
                        string userinput = GetString("Please enter amount: ");
                        if (int.TryParse(userinput, out int dollarsPutIn))
                        {
                            // TODO update Current money provided as money is feed after each input.
                            vendingMachine.FeedMoney(dollarsPutIn);
                            DisplayPurchaseMenu(vendingMachine, choice);

                            string yesno = GetString("Would you like to add more money (y/n)?");
                            
                            if(yesno.ToLower().StartsWith('n'))
                            {
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Not a vaild amount, tender must be numeric (1, 2, etc.).");
                        }
                    }
                }
                else if(choice == "2")
                {
                    while (true)
                    {
                        string slotCode = GetString("Please enter a slot code: ");

                        // TODO update Current money provided as each product is selected after each input.
                        vendingMachine.Buy(slotCode);
                        DisplayPurchaseMenu(vendingMachine, choice);
                        string yesno = GetString("Would you to buy something else (y/n)?");

                        if (yesno.ToLower().StartsWith('n'))
                        {
                            break;
                        }
                    }
                }
                else if(choice == "3")
                {
                    vendingMachine.FinishTransaction();                    
                    break;
                }
            }
        }

        private void DisplayPurchaseMenu(VendingMachine.VendingMachine vm, string choice)
        {
            Console.Clear();
            Console.WriteLine("Purchasing Process Menu");
            Console.WriteLine("1. Feed Money");
            Console.WriteLine("2. Select Product");
            Console.WriteLine("3. Finish Transaction");
            Console.WriteLine($"Current money provided: {vm.CurrentBalance:C2}");
            Console.WriteLine($"Pick One: {choice}");

        }
    }
}
