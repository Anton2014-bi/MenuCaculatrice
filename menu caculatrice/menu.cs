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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculatrice_window calculatrice_Window = new calculatrice_window();
            calculatrice_Window.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculatrice_scientifique calculatrice_Scientifique = new calculatrice_scientifique();
            calculatrice_Scientifique.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bloc_note blocnote = new bloc_note();
            blocnote.Show();
        }
    }
}
