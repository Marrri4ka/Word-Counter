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
          List<Word> allwords = Word.GetAll();
          return View(allwords);
        }


    [HttpPost("/wordgame/new")]
        public ActionResult Game(string userWord, string userSentence)
        {
          Word newWord = new Word(userWord,userSentence);
          List<Word> allwords = Word.GetAll();
          newWord.CountWords();

          return View("New",allwords);
        }

        // [HttpGet("/wordgame/dleteall")]
        //     public ActionResult GameMy()
        //     {
        //       List<Word> allwords = Word.GetAll();
        //       allwords.ClearAll();
        //       return View(allwords);
        //     }

        [HttpPost("/wordgame/{wordgameId}/delete")]
          public ActionResult Delete(int wordgameId)

          {

            Word newWord = Word.Find(wordgameId);
            newWord.Delete();
                  List<Word> allwords = Word.GetAll();
              return View("New",allwords);

}
  }
}
