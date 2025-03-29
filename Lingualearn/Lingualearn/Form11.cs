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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void pdfViewer1_Click(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Pdf File|*.pdf";
            opf.InitialDirectory = @""; // Set the initial directory

            if (opf.ShowDialog() == DialogResult.OK)
            {
                    this.pdfViewer1.LoadFromFile(opf.FileName);                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f5 = new Form8();
            f5.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f5 = new Form8();
            f5.ShowDialog();

        }
    }
}
