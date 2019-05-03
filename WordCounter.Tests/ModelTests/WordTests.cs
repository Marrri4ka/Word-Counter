
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using WordCounter.Models;

namespace WordCounter.Tests
{
  [TestClass]
  public class WordTest
  {
    [TestMethod]
    public void CountWords_Test_TwoSameWords()
    {
      // Arrange
      Word newWord = new Word("cat","cat cat");

      //Act
      int result = newWord.CountWords();
      //Assert
      Assert.AreEqual(result, 2);
    }


    [TestMethod]
    public void CountWords_Test_UpperCaseWord()
    {
      Word newWord = new Word("cat","Cat");
      int result = newWord.CountWords();
      Assert.AreEqual(result, 1);
    }

    [TestMethod]
    public void CountWords_Test_DifferentCaseWord()
    {
      Word newWord = new Word("cat","cAt");
      int result = newWord.CountWords();
      Assert.AreEqual(result, 1);
    }


    [TestMethod]
    public void CountWords_Test_Fullword_Match()
    {
      Word newWord = new Word("cat","Cathedral");
      int result = newWord.CountWords();
      Assert.AreEqual(result, 0);
    }


    [TestMethod]
    public void CountWords_Test_NoSameWords()
    {
      Word newWord = new Word("cat","dog");
      int result = newWord.CountWords();
      Assert.AreEqual(result, 0);
    }

    [TestMethod]
    public void CountWords_Test_NoWordInput()
    {
      Word newWord = new Word(" ","dog");
      int result = newWord.CountWords();
      Assert.AreEqual(result, 0);
    }


    [TestMethod]
    public void CountWords_Test_NoSentenceInput()
    {
      Word newWord = new Word("cat","");
      int result = newWord.CountWords();
      Assert.AreEqual(result, 0);
    }


    [TestMethod]

    public void IsValidInput_Test()
    {
      Word newWord = new Word("6", "cat dog");
      string result = newWord.IsValidInput();
      Assert.AreEqual(result,  "Only letters please");
    }
  }
}
