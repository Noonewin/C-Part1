using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assessment_2B
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_setup_Click(object sender, EventArgs e)
        {
            //Changes lbl_joke text property.
            lbl_joke.Text = "Whats the object-oriented way to become wealthy?";
        }

        private void btn_punchline_Click(object sender, EventArgs e)
        {
            //Changes lbl_joke text property.
            lbl_joke.Text = "Inheritance";
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            //Changes lbl_joke text property.
            lbl_joke.Text = "Ready for a Joke?";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            //Closes current application form.
            this.Close();
        }
    }
}
