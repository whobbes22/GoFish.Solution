namespace GoFish.Models //update namespace her
{
  public class GameState //create model class here
  {
    // Business Logic goes here.
  }
}

/*
game state -> static
want a list, list contains all cards 
-> array [1,2,3,4,5...] 52 cards

math.random to random number between 1-52 - -> Next(52) - > Next(list.Count)
example random number ->12
somehow remove 12 item on the list which retruns a value of 12 -> correspond to a queen

%13 - > give a number between 0 - 12 + 1

List.RemoveAt(index +1) method 

if( List.Count == 0) can not draw any more cards

player hands themsevles are not static they only apply to 1 person at a time.
at the start the game each player takes 7 cards from the pile. 
if they have any matching cards they are taken out of the hand
run 2 loops to find out all matching cards to get rid of

any time there is a match add +1 to a counter at the end.

when reciveing or asking for a card run through comparing each card to that card once.

game ends when each player has 0 cards.


*/