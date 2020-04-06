using Microsoft.AspNetCore.Mvc;

namespace CurrentMood.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}