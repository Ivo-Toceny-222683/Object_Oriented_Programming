using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV4_StringStatistics
{
    public class StringStatistics
    {
        private string Text;

        public StringStatistics(string input)
        {
            Text = input;
        }

        private string[] TrimTextByWords(string text, StringBuilder smooth)
        {
            int index = 0;

            string[] LongWords = { };

            while (index < Text.Length)
            {
                if (Text[index] == ' ' || char.IsLetter(text[index]))
                {
                    smooth.Append(Text[index]);
                }
                else
                {
                    smooth.Append(' ');
                }
                index++;
            }

            return smooth.ToString().Split(' ');
        }
        // Solution inspired from Stackoverflow
        public int WordsCount()
        {
            int count = 0;
            int index = 0;

            while (index < Text.Length && char.IsWhiteSpace(Text[index]))
            {
                index++;
            }

            while (index < Text.Length)
            {
                while (index < Text.Length && !char.IsWhiteSpace(Text[index]))
                {
                    index++;
                }

                count++;

                while (index < Text.Length && char.IsWhiteSpace(Text[index]))
                {
                    index++;
                }
            }
            return count;
        }

        public int RowsCount()
        {
            int count = 1;
            char end = '\n';
            int index = 0;

            while (index < Text.Length && char.IsWhiteSpace(Text[index]))
            {
                index++;
            }

            if (index == Text.Length)
            {
                return 0;
            }

            while (index < Text.Length)
            {
                if (Text[index] == end)
                {
                    count++;
                }
                index++;
            }

            return count;
        }

        /* Iterating between whitespaces and chars to find interpunctions and check uppers for start of the sentences*/
        public int SentencesCount()
        {
            int count = 0;
            int index = 0;
            int resetIndex = 0;
            bool startOfSent = false;

            while (index < Text.Length && char.IsWhiteSpace(Text[index]))
            {
                index++;
            }

            if (index + 1 == Text.Length)
            {
                return 0;
            }

            while (index < Text.Length)
            {
                while (index < Text.Length && !char.IsWhiteSpace(Text[index]))
                {
                    if (resetIndex == 0 && !char.IsUpper(Text[index]) && !startOfSent)   // check if its just after shortage dot, if yes, dont count as an end of sentence
                    {
                        startOfSent = true;
                    }

                    if (resetIndex == 0 && char.IsUpper(Text[index]) && !startOfSent) // if there was an interpunction and next char is upper (excluding commas)
                    {
                        count++;
                        startOfSent = true;
                    }

                    if ((Text[index] == '.' || Text[index] == '!' || Text[index] == '?') && startOfSent)
                    {
                        startOfSent = false;
                    }
                    resetIndex++;
                    index++;
                }

                resetIndex = 0;

                while (index < Text.Length && char.IsWhiteSpace(Text[index]))
                {
                    index++;
                }
            }
            return count;
        }

        /* 1. Iterate through whole text and get rid of everything except spaces and letters
         * 2. Make array by splitting iterated text by spaces to have just words
         * 3. Iterate through words and add to string if it has the same lenght as temporary longest, if its longer, clear string and add to string
         * 4. Again split text by spaces to get the longest words and return array
         */
        public string[] LongestWords()
        {
            int max = 0;
            StringBuilder smooth = new StringBuilder();
            string[] words = TrimTextByWords(Text, smooth);

            foreach (string str in words)
            {
                if (str.Length == max)
                {
                    smooth.Append(str + " ");
                }

                if (str.Length > max)
                {
                    max = str.Length;
                    smooth.Clear();
                    smooth.Append(str + " ");
                }
            }

            return smooth.ToString().Split(' ');
        }

        public string[] ShortestWords()
        {
            int min = int.MaxValue;
            StringBuilder smooth = new StringBuilder();
            string[] words = TrimTextByWords(Text, smooth);

            foreach (string str in words)
            {
                if (str.Length == 0)
                {
                    continue;
                }

                if (str.Length == min)
                {
                    smooth.Append(str + " ");
                }

                if (str.Length < min)
                {
                    min = str.Length;
                    smooth.Clear();
                    smooth.Append(str + " ");
                }
            }

            return smooth.ToString().Split(' ');
        }

        public string[] CountestWords()
        {
            int max = 0;
            Dictionary<string, int> uniqueWords = new Dictionary<string, int>();
            StringBuilder smooth = new StringBuilder();
            string[] words = TrimTextByWords(Text, smooth);

            foreach (string str in words)
            {
                if (str.Length == 0)
                {
                    continue;
                }
                if (uniqueWords.ContainsKey(str))
                {
                    uniqueWords[str]++;

                    max = (uniqueWords[str] > max) ? uniqueWords[str] : max;
                }
                else
                {
                    uniqueWords[str] = 1;
                }
            }

            smooth.Clear();
            foreach(KeyValuePair<string, int> final in uniqueWords)
            {
                if(final.Value == max)
                {
                    smooth.Append(final.Key + " ");
                }
            }

            return smooth.ToString().Split();
        }

        public string[] SortedArray()
        {
            StringBuilder smooth = new StringBuilder();
            string[] words = TrimTextByWords(Text, smooth);
            Array.Sort(words);

            return words;
        }
    }
}
