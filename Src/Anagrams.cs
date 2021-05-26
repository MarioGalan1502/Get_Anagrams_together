using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.IO;

namespace dummy_anagrams.Src
{
    public class Anagrams
    {
        public Dictionary<string, List<string>> anagrams;
        public string longest_key = "";
        public List<string> longests_set = new List<string>();
        public List<string> longests_words = new List<string>();
        public int anagrams_sets_quantity = 0;
        public int anagram_words_count = 0;

        public Anagrams(Hashing dic)
        {
            anagrams = dic.anagrams;
        }
        public void Print(TextWriter sw)
        {
            foreach (var set in anagrams)
            {
                anagram_words_count += set.Value.Count;
                anagrams_sets_quantity++;
                sw.WriteLine(string.Join(", ", set.Value));

                if (set.Key.Length > longest_key.Length)
                    longest_key = set.Key;

                if (set.Value.Count > longests_set.Count)
                    longests_set = set.Value;
            }
            longests_words = anagrams[longest_key];
        }

    }
}

