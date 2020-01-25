using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCountTests
    {
        [TestMethod]
        public void WordCount_SetCounter_Zero()
        {
            WordCount newWordCount = new WordCount("The cat walked into the cathedral", "dog", 0);
            int result = newWordCount.SetCounter();
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void WordCount_GetSentence_CreateSentence()
        {
           WordCount newWordCount = new WordCount("The cat walked into the cathedral", "cat", 1);
           string result = newWordCount.GetSentence();
           Assert.AreEqual(result, "The cat walked into the cathedral");
        }

        [TestMethod]
        public void WordCount_GetWord_CreateWord()
        {
            WordCount newWordCount = new WordCount("The cat walked into the the cathedral", "cat", 1);
            string result = newWordCount.GetWord();
            Assert.AreEqual(result, "cat");
        }

        [TestMethod]
        public void WordCount_WordMatch_Count()
        {
            WordCount newWordCount = new WordCount("The cat walked into the cathedral", "cat", 1);
            int result = newWordCount.WordMatch();
            Assert.AreEqual(result, 1);
        }
        
        [TestMethod]
        public void WordCount_WordMatch_Count_MultipleMatches()
        {
            WordCount newWordCount = new WordCount("It's a dog eat dog world", "dog", 2);
            int result = newWordCount.WordMatch();
            Assert.AreEqual(result,2);
        }
    }
}
