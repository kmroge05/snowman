using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Snowman
{
    class GamePlay
    {

        // Welcome player and ask for their name
        public void StartGame()
        {
            Console.WriteLine("Welcome to SNOWMAN! \n\nThe politically correct variation of Hangman. \n\nKnow how to play? (Y/N)");

            bool incorrect = true;   
            while (incorrect)
            {
                string howToPlay = Console.ReadLine().ToUpper();

                if (howToPlay == "N")
                {
                    Console.WriteLine("That's okay! Snow man is a simple guessing game. \nYou will be given a random word to guess. You will be allowed to guess 1 letter of the word at a time. \nIf you cannot guess the word in 10 guesses, you lose. If you guess the word before 10 wrong guesses, YOU WIN! \nSimple Right? LET'S PLAY!");
                    incorrect = false;
                }
                if (howToPlay == "Y")
                {
                    Console.WriteLine("Great! Let's Play!");
                    incorrect = false;
                }
                else
                {
                    Console.WriteLine("Please answer Y for Yes, or N for No.");
                }
            }
        }


        public void Playing()
        {
            // Randomly select phrase from WordsToGuess Class
            Random random = new Random();
            WordsToGuess thisWord = new WordsToGuess(random.Next(30));
            Console.WriteLine(thisWord.GameWord);
        }

        // Print Category and blanked-out title

        // Ask for guess
        // If guess is right, display title with letters filled in
        // If guess is wrong, displays portion of Snowman, and adds to number of wrong guesses
        // Repeats until 9 wrong guesses or puzzle is solved
        // Congratulate player is puzzle is solved OR Apolgize if player fails

        // Allow player to exit game by typing quit at any time.
    }
}
