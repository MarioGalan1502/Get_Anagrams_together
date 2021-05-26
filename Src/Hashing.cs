using System;
using System.Collections.Generic;
using System.Linq;

namespace dummy_anagrams.Src
{
    public class Hashing
    {
        public Dictionary<string, List<string>> words = new Dictionary<string, List<string>>();
        public Dictionary<string, List<string>> anagrams = new Dictionary<string, List<string>>();

        public Hashing()
        {

        }

        public Hashing(string[] lines)
        {
            SortWords(lines);
        }

        private void SortWords(string[] lines)
        {
            for (int i = 0; i < lines.Length; i++)
            {
                string word = lines[i].ToLower();
                char[] characters = word.ToCharArray();
                Array.Sort(characters);
                string sorted_word = new string(characters);

                if (words.ContainsKey(sorted_word))
                {
                    if (!words[sorted_word].Contains(word))
                    {
                        words[sorted_word].Add(word);
                    }
                    if (words[sorted_word].Count > 1)
                    {
                        anagrams[sorted_word] = words[sorted_word];
                    }
                }
                else
                {
                    words.Add(sorted_word, new List<string>());
                    words[sorted_word].Add(word);
                }
            }
        }
    }
}