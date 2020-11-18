using System;
using System.Collections.Generic;
using System.Linq;


namespace Snowman
{
    class GuessValidation
    {
        List<char> guesses = new List<char>();

        private int _correct = 0;
        public int Correct
        {
            get { return _correct; }
            set { _correct = value; }
        }
        private int _incorrect = 0;
        public int Incorrect
        {
            get { return _incorrect; }
            set { _incorrect = value; }
        }

        public void ValidateGuess(List<DisplayLetter> displayLetters, SnowmanBuilder build)
        {
            bool correctGuess = false;
            bool validInput = false;
            char guess;

            // Asks for input, makes sure it is valid, and counts the guessed letters
            Console.WriteLine("Please guess a letter: ");
            do
            {
                int validatedLetters = 0;

                ConsoleKeyInfo input = Console.ReadKey();
                string key = input.Key.ToString();
                guess = key[0];
                Console.WriteLine();

                foreach (char letter in guesses)
                {
                    if (letter == char.ToUpper(guess))
                    {
                        Console.WriteLine($"Oops! You already guessed {guess}. Please guess another letter: ");
                    }
                    else
                    {
                        validatedLetters++;
                    }
                }

                if (validatedLetters == guesses.Count())
                {
                    validInput = true;
                }
            } while (validInput == false);

            Console.WriteLine();

            // Compares guessed letters to the current game's word
            foreach (DisplayLetter item in displayLetters)
            {
                if (item.Letter == char.ToUpper(guess) && item.Guessed == false)
                {
                    item.Guessed = true;
                    correctGuess = true;
                    this.Correct++;
                }
            }

            if (correctGuess)
            {
                Console.WriteLine("That's a correct guess!");
            }
            else
            {
                this.Incorrect++;
                Console.WriteLine("Sorry! That's an incorrect guess.");
                build.Build(this.Incorrect);
            }

            this.guesses.Add(guess);
            Console.WriteLine();
        }

        // Displays letters previously guessed
        public void DisplayGuesses()
        {
            Console.Write("Guesses: ");

            foreach (char letter in guesses)
            {
                Console.Write($"{letter} ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
