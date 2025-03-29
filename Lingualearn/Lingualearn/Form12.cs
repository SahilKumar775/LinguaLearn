using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Web;
using System.Net;
using AIMLbot.AIMLTagHandlers;

namespace Se_iteration01
{
    public partial class Form12 : Form
    {
        public static int ff6 { get; set; }
        SpeechSynthesizer TexttoSpeech = new SpeechSynthesizer();
        string to;
        string from;
        public Form12()
        {
            InitializeComponent();
            from = Form9.t1;
            to = Form10.t2;
            timer1.Interval = 60000;
            string lines = rjButton3.Text;
            string translatedLine = translate(lines, "en", to);
            rjButton3.Text= translatedLine;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        public String translate(String input, string from, string to)
        {
            var fromLanguage = from;
            var toLanguage = to;
            var url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={fromLanguage}&tl={toLanguage}&dt=t&q={HttpUtility.UrlEncode(input)}";
            var webclient = new WebClient
            {
                Encoding = System.Text.Encoding.UTF8
            };
            var result = webclient.DownloadString(url);
            try
            {
                result = result.Substring(4, result.IndexOf("\"", 4
                    , StringComparison.Ordinal) - 4);
                return result;
            }
            catch
            {
                return "error";
            }


        }

        private void Contact_Click(object sender, EventArgs e)
        {
            string[] lines = textBox3.Lines;
            for (int i = 0; i < 30; i++)
            {
                string translatedLine = translate(lines[i], "en", to);
                textBox4.Text += translatedLine + Environment.NewLine;
                string translatedLine2 = translate(lines[i], "en", from);
                textBox5.Text += translatedLine2 + Environment.NewLine;
            }
            textBox4.Visible = true;
            textBox5.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f5 = new Form8();
            f5.ShowDialog();
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ff6 < 20)
            {
                ff6 += 1;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            TexttoSpeech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo(to));
            TexttoSpeech.SpeakAsync(rjButton3.Text);
        }
    }
}
