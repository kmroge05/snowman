using System;
using System.Collections.Generic;

namespace Snowman
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduces the game and provides instructions if needed. 
            Console.WriteLine("Welcome to SNOWMAN! \n\nThe politically correct variation of Hangman. \n\nKnow how to play? (Y/N)");

            bool incorrect = true;
            while (incorrect)
            {
                string howToPlay = Console.ReadLine().ToUpper();

                if (howToPlay == "N")
                {
                    Console.WriteLine("That's okay! Snow man is a simple guessing game. \nYou will be given a random word to guess. You will be allowed to guess 1 letter of the word at a time. \nOnce you have 10 incorrect guesses, you lose. If you guess the word before 10 wrong guesses, YOU WIN! \nSimple Right? LET'S PLAY!");
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

            // Game Loop (need to add loop for game)


            // Randomly selects phrase from WordsToGuess Class
            Random random = new Random();
            WordsToGuess thisWord = new WordsToGuess(random.Next(30));
            Console.WriteLine(thisWord.GameWord);

            // Converts the current word into a charatcter array and adds each character to a List of type DisplayLetter
            char[] currentArray = thisWord.GameWord.ToCharArray();
            List<DisplayLetter> secretLetters = new List<DisplayLetter>();

            foreach (char letter in currentArray)
            {
                DisplayLetter character = new DisplayLetter(letter);
                secretLetters.Add(character);
            }
            

        }

        enum Gameplay 
        { 
            Playing, 
            Won,
            GameOver
        };
    }
}
