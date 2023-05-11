using Microsoft.AspNetCore.Mvc;
using GoFish.Models;

namespace GoFish.Controllers
{
  public class GameStatesController : Controller
  {
    [HttpGet("/gamestates")]
    public ActionResult Index() 
    { 
      GameState playerOne = new GameState();
      GameState playerTwo = new GameState();
     return View(); 
    }

    [HttpPost("/gamestates/player1")]
    public ActionResult Player1()
    {
      GameState.DrawCards();
      return View();
    }

    [HttpPost("/gamestates/player2")]
    public ActionResult Player2()
    {
//      playerOne.DrawCards(1);
      return View();
    }

  
  }
}