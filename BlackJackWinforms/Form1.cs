using BlackJackWInforms;
using System;
using System.Windows.Forms;

namespace BlackJackWInforms
{
    public partial class Form1 : Form
    {
        private GameManager? game;

        public Form1()
        {
            InitializeComponent();

            btnHit.Enabled = false;
            btnStand.Enabled = false;
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            string playerName = txtPlayerName.Text.Trim();

            if (string.IsNullOrWhiteSpace(playerName))
            {
                MessageBox.Show("Voer eerst een spelernaam in.");
                return;
            }

            game = new GameManager(playerName);
            game.StartGame();

            btnHit.Enabled = true;
            btnStand.Enabled = true;

            UpdateUI();

            if (game.Player.HasBlackjack())
            {
                game.DealerPlay();
                UpdateUI();

                btnHit.Enabled = false;
                btnStand.Enabled = false;
                lblStatus.Text = game.GetResult();
            }
            else
            {
                lblStatus.Text = "Spel gestart";
            }
        }

        private void btnHit_Click(object sender, EventArgs e)
        {
            if (game == null)
            {
                return;
            }

            game.PlayerHit();
            UpdateUI();

            if (game.Player.IsBust())
            {
                btnHit.Enabled = false;
                btnStand.Enabled = false;
                lblStatus.Text = game.GetResult();
            }
        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            if (game == null)
            {
                return;
            }

            game.DealerPlay();
            UpdateUI();

            btnHit.Enabled = false;
            btnStand.Enabled = false;
            lblStatus.Text = game.GetResult();
        }

        private void UpdateUI()
{
    if (game == null)
    {
        return;
    }

    lstPlayerCards.Items.Clear();
    lstDealerCards.Items.Clear();

    foreach (Card card in game.Player.Hand)
    {
        lstPlayerCards.Items.Add(card.ToString());
    }

    foreach (Card card in game.Dealer.Hand)
    {
        lstDealerCards.Items.Add(card.ToString());
            }

            int playerScore = game.Player.CalculateScore();
            int dealerScore = game.Dealer.CalculateScore();

    lblPlayerScore.Text = "Player Score: " + playerScore;
    lblDealerScore.Text = "Dealer Score: " + dealerScore;
}

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}