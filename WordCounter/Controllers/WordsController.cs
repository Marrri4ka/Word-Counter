using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;
using System.Collections.Generic;

namespace WordCounter.Controllers
{
  public class WordsController : Controller
  {
    [HttpGet("/wordgame")]
        public ActionResult Game()
        {
          return View();
        }


    [HttpPost("/wordgame")]
        public ActionResult Game(string userWord, string userSentence)
        {
          Word newWord = new Word(userWord,userSentence);
          newWord.CountWords();

          return View("Game",newWord);
        }

  }
}
