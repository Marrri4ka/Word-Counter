using System.Collections.Generic;

using System;

namespace WordCounter.Models
{
  public class Word // class
  {
    //Fields
    private static List<Word> _allresults = new List<Word>{};
    private string _userWord;
    private string _userSentence;
    private int _id;

    public Word (string userWord, string userSentence) // constructor
    {
      _userWord = userWord.ToLower();
      _userSentence = userSentence.ToLower();
      _allresults.Add(this);
    }

    public static void ClearAll()
    {
      _allresults.Clear();
    }

    public static List<Word> GetAll()
    {
      return _allresults;
    }

    public static Word Find(int id)
    {
      return _allresults[id-1];
    }

    // public void Delete()
    // {
    //   for (int i=0; i<_allresults.Count; i++)
    //   {
    //     if(_allresults[i].GetId() == _id)
    //     {
    //       _allresults.Remove(_allresults[i]);
    //     }
    //   }
    // }

    public string GetUserWord()
    {
      return _userWord;
    }

    public void SetUserWord(string newUserWord)
    {
      _userWord = newUserWord;
    }

    public string GetUserSentence()
    {
      return _userSentence;
    }

    public void SetUserSentence(string newUserSentence)
    {
      _userSentence= newUserSentence;
    }

    public int CountWords()
    {
      int result = 0;
      string[] newSentence = _userSentence.Split(' ', ',','!',':',';');

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
