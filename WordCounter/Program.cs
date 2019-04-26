using System;
using System.Collections.Generic;

namespace WordCount.Models
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter your word");
      string myWord = Console.ReadLine();
    Console.WriteLine("Please enter your sentence");
    string mySentence = Console.ReadLine();
      Word newWord = new Word(myWord,mySentence);
      int result = newWord.CountWords();
      Console.WriteLine("Your result is " + result);

    }
  }
}
