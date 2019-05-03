using Microsoft.AspNetCore.Mvc;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult IndexHome()
    {
      return View();
    }

  }
}
