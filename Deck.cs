
namespace deckofcards
  
{
  using System.Collections.Generic;
  using System;
  public class Deck
  {
    Random rand = new Random();
    public List<Card> cards = new List<Card>();

    public Deck()
    {
      var StringVals = new Card();
      int currentCard = 0;

      for (int suitVal = 0; suitVal < 4; suitVal++)
      {
        for (int rankVal = 0; rankVal < 13; rankVal++)
        {
          if (suitVal == 0)
          {
            cards.Add(new Card(StringVals.allCardStringVals[rankVal], "Spades", rankVal));
            currentCard++;
          }
          if (suitVal == 1)
          {
            cards.Add(new Card(StringVals.allCardStringVals[rankVal], "Clubs", rankVal));
            currentCard++;
          }
          if (suitVal == 2)
          {
            cards.Add(new Card(StringVals.allCardStringVals[rankVal], "Hearts", rankVal));
            currentCard++;
          }
          if (suitVal == 3)
          {
            cards.Add(new Card(StringVals.allCardStringVals[rankVal], "Diamonds", rankVal));
            currentCard++;
          }
        }
      }
    }
    public Card TopDeck()
    {
      Card topCard = cards[0];
      cards.RemoveAt(0);
      return topCard;
    }
    public Deck Reset()
    {
      Deck deck = new Deck();
      return deck;
    }

    public void Shuffle(List<Card> deck)
    {
      for (int n = deck.Count - 1; n > 0; --n)
      {
        int k = rand.Next(n+1);
        Card temp = deck[n];
        deck[n] = deck[k];
        deck[k] = temp;
      }

    }
  }
}