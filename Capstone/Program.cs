using Capstone.CLIs;
using System;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine.VendingMachine vendingMachine = new VendingMachine.VendingMachine();
            MainMenuCLI menu = new MainMenuCLI();
            menu.Run(vendingMachine);
        }
    }
}
