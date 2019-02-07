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
                string choice = GetString("Pick One: ");

                if(choice == "1")
                {

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
