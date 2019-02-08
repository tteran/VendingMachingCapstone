using Capstone.CLIs;
using System;
using Capstone.VMComponents;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            VendingMachine vendingMachine = new VendingMachine();
            MainMenuCLI menu = new MainMenuCLI();
            menu.Run(vendingMachine);
        }
    }
}
