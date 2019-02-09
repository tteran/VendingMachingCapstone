using Capstone.VMComponents;
using DeliveryApp.CLIs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Capstone.CLIs
{
    /// <summary>
    /// Represents a PurchaseMenuCLI.
    /// </summary>
    class PurchaseMenuCLI : CLI
    {
        /// <summary>
        /// Runs the Purchase Menu display.
        /// </summary>
        /// <param name="vendingMachine">Vending machine passed in.</param>
        public override void Run(VendingMachine vendingMachine)
        {
            Log log = new Log();
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Purchasing Process Menu");
                Console.WriteLine("1. Feed Money");
                Console.WriteLine("2. Select Product");
                Console.WriteLine("3. Finish Transaction");
                Console.Write($"Current money provided: {vendingMachine.CurrentBalance:C2}\n");
                string choice = GetString("Pick One: ");

                if(choice == "1")
                {
                    while(true)
                    {
                        string userinput = GetString("Please enter amount: ");
                        if (int.TryParse(userinput, out int dollarsPutIn))
                        {
                            // Updates Current money provided as money is feed after each input.
                            vendingMachine.FeedMoney(dollarsPutIn);
                            //LogEntry entry = new LogEntry("FEED MONEY: ", dollarsPutIn, vendingMachine.CurrentBalance);

                            //log.AddLogEntry(entry);

                            //DisplayPurchaseMenu(vendingMachine, choice);

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

                        vendingMachine.Buy(slotCode);
                        DisplayPurchaseMenu(vendingMachine, choice);
                        string yesno = GetString("Would you like to buy something else (y/n)?");

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

        /// <summary>
        /// Displays the console menu.
        /// </summary>
        /// <param name="vm"></param>
        /// <param name="choice"></param>
        private void DisplayPurchaseMenu(VendingMachine vm, string choice)
        {
            Console.Clear();
            Console.WriteLine("Purchasing Process Menu");
            Console.WriteLine("1. Feed Money");
            Console.WriteLine("2. Select Product");
            Console.WriteLine("3. Finish Transaction");
            Console.WriteLine($"Current money provided: {vm.CurrentBalance:C2}");
            Console.WriteLine($"Pick One:  {choice}");
        }
    }
}
