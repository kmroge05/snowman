using System;
using System.Collections.Generic;
using System.Text;

namespace Snowman
{
    class WordsToGuess
    {
        // Provides list of words for the game to pull from.
        public WordsToGuess(int wordPosition)
        {
            string[] WordList = new string[]
            {
                "MUTUAL",
                "REGARD",
                "FILTHY",
                "JUXTAPOSITION",
                "DESCENT",
                "HIGHLIGHT",
                "DISTURBANCE",
                "CREATION",
                "RAINBOW",
                "TROOP",
                "CAVALRY",
                "BRAIN",
                "GARAGE",
                "BANISH",
                "UNDERSTANDING",
                "ACCUMULATE",
                "CYLINDER",
                "EXPRESSION",
                "ALLOCATE",
                "WITHDRAWAL",
                "CELEBRATION",
                "LINEAGE",
                "DISCOURAGE",
                "CONVICTION",
                "REDUNDANT",
                "DISABILITY",
                "EXAGGERATE",
                "TEMPTATION",
                "COMPROMISE",
                "THOUGHTFUL",
            };

            gameWord = WordList[wordPosition];
        }

        private string gameWord;
        public string GameWord { get { return gameWord; } }
    }
}
