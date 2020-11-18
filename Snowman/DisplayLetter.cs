using System;
using System.Collections.Generic;
using System.Text;

namespace Snowman
{
    class DisplayLetter
    {
            public DisplayLetter(char letter)
            {
                Letter = letter;
            }

            private char letter;
            public char Letter
            {
                get { return letter; }
                set { letter = value; }
            }

            private bool guessed = false;
            public bool Guessed
            {
                get { return guessed; }
                set { guessed = value; }
            }

            public void DisplayCharacters(DisplayLetter character)
            {
                if (guessed == true)
                {
                    Console.Write(character.letter + " ");
                }
                else
                {
                    Console.Write("_ ");
                }
            }
        
    }
}
