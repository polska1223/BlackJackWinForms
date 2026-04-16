namespace BlackJackWInforms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnStartGame = new Button();
            txtPlayerName = new TextBox();
            btnHit = new Button();
            btnStand = new Button();
            lstPlayerCards = new ListBox();
            lblPlayerScore = new Label();
            lblDealerScore = new Label();
            lstDealerCards = new ListBox();
            lblStatus = new Label();
            SuspendLayout();
            // 
            // btnStartGame
            // 
            btnStartGame.Location = new Point(26, 28);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(125, 29);
            btnStartGame.TabIndex = 0;
            btnStartGame.Text = "Start Game";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += btnStartGame_Click;
            // 
            // txtPlayerName
            // 
            txtPlayerName.Location = new Point(187, 30);
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.Size = new Size(125, 27);
            txtPlayerName.TabIndex = 1;
            txtPlayerName.Text = "";
            // 
            // btnHit
            // 
            btnHit.Location = new Point(26, 100);
            btnHit.Name = "btnHit";
            btnHit.Size = new Size(94, 29);
            btnHit.TabIndex = 2;
            btnHit.Text = "Hit";
            btnHit.UseVisualStyleBackColor = true;
            btnHit.Click += btnHit_Click;
            // 
            // btnStand
            // 
            btnStand.Location = new Point(187, 90);
            btnStand.Name = "btnStand";
            btnStand.Size = new Size(94, 29);
            btnStand.TabIndex = 3;
            btnStand.Text = "Stand";
            btnStand.UseVisualStyleBackColor = true;
            btnStand.Click += btnStand_Click;
            // 
            // lstPlayerCards
            // 
            lstPlayerCards.FormattingEnabled = true;
            lstPlayerCards.Location = new Point(59, 284);
            lstPlayerCards.Name = "lstPlayerCards";
            lstPlayerCards.Size = new Size(150, 104);
            lstPlayerCards.TabIndex = 4;
            // 
            // lblPlayerScore
            // 
            lblPlayerScore.AutoSize = true;
            lblPlayerScore.Location = new Point(30, 150);
            lblPlayerScore.Name = "lblPlayerScore";
            lblPlayerScore.Size = new Size(94, 20);
            lblPlayerScore.TabIndex = 5;
            lblPlayerScore.Text = "Player Score:";
            // 
            // lblDealerScore
            // 
            lblDealerScore.AutoSize = true;
            lblDealerScore.Location = new Point(30, 180);
            lblDealerScore.Name = "lblDealerScore";
            lblDealerScore.Size = new Size(98, 20);
            lblDealerScore.TabIndex = 6;
            lblDealerScore.Text = "Dealer Score:";
            // 
            // lstDealerCards
            // 
            lstDealerCards.FormattingEnabled = true;
            lstDealerCards.Location = new Point(228, 284);
            lstDealerCards.Name = "lstDealerCards";
            lstDealerCards.Size = new Size(150, 104);
            lstDealerCards.TabIndex = 8;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(30, 210);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 20);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstDealerCards);
            Controls.Add(lblStatus);
            Controls.Add(lblDealerScore);
            Controls.Add(lblPlayerScore);
            Controls.Add(lstPlayerCards);
            Controls.Add(btnStand);
            Controls.Add(btnHit);
            Controls.Add(txtPlayerName);
            Controls.Add(btnStartGame);
            Name = "Form1";
            Text = "Blackjack";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStartGame;
        private TextBox txtPlayerName;
        private Button btnHit;
        private Button btnStand;
        private ListBox lstPlayerCards;
        private Label lblPlayerScore;
        private Label lblDealerScore;
        private ListBox lstDealerCards;
        private Label lblStatus;
    }
}
