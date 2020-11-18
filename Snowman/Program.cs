using System;
using System.Collections.Generic;

namespace Snowman
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introduces the game and provides instructions if needed. 
            Console.WriteLine("Welcome to SNOWMAN! \n\nThink Hangman, but with snowmen instead. \n\nLet's play!\n\n\n\n\n");

            // Game Loop 
            do
            {
                string playAgain = "";

                // Instantiates classes
                GamePlay currentGame = GamePlay.Playing;
                GuessValidation validateGuess = new GuessValidation();
                SnowmanBuilder buildSnowman = new SnowmanBuilder();

                // Randomly selects phrase from WordsToGuess Class
                Random random = new Random();
                WordsToGuess thisWord = new WordsToGuess(random.Next(30));

                // Converts the current word into a charatcter array and adds each character to a List of type DisplayLetter
                char[] currentArray = thisWord.GameWord.ToCharArray();
                List<DisplayLetter> secretLetters = new List<DisplayLetter>();

                foreach (char letter in currentArray)
                {
                    DisplayLetter character = new DisplayLetter(letter);
                    secretLetters.Add(character);
                }
                
                // Displays the word as underscores, takes player input for guesses (and validates)
                // Cycles through until the word is guessed or the player has guessed incorrectly 10 times
                do
                {
                    foreach (DisplayLetter item in secretLetters)
                    {
                        item.DisplayCharacters(item);
                    }

                    Console.WriteLine();

                    validateGuess.DisplayGuesses();
                    validateGuess.ValidateGuess(secretLetters, buildSnowman);
                    Console.WriteLine(buildSnowman.SnowMan);

                    if (validateGuess.Correct == currentArray.Length)
                    {
                        foreach (DisplayLetter letter in secretLetters)
                        {
                            letter.DisplayCharacters(letter);
                        }

                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();

                        Console.WriteLine("Winner, winner!");
                        currentGame = GamePlay.Won;
                    }

                    if (validateGuess.Incorrect == 10)
                    {
                        Console.WriteLine($"Sorry, Loser! The word was: {thisWord.GameWord}");
                        currentGame = GamePlay.GameOver;
                    }

                    // Asks if player wants to learn the definition of the word then calls WordAPI to display the definition.
                    //Console.WriteLine("Want to learn the definition of this word?");
                    //string Learn = Console.ReadLine().ToUpper();

                    //do
                    //{ 
                    //    if (Learn == "Y")
                    //    {
                    //        Console.WriteLine("Cool, right?");
                    //        break;
                    //    }
                    //    else 
                    //    {
                    //        break;
                    //    }
                    //} while (true);

                } while (currentGame == GamePlay.Playing);

                // Asks if player wants to play again
                do
                {
                    Console.WriteLine("Wanna play again? (Y/N)");
                    ConsoleKeyInfo again = Console.ReadKey();
                    playAgain = again.Key.ToString();

                    if (playAgain != "Y" && playAgain != "N")
                    {
                        Console.WriteLine("Sorry! You must enter Y for Yes or N for No.");
                        continue;
                    }
                    else
                    {
                        break;
                    }
                } while (true);

                if (playAgain == "Y")
                {
                    Console.WriteLine();
                    continue;
                }
                else
                {
                    break;
                }
            } while (true);
        }

        enum GamePlay 
        { 
            Playing, 
            Won,
            GameOver
        };
    }
}
