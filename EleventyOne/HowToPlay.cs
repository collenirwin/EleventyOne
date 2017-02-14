using System;
using System.Windows.Forms;

namespace EleventyOne {
    public partial class HowToPlay : UserControl {
        public HowToPlay() {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e) {
            this.Dispose();
        }
    }
}
