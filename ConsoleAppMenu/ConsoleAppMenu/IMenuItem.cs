namespace ConsoleAppMenu
{
    /// <summary>
    ///     The interface for a menu item.
    /// </summary>
    internal interface IMenuItem
    {
        /// <summary>
        ///     The title of the menu item in the menu.
        /// </summary>
        string Title { get; }

        /// <summary>
        ///     Execute the task of the menu item.
        /// </summary>
        void Execute();
    }
}