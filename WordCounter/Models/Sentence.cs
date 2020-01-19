namespace WordCounter.Models
{
    public class Sentence
    {
        public str[] WordArray { get; set; }
    
        public Sentence(str[] words)
        {
            WordArray = words;
        }
    }
}