using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoFish.Models;


namespace GoFish.Tests
{
  [TestClass]
  public class GameStateTests

  {
    [TestMethod]
    public void GameStateConstructor_CrearesInstanceOfGameState_GameState()
    {
      GameState playerone = new GameState();
      Assert.AreEqual(typeof(GameState), playerone.GetType());
      //Assemble
      //Act
      //Assert
    }
  }
}    