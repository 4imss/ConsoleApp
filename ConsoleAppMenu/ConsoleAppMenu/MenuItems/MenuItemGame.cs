namespace ConsoleAppMenu.MenuItems
{
    using System;
    using System.Linq;

    internal class MenuItemGame : IMenuItem
    {
        /// <summary>
        ///     Title you see in the menu.
        /// </summary>
        public string Title => "Hangman";
        public void Execute()
        {
            // One of these words randomly gets picked for the user to guess. 
            Console.WriteLine("Hangman is waiting for you...\n");
            string[] listwords = new string[10];
            listwords[0] = "anonymous";
            listwords[1] = "outlast";
            listwords[2] = "hacker";
            listwords[3] = "undertaker";
            listwords[4] = "morgue";
            listwords[5] = "cemetery";
            listwords[6] = "darkweb";
            listwords[7] = "sinister";
            listwords[8] = "watching";
            listwords[9] = "funeral";
            // Returns a random listword, which is connected to a number.
            Random randGen = new Random();
            var idx = randGen.Next(0, 9);
            // Put the random listword into "mysteryWord".
            string mysteryWord = listwords[idx];
            // Counts the length of the mysteryWord and puts it into an array, into "guess".
            char[] guess = new char[mysteryWord.Length];
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Try to guess if you dare...\n\n");
            Console.ResetColor();
            // For loop displays the length of the mysteryWord into "*".
            for (int p = 0; p < mysteryWord.Length; p++)
                guess[p] = '*';
            // Make an integer that starts at 0.
            int attempts = 0; 
            // While loop that's keeps looping trough the code. 
            while (true)
            {
                // Puts the inputted letter into the variable the playerGuess.
                char playerGuess = char.Parse(Console.ReadKey().KeyChar.ToString());
                for (int j = 0; j < mysteryWord.Length; j++)
                {
                    // Compares user inputted letter to the mysteryWord to see if it's used in the mysteryWord.
                    if (playerGuess == mysteryWord[j])
                    {
                        guess[j] = playerGuess;
                    }
                }
                Console.WriteLine("\n");
                Console.WriteLine(guess);
                char star = '*';
                // Counts remaining hidden letters.
                int unGuessedLetterCount = guess.Count(s => s == star);
                if (unGuessedLetterCount < 1)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\nYou have Won! Press any key to return to the main menu");
                    Console.ResetColor();
                    break;
                }
                // Restricts attempts to 10 tries.
                if (attempts == 9)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    // The hangman
                    Console.WriteLine("\nYou're hanging " + MenuItemAddName.OutName() + "\n\n  +---+\n  |   |\n  O   |\n /|\\  |\n / \\  |\n      |\n=========]\n\n");
                    Console.ResetColor();
                    Console.WriteLine("Press any key to go back.");
                    break;
                }
                // Loop the tries till the restrict is met.
                attempts++;
            }
        }
    }
}