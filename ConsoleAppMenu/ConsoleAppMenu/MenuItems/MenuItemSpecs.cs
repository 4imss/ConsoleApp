namespace ConsoleAppMenu.MenuItems
{
    using System;
    using System.Threading;

    internal class MenuItemSpecs : IMenuItem
    {
        /// <summary>
        ///     Title you see in the menu.
        /// </summary>
        public string Title => "PC information";

        public void Execute()
        {
            // View basic specs about your PC.
            Console.WriteLine("Windows version: {0}",
                Environment.OSVersion);
            Console.WriteLine("64 Bit operating system? : {0}",
                Environment.Is64BitOperatingSystem ? "Yes" : "No");
            Console.WriteLine("PC Name : {0}",
                Environment.MachineName);
            Console.WriteLine("Number of CPUS : {0}",
                Environment.ProcessorCount);
            Console.WriteLine("Windows folder : {0}",
                Environment.SystemDirectory);
            Console.WriteLine("Logical Drives Available : {0}",
                String.Join(", ", Environment.GetLogicalDrives())
                    .TrimEnd(',', ' ')
                    .Replace("\\", String.Empty));
            Console.ForegroundColor = ConsoleColor.Green;

            // Progress bar for fake installer.
            Console.WriteLine("\nInstalling malware\n");
            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"\rProgress: {i}%   ");
                Thread.Sleep(25);
            }
            Console.Write("\rThere is no going back now...         ");
            Console.ResetColor();
        }
    }
}