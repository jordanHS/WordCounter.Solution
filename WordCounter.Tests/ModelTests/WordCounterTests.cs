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
            WordCount newWordCount = new WordCount("The cat walked into the cathedral", "dog");
            int result = newWordCount.SetCounter();
            Assert.AreEqual(result, 0);
        }

        [TestMethod]
        public void WordCount_GetSentence_CreateSentence()
        {
           WordCount newWordCount = new WordCount("The cat walked into the cathedral", "cat");
           string result = newWordCount.GetSentence();
           Assert.AreEqual(result, "The cat walked into the cathedral");
        }

        [TestMethod]
        public void WordCount_GetWord_CreateWord()
        {
            WordCount newWordCount = new WordCount("The cat walked into the the cathedral", "cat");
            string result = newWordCount.GetWord();
            Assert.AreEqual(result, "cat");
        }
    }
}
