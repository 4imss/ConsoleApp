namespace ConsoleAppMenu.MenuItems
{
    using System;

    /// <summary>
    /// The menu item to quit the program.
    /// </summary>
    internal class MenuItemQuit : IMenuItem
    {
        /// <summary>
        /// <inheritdoc cref="IMenuItem.Title"/>
        /// </summary>
        
        /// /// <summary>
        ///     Title you see in the menu.
        /// </summary>
        public string Title => "Quit";

        /// <summary>
        /// <inheritdoc cref="IMenuItem.Execute"/>
        /// </summary>
        public void Execute()
        {
            // Quit the program.
            Environment.Exit(0);
        }
    }
}