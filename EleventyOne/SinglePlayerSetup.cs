using System;
using System.Windows.Forms;

namespace EleventyOne {
    public partial class SinglePlayerSetup : UserControl {

        RadioButton radChecked;

        public Form1 parent { get; private set; }

        public SinglePlayerSetup(Form1 parent) {
            InitializeComponent();

            this.parent = parent;

            // associate radiobuttons with their respective difficulties
            radAggressive.Tag = Difficulty.aggressive;
            radCautious.Tag   = Difficulty.cautious;
            radCoward.Tag     = Difficulty.coward;
            radIdiot.Tag      = Difficulty.idiot;
            radMedium.Tag     = Difficulty.medium;

            // random is checked first
            radChecked = radRandom;
        }

        private void btnPlay_Click(object sender, EventArgs e) {
            Player[] players = new Player[udOpponents.value + 1];

            // players[0] is always the user
            string name = txtPlayerName.Text.Trim();
            players[0] = new Player((name == "") ? "You" : name); // default player name to "You"

            if (radChecked == radRandom) {
                
                // assign each AI a random difficulty
                for (int x = 1; x < players.Length; x++) {
                    players[x] = new AIPlayer((Difficulty)Game.dice.Next(5));
                }

            } else {
                
                // assign each AI the selected difficulty
                for (int x = 1; x < players.Length; x++) {
                    players[x] = new AIPlayer((Difficulty)radChecked.Tag);
                }
            }

            // start the game
            parent.switchToScreen(new Game(players));
        }

        private void btnBack_Click(object sender, EventArgs e) {
            this.Dispose();
        }

        private void radRandom_CheckedChanged(object sender, EventArgs e) {
            var rad = sender as RadioButton;

            if (rad.Checked) {
                radChecked = rad; // we're the new checked radiobutton
            }
        }
    }
}
