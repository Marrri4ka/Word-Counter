
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
      Word newWord = new Word("cat","catthedral Cat dog");

      //Act
      int result = newWord.CountWords();
      //Assert
      Assert.AreEqual(result, 1);
    }

    [TestMethod]

    public void IsValidInput_Test()
    {
      //Arrange
      Word newWord = new Word("6", "cat dog");

      // Act
      string result = newWord.IsValidInput();
      // Assert
      Assert.AreEqual(result,  "Only letters please");
    }
  }
}
