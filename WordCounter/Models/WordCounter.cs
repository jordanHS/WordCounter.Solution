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

        public int WordMatch()
        {
            string[] WordArray = Sentence.Split(" ");
            
            for(int index = 0; index < WordArray.Length; index++)
            {
                if( UserWord == WordArray[index])
                {
                    MatchCount++;
                }
            }
            return MatchCount;
        }
    }
}
