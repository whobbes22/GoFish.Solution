using System.Collections.Generic;
using System;

namespace GoFish.Models
{
  public class GameState 
  {
    public List<int> PlayerHand { get; set; }//added here
    private static List<int> _currentDeck = new List<int> {};

    public int Matches {get; set;}
    // Business Logic goes here.

    public GameState()
    {
      Matches = 0;
      PlayerHand = new List<int>{};
    }
  // GameState Functions -> static
  
    public static void ClearAll()
    {
      _currentDeck.Clear();
    }

    public static void BuildDeck()
    {
      for(int i = 1; i<=52; i++)
      {
        _currentDeck.Add(i);
      }
    }

    public static List<int> GetCurrentDeck()
    {
      return _currentDeck;
    }


  // Player functions -> non static

    //possibly public void GetPlayerHand()
    public List<int> GetPlayerHand() // may not really need this function
    {
      return PlayerHand;
    }

    public void DrawCards(int amountOfCards)
    {
      Random rnd = new Random();
     
      
      
      // use loop with amount of cards eventually
      for(int i = 1;i<=amountOfCards;i++)
      {
        Console.WriteLine($"Number of cards before Drawing = {_currentDeck.Count}");
        int num = rnd.Next(_currentDeck.Count);
        Console.WriteLine(num);
        int card = _currentDeck[num];
        Console.WriteLine($"current Deck {_currentDeck[num]}");
        _currentDeck.RemoveAt(num);
        PlayerHand.Add(card);
      }

      // int card = _currentDeck.Next(52)
      //_currentDeck.RemoveAt(index + 1)
      //Add(this) would be if we wanted _currentDeck.Add(DrawCards)
    }

  }
}
  
/*
x  game state -> static
x   want a list, list contains all cards 
x   -> array [1,2,3,4,5...] 52 cards
   
x   math.random to random number between 1-52 - -> Next(52) - > Next(list.Count)
x   example random number ->12
x   somehow remove 12 item on the list which retruns a value of 12 -> correspond to a queen
   
   %13 - > give a number between 0 - 12 + 1
   
x   List.RemoveAt(index +1) method 
   
   if( List.Count == 0) can not draw any more cards
   
x   player hands themsevles are not static they only apply to 1 person at a time.
   at the start the game each player takes 7 cards from the pile. 
   if they have any matching cards they are taken out of the hand
   run 2 loops to find out all matching cards to get rid of
   
x   Matches counter
   any time there is a match add +1 to a counter at the end.
   if card = 1 + 13, 
   
   when reciveing or asking for a card run through comparing each card to that card once.
   
   game ends when each player has 0 cards.
   
  
*/