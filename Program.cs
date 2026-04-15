using System;
using System.Collections.Generic;

class Card
{
    public string Suit { get; }
    public string Value { get; }

    public Card(string suit, string value)
    {
        Suit = suit;
        Value = value;
    }

    public override string ToString()
    {
        return $"{Value} of {Suit}";
    }
}

class Deck
{
    public List<Card> Cards { get; private set; }

    string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
    string[] values = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King", "Ace" };

    public Deck()
    {
        Cards = new List<Card>();

        foreach (string suit in suits)
        {
            foreach (string value in values)
            {
                Cards.Add(new Card(suit, value));
            }
        }
    }
}

class Shoe
{
    private List<Card> cards = new List<Card>();
    private Random random = new Random();

    public Shoe(int numberOfDecks)
    {
        for (int i = 0; i < numberOfDecks; i++)
        {
            Deck deck = new Deck();
            cards.AddRange(deck.Cards);
        }

        Shuffle();
    }

    private void Shuffle()
    {
        for (int i = cards.Count - 1; i > 0; i--)
        {
            int j = random.Next(0, i + 1);
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

class Player
{
    public string Name { get; }
    public List<Card> Hand { get; private set; }

    public Player(string name)
    {
        Name = name;
        Hand = new List<Card>();
    }

    public void AddCard(Card card)
    {
        Hand.Add(card);
    }

    public void ShowHand()
    {
        Console.Write($"{Name}'s hand: ");
        foreach (Card card in Hand)
        {
            Console.Write($"[{card}] ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Blackjack ===\n");

        Console.Write("Hoeveel spelers doen mee? (1-4): ");
        int aantalSpelers = int.Parse(Console.ReadLine());

        List<Player> spelers = new List<Player>();

        for (int i = 1; i <= aantalSpelers; i++)
        {
            Console.Write($"Naam van speler {i}: ");
            string naam = Console.ReadLine();
            spelers.Add(new Player(naam));
        }

        Player dealer = new Player("Dealer");
        Shoe shoe = new Shoe(2);

        // Deel 2 kaarten aan iedereen
        for (int ronde = 0; ronde < 2; ronde++)
        {
            foreach (Player speler in spelers)
                speler.AddCard(shoe.DrawCard());

            dealer.AddCard(shoe.DrawCard());
        }

        // Laat de handen zien
        Console.WriteLine("\n--- Uitgedeelde kaarten ---");
        dealer.ShowHand();
        foreach (Player speler in spelers)
            speler.ShowHand();

        Console.ReadLine();
    }
}
