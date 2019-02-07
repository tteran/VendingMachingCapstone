using Capstone.CLIs;
using Capstone.VendingMachine;
using System;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            // Displays the main menu
            VendingMachine vendingMachine;
            MainMenuCLI menu = new MainMenuCLI();
            menu.Run();
        }
    }
}
