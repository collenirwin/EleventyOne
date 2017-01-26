using System.Drawing.Text;
using System.Windows.Forms;

namespace EleventyOne {
    public class AALabel : Label {

        protected override void OnPaint(PaintEventArgs e) {
            e.Graphics.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

            base.OnPaint(e);
        }
    }
}
