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
            lblStatus = new Label();
            lstDealerCards = new ListBox();
            SuspendLayout();
            // 
            // btnStartGame
            // 
            btnStartGame.Location = new Point(26, 28);
            btnStartGame.Name = "btnStartGame";
            btnStartGame.Size = new Size(125, 29);
            btnStartGame.TabIndex = 0;
            btnStartGame.Text = "btnStartGame";
            btnStartGame.UseVisualStyleBackColor = true;
            btnStartGame.Click += button1_Click;
            // 
            // txtPlayerName
            // 
            txtPlayerName.Location = new Point(187, 30);
            txtPlayerName.Name = "txtPlayerName";
            txtPlayerName.Size = new Size(125, 27);
            txtPlayerName.TabIndex = 1;
            txtPlayerName.Text = "txtPlayerName";
            // 
            // btnHit
            // 
            btnHit.Location = new Point(26, 100);
            btnHit.Name = "btnHit";
            btnHit.Size = new Size(94, 29);
            btnHit.TabIndex = 2;
            btnHit.Text = "btnHit";
            btnHit.UseVisualStyleBackColor = true;
            // 
            // btnStand
            // 
            btnStand.Location = new Point(187, 90);
            btnStand.Name = "btnStand";
            btnStand.Size = new Size(94, 29);
            btnStand.TabIndex = 3;
            btnStand.Text = "btnStand";
            btnStand.UseVisualStyleBackColor = true;
            btnStand.Click += button3_Click;
            // 
            // lstPlayerCards
            // 
            lstPlayerCards.FormattingEnabled = true;
            lstPlayerCards.Items.AddRange(new object[] { "lstPlayerCards" });
            lstPlayerCards.Location = new Point(59, 284);
            lstPlayerCards.Name = "lstPlayerCards";
            lstPlayerCards.Size = new Size(150, 104);
            lstPlayerCards.TabIndex = 4;
            lstPlayerCards.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lblPlayerScore
            // 
            lblPlayerScore.AutoSize = true;
            lblPlayerScore.Location = new Point(256, 167);
            lblPlayerScore.Name = "lblPlayerScore";
            lblPlayerScore.Size = new Size(103, 20);
            lblPlayerScore.TabIndex = 5;
            lblPlayerScore.Text = "lblPlayerScore";
            // 
            // lblDealerScore
            // 
            lblDealerScore.AutoSize = true;
            lblDealerScore.Location = new Point(256, 200);
            lblDealerScore.Name = "lblDealerScore";
            lblDealerScore.Size = new Size(107, 20);
            lblDealerScore.TabIndex = 6;
            lblDealerScore.Text = "lblDealerScore";
            lblDealerScore.Click += label2_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(268, 235);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(66, 20);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "lblStatus";
            // 
            // lstDealerCards
            // 
            lstDealerCards.FormattingEnabled = true;
            lstDealerCards.Items.AddRange(new object[] { "lstDealerCards" });
            lstDealerCards.Location = new Point(228, 284);
            lstDealerCards.Name = "lstDealerCards";
            lstDealerCards.Size = new Size(150, 104);
            lstDealerCards.TabIndex = 8;
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
            Text = "Form1";
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
        private Label lblStatus;
        private ListBox lstDealerCards;
    }
}
