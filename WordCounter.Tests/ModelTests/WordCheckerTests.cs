using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class WordCheckerTests
    {
        [TestMethod]
        public void WordChecker_GetSentence_CreateSentence()
        {
           WordChecker newWordChecker = new WordChecker("The cat walked into the cathedral");
           string result = newWordChecker.GetSentence();
           Assert.AreEqual(result, "The cat walked into the cathedral");
        }
    }
}