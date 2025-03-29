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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle = 0x02000000;
                return handleParam;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void rjButton5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void rjButton10_Click(object sender, EventArgs e)
        {
            this.Hide();
            Account f8 = new Account();
            f8.ShowDialog();
        }

        private void rjButton9_Click(object sender, EventArgs e)
        {
            this.Hide();
            Account f8 = new Account();
            f8.ShowDialog();
        }

        private void rjButton5_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form12 f5 = new Form12();
            f5.ShowDialog();
        }

        private void rjButton8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form13 f13 = new Form13();
            f13.ShowDialog();
        }

        private void rjButton7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 f11 = new Form11();
            f11.ShowDialog();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
    }
}
