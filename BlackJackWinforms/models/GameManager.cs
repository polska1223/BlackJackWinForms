namespace BlackJackWInforms
{
    public class GameManager
    {
        public Player Player { get; set; }
        public Player Dealer { get; set; }
        public Shoe Shoe { get; set; }

        public GameManager(string playerName)
        {
            Player = new Player(playerName);
            Dealer = new Player("Dealer");
            Shoe = new Shoe(2);
        }

        public void StartGame()
        {
            Player.Hand.Clear();
            Dealer.Hand.Clear();

            Player.AddCard(Shoe.DrawCard());
            Dealer.AddCard(Shoe.DrawCard());
            Player.AddCard(Shoe.DrawCard());
            Dealer.AddCard(Shoe.DrawCard());
        }

        public void PlayerHit()
        {
            Player.AddCard(Shoe.DrawCard());
        }

        public void DealerPlay()
        {
            while (Dealer.CalculateScore() < 17)
            {
                Dealer.AddCard(Shoe.DrawCard());
            }
        }

        public string GetResult()
        {
            if (Player.IsBust())
            {
                return "Player loses: bust";
            }

            if (Dealer.IsBust())
            {
                return "Player wins: dealer bust";
            }

            if (Player.CalculateScore() > Dealer.CalculateScore())
            {
                return "Player wins";
            }

            if (Player.CalculateScore() < Dealer.CalculateScore())
            {
                return "Dealer wins";
            }

            return "Push";
        }
    }
}