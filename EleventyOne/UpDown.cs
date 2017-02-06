using System;
using System.Windows.Forms;

namespace EleventyOne {

    public partial class UpDown : UserControl {

        private int _min   = 0;
        private int _max   = 10;
        private int _value = 0;

        public event ValueChanged valueChanged;

        public int min {
            get { return _min; }
            set {
                _min = value;

                if (value > max) { // don't let min be > max
                    _min = max;
                    this.value = max;

                }

                // reset value, so it doesn't get out of range (see value setter)
                this.value = this.value;
            }
        }

        public int max {
            get { return _max; }
            set {
                _max = value;

                if (value < min) { // don't let max be < min
                    _max = min;
                    this.value = max;
                }

                // reset value, so it doesn't get out of range (see value setter)
                this.value = this.value;
            }
        }

        public int value {
            get { return _value; }
            set {
                if (value < min) { // too low
                    _value = min;

                } else if (value > max) { // too high
                    _value = max;

                } else { // within range
                    _value = value;
                }

                txtValue.Text = _value.ToString();

                if (valueChanged != null) {
                    valueChanged(this, new ValueChangedEventArgs(_value));
                }
            }
        }

        public UpDown() {
            InitializeComponent();
        }

        private void btnRight_Click(object sender, EventArgs e) {
            value++;
        }

        private void btnLeft_Click(object sender, EventArgs e) {
            value--;
        }

        private void txtValue_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {

                int newValue = 0;
                if (int.TryParse(txtValue.Text, out newValue)) {
                    value = newValue;

                }

                txtValue.Text = value.ToString();
            }
        }
    }

    // ValueChanged event stuff below here

    public delegate void ValueChanged(object sender, ValueChangedEventArgs e);

    public class ValueChangedEventArgs : EventArgs {
        public int value { get; private set; }

        public ValueChangedEventArgs(int value) {
            this.value = value;
        }
    }
}
