using BoinBoxNS;
using BoinMsgNS;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EleventyOne {
    public partial class Game : UserControl {

        public static readonly Random dice = new Random();
        public static bool gameRunning { get; private set; }

        Color[] colors = {
            Color.MediumSeaGreen,
            Color.LightCoral,
            Color.DodgerBlue,
            Color.MediumSlateBlue,
            Color.Tan
        };

        Label[] namePlates = new Label[5];

        public Player[] players { get; private set; }
        int currentPlayer = 0;

        public Game(Player[] players) {
            InitializeComponent();

            if (players.Length < 2 || players.Length > 5) {
                throw new ArgumentException("Must be between 2 and 5 players.");
            }

            gameRunning = true;

            this.players = players;

            // associate players with their respective nameplates
            namePlates[0] = lblPlayer1;
            namePlates[1] = lblPlayer2;
            namePlates[2] = lblPlayer3;
            namePlates[3] = lblPlayer4;
            namePlates[4] = lblPlayer5;

            for (int x = 0; x < players.Length; x++) {
                namePlates[x].Text = "[0]" + players[x].name;
                namePlates[x].Show();
            }

            var player = players[currentPlayer];

            // start the first player's entry in txtGame, bold
            append(player.name + ":", colors[currentPlayer], true);

            // highlight player's nameplate
            namePlates[currentPlayer].BackColor = namePlates[currentPlayer].ForeColor;
            namePlates[currentPlayer].ForeColor = Color.White;

            // show the player's name in the turn label
            lblTurn.Text = player.name + "'s turn";
        }

        private void append(string text, Color color, bool bold = false, bool scroll = false) {

            // get end point (before we add text)
            int start = txtGame.TextLength;

            // add text
            txtGame.AppendText(text);

            // select and color text
            txtGame.SelectionStart  = start;
            txtGame.SelectionLength = text.Length;
            txtGame.SelectionColor  = color;

            // make it bold?
            if (bold) {
                txtGame.SelectionFont = new Font(txtGame.SelectionFont, FontStyle.Bold);
            } else {
                txtGame.SelectionFont = new Font(txtGame.SelectionFont, FontStyle.Regular);
            }

            // scroll to bottom?
            if (scroll) {
                txtGame.SelectionStart = txtGame.TextLength;
                txtGame.ScrollToCaret();
            }
        }

        private void rollAndAppend() {
            append(" " + players[currentPlayer].roll(), colors[currentPlayer]);
        }

        private void btnRoll_Click(object sender, EventArgs e) {
            rollAndAppend();

            if (players[currentPlayer].rollendOne) {
                finishRound();
            }
        }

        private void btnEndTurn_Click(object sender, EventArgs e) {
            finishRound();
        }

        private void btnQuit_Click(object sender, EventArgs e) {
            if (BoinMsg.show("Do you want to quit?", "Eleventy One", true) == DialogResult.OK) {
                gameRunning = false;
                this.Dispose();
            }
        }

        private void finishRound() {
            var player = players[currentPlayer];

            // calculate how many points the player accumulated this round
            int scoreDiff = player.points;
            player.finishRound();
            scoreDiff = player.points - scoreDiff;

            append(" Total: " + scoreDiff, colors[currentPlayer], true);

            // update player's nameplate with new score
            namePlates[currentPlayer].Text = string.Format("[{0}]{1}", player.points, player.name);

            // get rid of player's nameplate highlight
            namePlates[currentPlayer].ForeColor = colors[currentPlayer];
            namePlates[currentPlayer].BackColor = Color.White;

            if (player.hasWon()) {
                BoinMsg.show(player.name + " won the game!", "Eleventy One");
                gameRunning = false;
                this.Dispose();
                return;
            }

            // next player's turn
            currentPlayer++;
            if (currentPlayer >= players.Length) {
                currentPlayer = 0;
            }

            // new player
            var nextPlayer = players[currentPlayer];

            // start the player's entry in txtGame, bold
            append(Environment.NewLine + nextPlayer.name + ":", colors[currentPlayer], true, true);

            // highlight new player's nameplate
            namePlates[currentPlayer].BackColor = colors[currentPlayer];
            namePlates[currentPlayer].ForeColor = Color.White;

            // show the new player's name in the turn label
            lblTurn.Text = nextPlayer.name + "'s turn";

            // set the turn label's color to the player's color
            lblTurn.ForeColor = colors[currentPlayer];

            // if the next player is an AI
            if (nextPlayer.GetType() == typeof(AIPlayer)) {
                btnRoll.Hide();
                btnEndTurn.Hide();
                tmrTurn.Start(); // start AI timer

            } else { // human player, show the buttons
                btnRoll.Show();
                btnEndTurn.Show();
            }
        }

        private void tmrTurn_Tick(object sender, EventArgs e) {
            var ai = players[currentPlayer] as AIPlayer;

            // if the AI will roll again, roll again
            if (!ai.rollendOne && !ai.hasWon() && ai.rollAgain()) {
                rollAndAppend();

            } else { // stop the timer, finish the round
                tmrTurn.Stop();
                finishRound();
            }
        }
    }
}
