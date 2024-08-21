using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu_caculatrice.controls_bloc_note
{
    public class TabControlContexMenuStrip : ContextMenuStrip
    {
        private const string NAME = "TabControlContextMenuStrip";
        public TabControlContexMenuStrip()
        {
            Name = NAME;

            var closeTab = new ToolStripMenuItem("Fermer");
            var closAllTabsExceptThis = new ToolStripMenuItem("Fermer tout sauf ce fichier");
            var openFileInExplorer = new ToolStripMenuItem("Ouvrir le repertoire du fichier en cours dans l'explorateur");

            Items.AddRange(new ToolStripItem[] { closeTab, closAllTabsExceptThis, openFileInExplorer});
        }
    }
}
