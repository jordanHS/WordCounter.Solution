using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCountTests
    {

        [TestMethod]
        public void WordCount_GetSentence_CreateSentence()
        {
           WordCount newWordCount = new WordCount("The cat walked into the cathedral", "cat");
           string result = newWordCount.GetSentence();
           Assert.AreEqual(result, "The cat walked into the cathedral");
        }
    }
}
