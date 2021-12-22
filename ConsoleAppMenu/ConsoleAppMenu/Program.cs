namespace ConsoleAppMenu
{
    using System;
    /// <summary>
    ///     The program class for the startup of the application.
    /// </summary>
    internal class Program
    {
        private static readonly Menu Menu = new Menu();

        /// <summary>
        ///     The main function of the program.
        /// </summary>
        private static void Main()
        {
            // While the ShowMenu is returning true the menu is show again.
            while (true)
            {
                // Shows the menu.
                Menu.ShowMenu();

                // Ever time after showing the menu, the screen in cleared.
                Console.Clear();
            }
            // ReSharper disable once FunctionNeverReturns
        }
    }
}