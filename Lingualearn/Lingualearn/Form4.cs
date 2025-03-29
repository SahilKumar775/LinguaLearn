using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
using static System.Windows.Forms.
    VisualStyles.VisualStyleInformation;

namespace Se_iteration01
{
    
    public partial class Form4 : Form
    {
        private SpeechRecognitionEngine recognitionEngine;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
            
        }

     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SpeechRecognitionEngine speechRecognitionEngine = new SpeechRecognitionEngine();
            Grammar words= new DictationGrammar();
            speechRecognitionEngine.LoadGrammar(words);
            try
            {
                speechRecognitionEngine.SetInputToDefaultAudioDevice();
                RecognitionResult result = speechRecognitionEngine.Recognize();
                textBox1.Text = result.Text;
            }
            catch (Exception ex) { 
                MessageBox.Show(ex.Message);
            }
            finally
            {
                speechRecognitionEngine.UnloadAllGrammars();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f5 = new Form8();
            f5.ShowDialog();
        }
    }
}
