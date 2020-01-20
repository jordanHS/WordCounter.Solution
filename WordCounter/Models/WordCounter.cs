using System;
namespace WordCounter.Models
{
    public class WordCount
    {
        public string Sentence { get; set; }
        public string UserWord { get; set; }
        public int Count { get; set; } = 0; 
        
    
        public WordCount(string sentence, string userWord)
        {
            Sentence = sentence;
            UserWord = userWord;
        }

       public int SetCounter()
        {
            return Count;
        }

        public string GetSentence()
        {
            return Sentence;
        }

        public string GetWord()
        {
            return UserWord;
        }
    
        public int CountWord()
        {
            string [] WordArray = Sentence.Split(" ");
            foreach (string word in WordArray)
            {
                if( UserWord = WordArray);
                {
                return Count++;
                }
            }
        }
    }
}