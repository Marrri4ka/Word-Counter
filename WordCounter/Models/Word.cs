
using System;
using System.Collections.Generic;

namespace WordCount.Models
{
  public class Word // class
  {
    //Fields
    private string _userWord;
    private string _userSentence;

    public Word (string userWord, string userSentence)
    {
      _userWord = userWord;
      _userSentence = userSentence;
    }

    public int CountWords()
    {
      return 5;
    }

  }
}
