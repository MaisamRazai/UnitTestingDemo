using System;
using System.Collections.Generic;
using System.Text;

namespace tdddemoapp
{
    
    public class TextAnalyzer
    {
        public int GetTotalWordCount(string text)
        {
            int wordCount = 0, index = 0;

            while (index < text.Length)
            {
                while (index < text.Length && !char.IsWhiteSpace(text[index]))
                    index++;
                wordCount++;

                while (index < text.Length && char.IsWhiteSpace(text[index]))
                    index++;
            }
            return wordCount;
        }

    }
}
