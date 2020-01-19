namespace WordCounter.Models
{
    public class WordChecker
    {
        public string Sentence { get; set; }
    
        public WordChecker(string sentence)
        {
            Sentence = sentence;
        }


    }
}