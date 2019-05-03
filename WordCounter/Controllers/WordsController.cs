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

  }
}
