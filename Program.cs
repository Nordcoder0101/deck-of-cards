using System;

namespace deckofcards
{
  class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            foreach (Card c in deck.cards)
            {
            System.Console.WriteLine("{0} of {1}.  And the deck has {2} cards.", c.StringVal, c.Suit, deck.cards.Count);
            }
            deck.Shuffle(deck.cards);
            foreach (Card c in deck.cards)
            {
            System.Console.WriteLine("{0} of {1}.  And the deck has {2} cards.", c.StringVal, c.Suit, deck.cards.Count);
            }
            
        }
    }
}
