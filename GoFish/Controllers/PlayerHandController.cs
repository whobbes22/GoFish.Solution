using Microsoft.AspNetCore.Mvc;
using GoFish.Models;

namespace GoFish.Controllers
{
  public class PlayerHandController : Controller
  {
    [Route("/")]
    // Notice the changes below!
    public ActionResult File() { return View(); }
  }
}