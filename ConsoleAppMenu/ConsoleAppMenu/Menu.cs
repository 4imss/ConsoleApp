namespace ConsoleAppMenu
{
    using System;
    using MenuItems;
    /// <summary>
    ///     The menu.
    /// </summary>
    internal class Menu
    {
        /// <summary>
        ///     The menu items.
        /// </summary>
        private IMenuItem[] _menuItems;

        /// <summary>
        ///     Initializes a new instance of the Menu class.
        /// </summary>
        public Menu()
        {
            // Initializes the menu items attribute.
            _menuItems = new IMenuItem[]
            {
                // The name menu.
                new MenuItemAddName(),

                // The name view menu.
                new MenuItemViewName(),

                // The add numbers menu.
                new MenuItemAddNumbers(),

                // The specs menu.
                new MenuItemSpecs(),

                // The game menu.
                new MenuItemGame(),

                // The quit menu.
                new MenuItemQuit()
            };
        }

        /// <summary>
        /// Show the menu.
        /// </summary>
        public void ShowMenu()
        {
            // 1. Shows the menu
            Console.WriteLine("\n\n                                            _______                      _____ __ \n" +
                              "                                           |__   __|                    / ____/_ | \n" +
                              "                                              | | ___  __ _ _ __ ___   | |     | | \n" +
                              "                                              | |/ _ \\/ _` | '_ ` _ \\  | |     | |\n" +
                              "                                              | |  __/ (_| | | | | | | | |____ | | \n" +
                              "                                              |_|\\___|\\__,_|_| |_| |_|  \\_____||_|\n\n\n\n\n");
            for (var i = 0; i < _menuItems.Length; i++)
            {
                Console.WriteLine("                                                     {0}: {1}", (i), _menuItems[i].Title);
            }

            // 2. Waits for input from user. Parse it to an integer
            var keyEntered = Console.ReadKey().KeyChar.ToString();
            int menuNumber;
            if (int.TryParse(keyEntered, out menuNumber) == false)
            {
                Console.WriteLine("That number has no menu item");
                Console.ReadKey();
                return;
            }

            Console.Clear();

            // 3. Finding the right menu item and execute it.
            if (menuNumber < _menuItems.Length)
            {
                _menuItems[(menuNumber)].Execute();
            }
            else
            {
                // 4. Show that no such menu options exist
                Console.WriteLine("That number has no menu item");
            }

            Console.ReadKey();
        }
    }
}