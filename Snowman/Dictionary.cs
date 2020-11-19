using System;
using System.Collections.Generic;
using System.Text;

namespace Snowman
{

    // Deserializes data from the WordsAPI dictionary API
    public class Dictionary
    {
        public string word { get; set; }
        public List<Definition> definitions { get; set; }
    }

    public class Definition
    {
        public string definition { get; set; }
        public string partOfSpeech { get; set; }
    }


}
