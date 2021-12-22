namespace ConsoleAppMenu.MenuItems
{
    using System;
    internal class MenuItemAddName : IMenuItem
    {
        /// <summary>
        ///     Title you see in the menu.
        /// </summary>
        public string Title => "Add your name";

        private static string _savedName;
        public void Execute()
        {
            // Add a name
            Console.WriteLine("\nInput name:\n");
            string tempName = Console.ReadLine();

            // Create a string and store in variable
            string name = tempName;
            // Make text Green and resets when you exit the menu.
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("\n" + name + " Has been found...");
            Console.ResetColor();
            Console.WriteLine("\nPress any key to exit");
            _savedName = name;
        }
        /// <summary>
        ///     Return the saved name.
        /// </summary>
        public static string OutName()
        {
            return _savedName;
        }
    }
}