using System;
using System.Collections.Generic;
using System.Text;

namespace Snowman
{
    public class Dictionary
    {
        public string word { get; set; }
        public Definition[] definitions { get; set; }
    }

    public class Definition
    {
        public string definition { get; set; }
        public string partOfSpeech { get; set; }
    }

    
}
