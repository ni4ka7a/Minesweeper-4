﻿using Minesweeper.Engine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Menu
{
    class MenuOrientation
    {
        private static int currentChoice = 0;

        internal static int HorizontalOfMenus(MinesweeperEngine game, Enum e)
        {
            string[] secMenuItems = new string[Enum.GetNames(e.GetType()).Length];
            var indexer = 0;
            foreach (var option in Enum.GetValues(e.GetType()))
            {
                secMenuItems[indexer] = option.ToString();
                indexer++;
            }

            while (true)
            {
                for (int i = 0; i < secMenuItems.Length; i++)
                {
                    if (currentChoice == i)
                    {
                        if (Console.BackgroundColor == ConsoleColor.White)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                    }
                    else
                    {
                        if (Console.BackgroundColor == ConsoleColor.White)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                    }

                    Console.SetCursorPosition(25 + (10 * i), 27);
                    Console.WriteLine(secMenuItems[i]);
                }

                if (Console.KeyAvailable)
                {
                    for (int i = 0; i < secMenuItems.Length; i++)
                    {
                        if (currentChoice == i)
                        {
                            if (Console.BackgroundColor == ConsoleColor.White)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                        }
                        else
                        {
                            if (Console.BackgroundColor == ConsoleColor.White)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGray;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                        }

                        Console.SetCursorPosition(25 + (10 * i), 27);
                        Console.WriteLine(secMenuItems[i]);
                    }

                    ConsoleKeyInfo pressedKey = Console.ReadKey();
                    if (pressedKey.Key == ConsoleKey.LeftArrow)
                    {
                        currentChoice = (currentChoice - 1 + secMenuItems.Length) % secMenuItems.Length;
                    }

                    if (pressedKey.Key == ConsoleKey.RightArrow)
                    {
                        currentChoice = (currentChoice + 1) % secMenuItems.Length;
                    }

                    if (pressedKey.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            }
            return currentChoice;
        }

        internal static int VerticalOrientation(MinesweeperEngine game, Enum e)
        {
            string[] menuItems = new string[Enum.GetNames(e.GetType()).Length];
            var indexer = 0;
            foreach (var option in Enum.GetValues(e.GetType()))
            {
                menuItems[indexer] = option.ToString();
                indexer++;
            }

            while (true)
            {
                for (int i = 0; i < menuItems.Length; i++)
                {
                    Console.SetCursorPosition((CustomizeConsole.Width / 2) - (menuItems[i].Length / 2), 10 + i + 1);
                    if (currentChoice == i)
                    {
                        if (Console.BackgroundColor == ConsoleColor.White)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                    }
                    else
                    {
                        if (Console.BackgroundColor == ConsoleColor.White)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGray;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                    }

                    Console.WriteLine(menuItems[i]);
                }

                if (Console.KeyAvailable)
                {
                    for (int i = 0; i < menuItems.Length; i++)
                    {
                        Console.SetCursorPosition((CustomizeConsole.Width / 2) - (menuItems[i].Length / 2), 10 + i + 1);
                        if (currentChoice == i)
                        {
                            if (Console.BackgroundColor == ConsoleColor.White)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                        }
                        else
                        {
                           if(Console.BackgroundColor == ConsoleColor.White)
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                        }

                        Console.WriteLine(menuItems[i]);
                    }

                    ConsoleKeyInfo choice = Console.ReadKey();
                    if (choice.Key == ConsoleKey.DownArrow)
                    {
                        currentChoice = (currentChoice + 1) % menuItems.Length;
                    }

                    if (choice.Key == ConsoleKey.UpArrow)
                    {
                        currentChoice = (currentChoice - 1 + menuItems.Length) % menuItems.Length;
                    }

                    if (choice.Key == ConsoleKey.Enter)
                    {
                        break;
                    }
                }
            }
            return currentChoice;
        }
    }
}