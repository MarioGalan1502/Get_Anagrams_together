using System.Collections.Generic;
using NUnit.Framework;
using System;
using dummy_anagrams.Src;
using System.IO;
using System.Diagnostics;
using System.Text;

namespace dummy_anagrams.Tests
{
    [TestFixture]
    public class AnagramTest
    {
        [Test]
        public void Print_Correct_Output()
        {
            StringBuilder sb = new StringBuilder();

            string[] words = new string[] { "CAt", "TcA", "cta", "bos", "obs", "sob", "water" };
            string[] anagrams_set = new string[] { "cat, tca, cta", "bos, obs, sob" };
            Hashing hashmap = new Hashing(words);
            Anagrams anagrams = new Anagrams(hashmap);

            TextWriter sw = new StringWriter();
            Console.SetOut(sw);

            anagrams.Print(sw);

            string output = sw.ToString();


            Assert.AreEqual(string.Join(Environment.NewLine, anagrams_set) + "\r\n", output);


        }

    }
}
