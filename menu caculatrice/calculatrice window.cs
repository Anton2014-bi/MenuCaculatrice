using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu_caculatrice
{
    public partial class calculatrice_window : Form
    {
        
        public calculatrice_window()
        {
            InitializeComponent();
        }

        string CalTotal;
        int num1;
        int num2;
        string option;
        int result;
        

        private void button6_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "4"; //print 4

        }

        private void bouttonzero_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "0"; //print 0
        }

        private void bouttonpoint_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "."; //print .
        }

        private void bouttonun_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "1"; //print 1
        }

        private void bouttondeux_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "2"; //print 2
        }

        private void bouttontroix_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "3"; //print 3
        }

        private void bouttoncinq_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "5"; //print 5
        }

        private void bouttonsix_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "6";
        }

        private void bouttonsept_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "7";
        }

        private void bouttonhuit_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "8";
        }

        private void bouttonneuf_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "9";
        }

        private void bouttonclear_Click(object sender, EventArgs e)
        {
            textbox.Text = "";
            label2.Text = "";
            label1.Text = "";
        }

        private void bouttonplus_Click(object sender, EventArgs e)
        {
            label1.Text = textbox.Text;
            label2.Text = "+";
            textbox.Text = "";
        }

        private void bouttonmoins_Click(object sender, EventArgs e)
        {
            label1.Text = textbox.Text;
            label2.Text = "-";
            textbox.Text = "";
        }

        private void bouttonfois_Click(object sender, EventArgs e)
        {
            label1.Text = textbox.Text;
            label2.Text = "x";
            textbox.Text = "";
        }

        private void bouttondiviser_Click(object sender, EventArgs e)
        {
            label1.Text = textbox.Text;
            label2.Text = "/";
            textbox.Text = "";
        }

        private void bouttonegale_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textbox.Text = textbox.Text + "00";
        }
    }
}
