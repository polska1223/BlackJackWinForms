using System;
using System.Collections.Generic;

namespace BlackJackWInforms
{
    public class Shoe
    {
        private List<Card> cards;
        private Random random;

        public Shoe(int numberOfDecks)
        {
            cards = new List<Card>();
            random = new Random();

            for (int i = 0; i < numberOfDecks; i++)
            {
                Deck deck = new Deck();
                cards.AddRange(deck.Cards);
            }

            Shuffle();
        }

        public void Shuffle()
        {
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = random.Next(i + 1);
                Card temp = cards[i];
                cards[i] = cards[j];
                cards[j] = temp;
            }
        }

        public Card DrawCard()
        {
            Card card = cards[0];
            cards.RemoveAt(0);
            return card;
        }
    }
}