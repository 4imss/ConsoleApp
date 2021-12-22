namespace ConsoleAppMenu.MenuItems
{
    using System;
    using ConsoleAppMenu;

    /// <summary>
    /// Calculator menu item.
    /// </summary>
    internal class MenuItemAddNumbers : IMenuItem
    {
        /// <summary>
        /// The name of the menu item.
        /// </summary>
        public string Title => "Calculator";

        /// <summary>
        /// Perform a calculation.
        /// </summary>
        public void Execute()
        {
            while (true)
            {
                // Select first number given by user.
                Console.WriteLine("Select your first number");
                if (float.TryParse(Console.ReadLine(), out float result1) == false)
                {
                    Console.Clear();
                    Console.WriteLine("Please select a number");
                    continue;
                }

                // Choose what method you want to use with the numbers.
                Console.WriteLine("Please select a method: \n 1 = sum up \n 2 = subtract \n 3 = mulitply \n 4 = divide");
                if (int.TryParse(Console.ReadKey().KeyChar.ToString(), out var method) == false)
                {
                    Console.Clear();
                    Console.WriteLine("Please select a number");
                    continue;
                }

                // Check for a proper method.
                if (method == 1 || method == 2 || method == 3 || method == 4) { }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Please select one of the given symbols");
                    continue;
                }
                // Select 2nd number given by users.
                Console.WriteLine("\nSelect your 2nd number");
                if (float.TryParse(Console.ReadLine(), out float result2) == false)
                {
                    Console.Clear();
                    Console.WriteLine("Please select a number");
                    continue;
                }

                string method1 = "";
                float result3 = 0;
                // Select method and use it with result1 and result2.
                switch (method)
                {
                    case 1:
                        result3 = result1 + result2;
                        method1 = "+";
                        break;
                    case 2:
                        result3 = result1 - result2;
                        method1 = "-";
                        break;
                    case 3:
                        result3 = result1 * result2;
                        method1 = "*";
                        break;
                    case 4:
                        result3 = result1 / result2;
                        method1 = "/";
                        break;
                }

                // Display answer and break from the while loop.
                Console.Clear();
                Console.WriteLine("result: \n" + result1 + " " + method1 + " " + result2 + " = " + result3);
                break;
            }
        }
    }
}