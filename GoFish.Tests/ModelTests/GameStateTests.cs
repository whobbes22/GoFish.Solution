using Microsoft.VisualStudio.TestTools.UnitTesting;
using GoFish.Models;
using System.Collections.Generic;
using System.Linq;
using System;



namespace GoFish.Tests
{
  [TestClass]
  public class GameStateTests

  {
    [TestMethod]
    public void GameStateConstructor_CreatesInstanceOfGameState_GameState()
    {
      GameState playerone = new GameState();
      Assert.AreEqual(typeof(GameState), playerone.GetType());
      
    }

    [TestMethod]
    public void findList_returnCurrentGameStateList_List()
    {
      GameState playerone = new GameState();
      List<int> gs = new List<int> {};
      for(int i = 1; i<=52; i++)
      {
        gs.Add(i);
      }
      GameState.BuildDeck();
      List<int> deck = GameState.GetCurrentDeck();
      
      for(int j = 0; j <= 51; j++)
      {
        Console.WriteLine(gs[j]);
        Assert.AreEqual(gs[j],deck[j]);
      }
      //Assemble
      //Act
      //Assert
    }

    [TestMethod]
    public void AddCardToPlayerList_ReturnAddedCard_List()
    {
      GameState playerOne = new GameState();
      GameState playerTwo = new GameState();
      GameState.BuildDeck();
      playerOne.DrawCard();
      playerTwo.DrawCard();
      list<int> p1Hand = playerOne.PlayerHand;
      list<int> p2Hand = playerTwo.PlayerHand;
      
      list<int> test1 = new list<int> {1};
      list<int> test2 = new list<int> {2};
      Console.WriteLine(p1Hand[0],test1[0],p2Hand[0],test2[0]);
      Assert.AreEqual(p1Hand[0],test1[0]);
      Assert.AreEqual(p2Hand[0],test2[0]);
    }



  //   [TestMethod]
  //   public void findHandList_returnCurrentHandList_List()
  //   {
  //     GameState playerone = new GameState();
  //     List<int> gs = new List<int> {};
  //     for(int i = 1; i<=52; i++)
  //     {
  //       gs.Add(i);
  //     }
  //     GameState.BuildDeck();
  //     List<int> hand = GameState.GetPlayerHand();
      
  //     Console.WriteLine(gs.Count);
  //     Assert.AreEqual(gs.Count,hand.Count);

  //   }
  // }
}  




// 
//var yourList = sut.GetList();
// var first = yourList.First();
// Assert.IsInstanceOf<SlowCar>(first);

// List<T>.Find(Predicate<T>) Method is used to search for an element 
// which matches the conditions defined by the specified predicate and 
// it returns the first occurrence of that element within the entire List<T>.