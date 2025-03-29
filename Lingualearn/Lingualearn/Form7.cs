using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Se_iteration01
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
            string f = "Lingualearn.mp4";
            axWindowsMediaPlayer2.URL = f;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            //axWindowsMediaPlayer2.URL="";
            this.Hide();
            Form9 f9 = new Form9();
            f9.ShowDialog();
        }

        private void axWindowsMediaPlayer2_Enter(object sender, EventArgs e)
        {

        }
    }
}
