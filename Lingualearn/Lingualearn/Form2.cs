using AIMLbot.AIMLTagHandlers;
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
    
    public partial class Form2 : Form
    {
        public static string name { get; set; }
        public static Form2 instance;
        public Form2()
        {
            InitializeComponent();
            instance = this;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                textBox1.ForeColor = Color.Black;
                panel4.Visible = false;
            }
            catch { }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
               
                textBox2.ForeColor = Color.Black;
                textBox2.PasswordChar = '*';
                panel6.Visible = false;
            }
            catch { }
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            textBox2.SelectAll();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text== "Enter Username" || textBox1.Text=="")
            { panel4.Visible = true;
                textBox1.Focus();
                return;

            }
            if (!(textBox1.Text.Length >= 6 && textBox1.Text.Length<=8 && textBox1.Text.Any(char.IsUpper) && textBox1.Text.Any(char.IsLower) && !textBox1.Text.Any(char.IsDigit)))
            {
                label3.Text = "Username does not meet the requirement:\n";
                panel4.Visible = true;
                textBox1.Focus();
                return;
            }

            if (textBox2.Text == "Enter Password" || textBox2.Text == "")
            {
                panel6.Visible = true;
                textBox2.Focus();
                return;

            }

            if (!(textBox2.Text.Length >= 8 && textBox2.Text.Length<=12 && textBox2.Text.Any(char.IsUpper) && textBox2.Text.Any(char.IsLower) && textBox2.Text.Any(char.IsDigit)))
            {
                label4.Text = "Password does not meet the requirement:\n";
                panel6.Visible = true;
                textBox2.Focus();
                return;
            }
            else
            {
                name=textBox1.Text;
                this.Hide();
                Form7 f7 = new Form7();
                f7.ShowDialog();
            }
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "Enter Username" || textBox3.Text == "")
            {
                panel11.Visible = true;
                textBox3.Focus();
                return;

            }
            if (!(textBox3.Text.Length >= 6 && textBox3.Text.Length <=8 && textBox3.Text.Any(char.IsUpper) && textBox3.Text.Any(char.IsLower) && !textBox3.Text.Any(char.IsDigit)))
            {
                label7.Text = "Username does not meet the requirement:\n";
                panel11.Visible = true;
                textBox3.Focus();
                return;
            }

            if (textBox4.Text == "Enter Password" || textBox4.Text == "")
            {
                panel15.Visible = true;
                textBox4.Focus();
                return;

            }

            if (!(textBox4.Text.Length >= 8 && textBox4.Text.Length <= 12 && textBox4.Text.Any(char.IsUpper) && textBox4.Text.Any(char.IsLower) && textBox4.Text.Any(char.IsDigit)))
            {
                label9.Text = "Password does not meet the requirement:\n";
                panel15.Visible = true;
                textBox4.Focus();
                return;
            }

            if (textBox5.Text == "Confirm Password" || textBox5.Text == "" || textBox5.Text!=textBox4.Text)
            {
                panel19.Visible = true;
                textBox5.Focus();
                return;

            }
            
            else
            {
                name=textBox3.Text;
                this.Hide();
                Form7 f7 = new Form7();
                f7.ShowDialog();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {

                textBox3.ForeColor = Color.Black;
                panel11.Visible = false;
            }
            catch { }

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {

                textBox4.ForeColor = Color.Black;
                textBox4.PasswordChar = '*';
                panel15.Visible = false;
            }
            catch { }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            try
            {

                textBox5.ForeColor = Color.Black;
                textBox5.PasswordChar = '*';
                panel19.Visible = false;
            }
            catch { }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            textBox3.SelectAll();
        }

        private void textBox4_Click(object sender, EventArgs e)
        {
            textBox4.SelectAll();
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            textBox5.SelectAll();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel9.Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            panel9.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            name = "Google login";
            this.Hide();
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            name = "Facebook Login";
            this.Hide();
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
