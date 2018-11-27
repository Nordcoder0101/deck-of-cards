namespace deckofcards
{
  public class Card
    {
        public string StringVal;

        public string[] allCardStringVals = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };

        public string Suit;
        
        public int CardVal;        

        public Card(string stringVal, string suit, int cardVal)
        {
        StringVal = stringVal;
        Suit = suit;
        CardVal = cardVal;
        }
        public Card()
        { }
  }
}
