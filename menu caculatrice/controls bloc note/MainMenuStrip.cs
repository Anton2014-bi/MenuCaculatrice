using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu_caculatrice.controls
{
    public class mainmenustrip : MenuStrip
    {
        private const string NAME = "MainMenuStrip";
        public mainmenustrip()
        {
            Name = NAME;
            Dock = DockStyle.Top;

            FileDropDownMenu();
            EditDropDownMenu();
            FormatDropDownMenu();
            ViewDropDownMenu();
        }

        public void FileDropDownMenu()
        {
            var fileDropDownMenu = new ToolStripMenuItem("Fichier");

            var newmenu = new ToolStripMenuItem("Nouveau", null, null, Keys.Control | Keys.N);
            var openmenu = new ToolStripMenuItem("Ouvrir", null, null, Keys.Control | Keys.O);
            var savemenu = new ToolStripMenuItem("Enregistrer", null, null, Keys.Control | Keys.S);
            var saveasmenu = new ToolStripMenuItem("Enregistrer sous", null, null, Keys.Control | Keys.Shift | Keys.N);
            var quitmenu = new ToolStripMenuItem("Quitter", null, null, Keys.Alt | Keys.F4);

            fileDropDownMenu.DropDownItems.AddRange(new ToolStripItem[] { newmenu, openmenu, savemenu, saveasmenu, quitmenu });

            Items.Add(fileDropDownMenu);
        }

        public void EditDropDownMenu()
        {
            var editDropDownMenu = new ToolStripMenuItem("Edition");

            var cancelmenu = new ToolStripMenuItem("Annuler", null, null, Keys.Control | Keys.Z);
            var restauremenu = new ToolStripMenuItem("Remplacer", null, null, Keys.Control | Keys.Y);

            editDropDownMenu.DropDownItems.AddRange(new ToolStripItem[] { cancelmenu, restauremenu });

            Items.Add(editDropDownMenu);
        }

        public void FormatDropDownMenu()
        {
            var formatDropDownMenu = new ToolStripMenuItem("Format");

            var fontmenu = new ToolStripMenuItem("Police");

            formatDropDownMenu.DropDownItems.AddRange(new ToolStripItem[] { fontmenu });

            Items.Add(formatDropDownMenu);
        }

        public void ViewDropDownMenu()
        {
            var viewDropDown = new ToolStripMenuItem("Affichage");


            var zoomDropDown = new ToolStripMenuItem("Zoom");

            var zoomin = new ToolStripMenuItem("Zoom avant", null, null, Keys.Control | Keys.Add);
            var zoomout = new ToolStripMenuItem("Zoom arriere", null, null, Keys.Control | Keys.Subtract);
            var zoomreset = new ToolStripMenuItem("Restaurer le zoom par defaut", null, null, Keys.Control | Keys.Divide);

            zoomin.ShortcutKeyDisplayString = "Ctrl+Nu +";
            zoomout.ShortcutKeyDisplayString = "Ctrl+Nu -";
            zoomreset.ShortcutKeyDisplayString = "Ctrl+Nu /";

            zoomin.Click += (s, e) =>
            {

            };

            zoomDropDown.DropDownItems.AddRange(new ToolStripItem[] { zoomin, zoomout, zoomreset});

            viewDropDown.DropDownItems.AddRange(new ToolStripItem[] {  zoomDropDown });

            Items.Add(viewDropDown);
        }
    }
}
