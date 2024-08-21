using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu_caculatrice.controls_bloc_note
{
    public class RichTextBoxContextMenuScript : ContextMenuStrip
    {
        private RichTextBox _richtextBox;
        private const string NAME = "RtbContextMenuStrip";

        public RichTextBoxContextMenuScript(RichTextBox richTextBox)
        {
            _richtextBox = richTextBox;

            var cut = new ToolStripMenuItem("Couper");
            var copy = new ToolStripMenuItem("Copier", null, null, Keys.Control | Keys.C);
            var paste = new ToolStripMenuItem("Coller", null, null, Keys.Control | Keys.V);
            var selectAll = new ToolStripMenuItem("Selectionner tout");

            cut.Click += (s, e) => _richtextBox.Cut();
            copy.Click += (s, e) => _richtextBox.Copy();
            paste.Click += (s, e) => _richtextBox.Paste();
            selectAll.Click += (s, e) => _richtextBox.SelectAll();


            Items.AddRange(new ToolStripItem[] { cut, copy, paste, selectAll });

        }
    }
}
