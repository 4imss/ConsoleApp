namespace ConsoleAppMenu.MenuItems
{
    using System;
    internal class MenuItemViewName : IMenuItem
    {
        /// <summary>
        ///     Title you see in the menu.
        /// </summary>
        public string Title => "We know who you are";
        public void Execute()
        {
            Console.Clear();

            // Calls upon function "Outname()" to view saved name.
            if (string.IsNullOrEmpty(MenuItemAddName.OutName()))
            {
                // Make text Green and resets when you exit the menu.
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n You rather stay anonymous... alright keep your secrets");
                Console.ResetColor();
            }
            else
            {
                // Make text Green and resets when you exit the menu.
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n We know who you are, " + MenuItemAddName.OutName() + "...\n");
                Console.ResetColor();

                for (int i = 3; i > 0; i--)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Initializing hacking sequence in " + i + " seconds.");
                    System.Threading.Thread.Sleep(1000);
                    if (i == 1)
                    {
                        // Mooi he, Rudy
                        Console.WriteLine("\n _______                      _____ __ \n" +
                                             "|__   __|                    / ____/_ | \n" +
                                                 "   | | ___  __ _ _ __ ___   | |     | | \n" +
                                                 "   | |/ _ \\/ _` | '_ ` _ \\  | |     | |\n" +
                                                 "   | |  __/ (_| | | | | | | | |____ | | \n" +
                                                 "   |_|\\___|\\__,_|_| |_| |_|  \\_____||_|");
                        Console.ResetColor();
                        Console.WriteLine("\nPress any key to exit");
                    }
                }
            }
        }
    }
}