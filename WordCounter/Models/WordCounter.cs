using System;
namespace WordCounter.Models
{
    public class WordCount
    {
        public string Sentence { get; set; }
        public string UserWord { get; set; }
        public int MatchCount { get; set; } = 0;
        
    
        public WordCount(string sentence, string userWord, int count)
        {
            Sentence = sentence;
            UserWord = userWord;
        }

       public int SetCounter()
        {
            return MatchCount;
        }

        public string GetSentence()
        {
            return Sentence;
        }

        public string GetWord()
        {
            return UserWord;
        }

        public int WordMatch()
        {
            string[] wordArray = Sentence.Split(" ");
          
            for (int index = 0; index < wordArray.Length; index++)
            if(UserWord = wordArray[index])
            return MatchCount++
        }
    }
}