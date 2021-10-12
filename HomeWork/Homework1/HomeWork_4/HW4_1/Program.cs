using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
namespace HW4_1
{
    class Program
    {
        public static int wordCount = 10500;
        public static char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        public static string[] wordsInArray = new string[wordCount];
        public static HashSet<String> wordsInHashSet = new HashSet<string>();
        static void Main(string[] args)
        {
            for (int i = 0; i < wordCount; i++)
            {
                wordsInHashSet.Add(GenerateWord(5));
                wordsInArray[i] = (GenerateWord(5));
            }
            BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
        }
        public class BechmarkClass
        {
            string stringForSearching = GenerateWord(lettersInWord: 5);

            [Benchmark]
            public bool SearchWordInHash()
            {
                return wordsInHashSet.Contains(stringForSearching);
            }

            [Benchmark]
            public bool SearchWordInArray()
            {
                return wordsInArray.Any(n => n == stringForSearching);
            }
        }
        public static string GenerateWord(int lettersInWord)
        {
            char[] letters = "QWERTASDFGZXCVBYUIOPHJKLNMqwertasdfgzxcvbyuiophjklnm".ToCharArray();

            Random random = new Random();

            string word = "";
            for (int j = 1; j < lettersInWord; j++)
            {
                int LetterIndex = random.Next(0, letters.Length);

                word += letters[LetterIndex];
            }
            return word;
        }
    }
}
