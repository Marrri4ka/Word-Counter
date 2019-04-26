
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
      _userSentence = userSentence.ToLower();
    }

    public int CountWords()
    {
      int result = 0;
      string[] newSentence = _userSentence.Split(' ');

      for (int i = 0; i< newSentence.Length; i++)
      {
        if(_userWord == newSentence[i])
        {
          result +=1;
        }
      }

      return result;
    }


    public string IsValidInput()
    {
      char [] letters = _userWord.ToCharArray();
      for (int i =0; i<letters.Length; i++)
      {
      if (letters[i] < 'a' || letters[i] > 'z')
    {
      return "Only letters please";
    }
  }
  return "";
}
}
}
