using menu_caculatrice.controls;
using menu_caculatrice.controls_bloc_note;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu_caculatrice
{
    public partial class bloc_note : Form
    {
        public bloc_note()
        {
            InitializeComponent();
            var menuStrip = new mainmenustrip();
            var maintabcontrol =new MainTabControl();
            var richTextBox = new customRichTextBox();

            maintabcontrol.TabPages.Add("Onglet 1");
            maintabcontrol.TabPages[0].Controls.Add(richTextBox);   

            Controls.AddRange(new Control[] { maintabcontrol, menuStrip });
        }
    }
}
