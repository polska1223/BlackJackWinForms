using System.Collections.Generic;

namespace BlackJackWInforms
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Hand { get; set; }

        public Player(string name)
        {
            Name = name;
            Hand = new List<Card>();
        }

        public void AddCard(Card card)
        {
            Hand.Add(card);
        }

        public int CalculateScore()
        {
            int score = 0;
            int aceCount = 0;

            foreach (Card card in Hand)
            {
                score += card.GetValue();

                if (card.Rank == "Ace")
                {
                    aceCount++;
                }
            }

            while (score > 21 && aceCount > 0)
            {
                score -= 10;
                aceCount--;
            }

            return score;
        }

        public bool IsBust()
        {
            return CalculateScore() > 21;
        }

        public bool HasBlackjack()
        {
            return Hand.Count == 2 && CalculateScore() == 21;
        }
    }
}