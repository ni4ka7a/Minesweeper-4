﻿namespace Minesweeper.Menu
{
    using System;

    public class MainMenu
    {
       internal static void PrintMenu()
        {
            string[] menuItems = new string[Enum.GetNames(typeof(MainMenuOptions)).Length];
            var indexer = 0;
            foreach (MainMenuOptions option in Enum.GetValues(typeof(MainMenuOptions)))
            {
                menuItems[indexer] = option.ToString();
                indexer++;
            }

            Console.WriteLine("\n\n");
            int indexForPrint = (CustomizeConsole.Width / 2) - ("MAIN MENU:".Length / 2);
            Console.SetCursorPosition(indexForPrint, 9);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("MAIN MENU:");

            Console.ForegroundColor = ConsoleColor.Green;

            Navigation.MainMenuNavigation(menuItems);
        }
    }
}
