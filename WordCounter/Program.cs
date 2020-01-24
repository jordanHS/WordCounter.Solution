using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the Word Counter!");
            Console.WriteLine("Please enter a sentence.");  
            string sentence = Console.ReadLine();
            Console.WriteLine("Now enter a word to count.");
            string userWord =Console.ReadLine();
            WordCount yourCount = new WordCount(sentence, userWord, 0);
            yourCount.WordMatch();
            Console.WriteLine("The word '{0}' appears {1} times in that sentence", yourCount.UserWord, yourCount.MatchCount);
        }
    }
}