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
        public void WordCount_WordMatch_Count()
        {
            WordCount newWordCount = new WordCount("The cat walked into the cathedral", "cat", 1);
            int result = newWordCount.WordMatch();
            Assert.AreEqual(result, 1);
        }
        
        [TestMethod]
        public void WordCount_WordMatch_Count_MultipleMatches()
        {
            WordCount newWordCount = new WordCount("Dog eat dog world", "dog", 2);
            int result = newWordCount.WordMatch();
            Assert.AreEqual(result,2);
        }
    }
}
