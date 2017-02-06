using System;
using System.Windows.Forms;

namespace EleventyOne {
    public partial class MultiplayerSetup : UserControl {

        public Form1 parent { get; private set; }

        public MultiplayerSetup(Form1 parent) {
            InitializeComponent();

            this.parent = parent;
        }

        private void btnPlay_Click(object sender, EventArgs e) {
            Player[] players = new Player[udPlayers.value];

            // make a Player instance for each player with their respective names
            for (int x = 0; x < udPlayers.value; x++) {
                string name = this.Controls.Find("txtPlayer" + (x + 1).ToString(), false)[0].Text.Trim();

                // default to Player x
                players[x] = new Player((name != "") ? name : "Player " + (x + 1).ToString());
            }

            // start the game
            parent.switchToScreen(new Game(players));
        }

        private void udPlayers_valueChanged(object sender, ValueChangedEventArgs e) {

            // toggle player textboxes based on the number of players selected
            for (int x = 3; x < 6; x++) {
                this.Controls.Find("txtPlayer" + x, false)[0].Visible = (x <= e.value);
                this.Controls.Find("lblPlayer" + x, false)[0].Visible = (x <= e.value);
                this.Controls.Find("lblMargin" + x, false)[0].Visible = (x <= e.value);
            }
        }

        private void btnBack_Click(object sender, EventArgs e) {
            this.Dispose();
        }
    }
}
