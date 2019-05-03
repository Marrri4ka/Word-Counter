using Microsoft.AspNetCore.Mvc;

namespace WotdCounter.Controllers
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
