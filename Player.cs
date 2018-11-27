namespace deckofcards

{
  using System.Collections.Generic;
  using System;

  public class Player
  {
    string Name;
    public List<Card> Hand = new List<Card>();

    public Card DrawCard(List<Card> deck)
    {
      Card CardDrawn = deck[0];
      Hand.Add(deck[0]);
      deck.RemoveAt(0);
      return CardDrawn;
    }

    public Card Discard(List<Card> hand, int cardAtIndex)
    {
      if (cardAtIndex > hand.Count - 1)
      {
        return null;
      }
      else
      {
      Card CardDiscarded = hand[cardAtIndex];
      hand.RemoveAt(cardAtIndex);
      return CardDiscarded;
      }
    }
  }
}