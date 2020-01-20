using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;

namespace WordCounter.Tests
{
    [TestClass]
    public class SentenceTests
    {
        [TestMethod]
        public void Sentence_GetSentence_CreateSentence()
        {
           Sentence newSentence = new Sentence("The cat walked into the cathedral");
           string result = newSentence.GetSentence();
           Assert.AreEqual(result, "The cat walked into the cathedral");
        }
    }
}
