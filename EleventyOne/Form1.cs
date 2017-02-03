using BoinMsgNS;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EleventyOne {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            // set up our messagebox colors to match the form
            BoinMsg.backColor = Color.White;
            BoinMsg.foreColor = Color.Black;
        }

        public void switchToScreen(UserControl screen) {
            this.Controls.Add(screen);
            screen.BringToFront();
            screen.Dock = DockStyle.Fill;
            screen.Show();
        }

        private void btnSinglePlayer_Click(object sender, EventArgs e) {
            var singlePlayerSetup = new SinglePlayerSetup(this);
            
            switchToScreen(singlePlayerSetup);
            singlePlayerSetup.txtPlayerName.Focus();
        }

        private void btnMultiplayer_Click(object sender, EventArgs e) {

        }

        private void btnQuit_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e) {
            if (Game.gameRunning) {
                if (BoinMsg.show("Do you want to quit?", "Eleventy One", true) == DialogResult.Cancel) {
                    e.Cancel = true;
                }
            }
        }
    }
}
