using Capstone.CLIs;
using System;

namespace Capstone
{
    class Program
    {
        static void Main(string[] args)
        {
            // Displays the main menu
            MainMenuCLI menu = new MainMenuCLI();
            menu.Run();
        }
    }
}
