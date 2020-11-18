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

            private char _letter;
            public char Letter
            {
                get { return _letter; }
                set { _letter = value; }
            }

            private bool _guessed = false;   
            public bool Guessed
            {
                get { return _guessed; }
                set { _guessed = value; }
            }
           
            // Displays letter or underscore depending on a correct or incorrect guess
            public void DisplayCharacters(DisplayLetter character)
            {
                if (_guessed == true)
                {
                    Console.Write(character._letter + " ");
                }
                else
                {
                    Console.Write("_ ");
                }
            }
        
    }
}
