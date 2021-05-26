using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace dummy_anagrams.Src
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1 || args.Length > 1)
            {
                throw new ArgumentException("Cantidad de argumentos erronea. format: {Katanagram.exe} {path to text file}");
            }

            Console.WindowWidth = 165;

            Stopwatch timer = new Stopwatch();
            timer.Start();
            Archivo file = new Archivo(args[0]);
            Hashing diccionary = new Hashing(file.get_array());
            Anagrams anagram = new Anagrams(diccionary);

            TextWriter sw = new StreamWriter(Console.OpenStandardOutput());
            Console.SetOut(sw);
            anagram.Print(sw);
            timer.Stop();


            Console.WriteLine();
            Console.WriteLine($"Cantidad de tiempo: {timer.Elapsed}");
            Console.WriteLine($"Cantidad de palabras en este archivo: {file.get_array().Length}");
            Console.WriteLine($"Cantidad de sets de anagramas: {anagram.anagrams_sets_quantity}");
            Console.WriteLine($"Cantidad de palabras con anagramas: {anagram.anagram_words_count}");

            Console.WriteLine($"Set de anagramas con mas palabras: {string.Join(", ", anagram.longests_set)} \nTamano: {anagram.longests_set.Count}");
            Console.WriteLine($"Set de anagramas con palabras mas largas: {string.Join(", ", anagram.longests_words)} \nTamano: {anagram.longest_key.Length}");

            sw.Flush();
            Console.ReadKey();


        }
    }
}
