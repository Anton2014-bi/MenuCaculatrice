 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace menu_caculatrice.controls_bloc_note
{
    public class customRichTextBox : RichTextBox
    {
        private const String NAME = "RtbtextFileContents";
        public customRichTextBox()
        {
            Name = NAME;
            AcceptsTab = true;
            Font = new Font("Arial", 12, FontStyle.Regular);
            Dock = DockStyle.Fill;
            BorderStyle = BorderStyle.None;
            ContextMenuStrip = new RichTextBoxContextMenuScript(this);
        }
    }
}
