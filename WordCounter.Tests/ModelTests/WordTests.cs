
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCount.Models;

namespace WordCount.Tests
{
  [TestClass]
  public class WordTest
  {
    [TestMethod]
    public void CountWords_Test()
    {
      // Arrange
      Word newWord = new Word("cat","cat,dog");

      //Act
      int result = newWord.CountWords();
      //Assert
      Assert.AreEqual(result, 2);
    }
  }
}
