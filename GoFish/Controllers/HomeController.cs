using Microsoft.AspNetCore.Mvc;
using GoFish.Models;

namespace GoFish.Controllers
{
  public class HomeController : Controller
  {
    [Route("/")]
    // Notice the changes below!
    public ActionResult File() { return View(); }
  }
}