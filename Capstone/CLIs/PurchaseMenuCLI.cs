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

                            string yesno = GetString("Would you like to add more money (y/n)?");
                            
                            if(yesno.ToLower().StartsWith('n'))
                            {
                                break;
                            }
                            Console.SetCursorPosition(0, 6);
                            ClearCurrentConsoleLine();
                        }
                        else
                        {
                            Console.WriteLine("Not a vaild amount, tender must be numeric (1, 2, etc.).");
                            Console.SetCursorPosition(0, 6);
                            ClearCurrentConsoleLine();
                        }
                    }
                }

                else if(choice == "2")
                {
                    while (true)
                    {
                        string slotCode = GetString("Please enter a slot code: ");

                        vendingMachine.Buy(slotCode);
                        string yesno = GetString("Would you like to buy something else (y/n)?");

                        if (yesno.ToLower().StartsWith('n'))
                        {
                            break;
                        }
                        Console.SetCursorPosition(0, 6);
                        ClearCurrentConsoleLine();
                    }
                }
                else if(choice == "3")
                {
                    vendingMachine.FinishTransaction();                    
                    break;
                }
            }
        }
    }
}
