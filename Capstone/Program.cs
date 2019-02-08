using Capstone.CLIs;
using System;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            // Displays the main menu
            Capstone.VendingMachine.VendingMachine vendingMachine;
            MainMenuCLI menu = new MainMenuCLI();
            menu.Run();
        }
    }
}
