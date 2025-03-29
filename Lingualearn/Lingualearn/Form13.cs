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
    public partial class Form13 : Form
    {
        public Form13()
        {
            InitializeComponent();
            progressBar1.Value = Form3.ff3 + Form5.ff4 + Form6.ff5 + Form12.ff6;
            label1.Text = progressBar1.Value.ToString() + "%";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f5 = new Form8();
            f5.ShowDialog();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
