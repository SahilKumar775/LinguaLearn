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
    public partial class Account : Form
    {
        public Account()
        {
            
            InitializeComponent();
            comboBox1.Text = Form9.your;
            comboBox2.Text = Form10.learn;
            button6.Text = Form2.name;
            progressBar1.Value = Form3.ff3 + Form5.ff4 + Form6.ff5 + Form12.ff6;
            label1.Text = progressBar1.Value.ToString() + "%";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 f8 = new Form10();
            f8.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f9 = new Form9();
            f9.ShowDialog();
        }
        
        private void Account_Load(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form9.your = comboBox1.Text;
            if (comboBox1.Text == "Afrikaans")
            {
                Form9.t1 = "af";
            }
            else if (comboBox1.Text == "Albanian")
            {
                Form9.t1 = "sq";
            }
            else if (comboBox1.Text == "Amharic")
            {
                Form9.t1 = "sl";
            }
            else if (comboBox1.Text == "Arabic")
            {
                Form9.t1 = "ar";
            }
            else if (comboBox1.Text == "Armenian")
            {
                Form9.t1 = "hy";
            }
            else if (comboBox1.Text == "Assamese")
            {
                Form9.t1 = "as";
            }
            else if (comboBox1.Text == "Aymara")
            {
                Form9.t1 = "ay";
            }
            else if (comboBox1.Text == "Azerbaijani")
            {
                Form9.t1 = "az";
            }
            else if (comboBox1.Text == "Bambara")
            {
                Form9.t1 = "bm";
            }
            else if (comboBox1.Text == "Bengali")
            {
                Form9.t1 = "bn";
            }
            else if (comboBox1.Text == "Basque")
            {
                Form9.t1 = "eu";
            }
            else if (comboBox1.Text == "Belarusian")
            {
                Form9.t1 = "be";
            }
            else if (comboBox1.Text == "Bhojpuri")
            {
                Form9.t1 = "bho";
            }
            else if (comboBox1.Text == "Bosnian")
            {
                Form9.t1 = "bs";
            }
            else if (comboBox1.Text == "Bulgarian")
            {
                Form9.t1 = "bg";
            }

            else if (comboBox1.Text == "Catalan")
            {
                Form9.t1 = "ca";
            }
            else if (comboBox1.Text == "Cebuano")
            {
                Form9.t1 = "ceb";
            }
            else if (comboBox1.Text == "Chichewa")
            {
                Form9.t1 = "ny";
            }

            else if (comboBox1.Text == "Chinese (Simplified)")
            {
                Form9.t1 = "zh-CN";
            }
            else if (comboBox1.Text == "Chinese (Traditional)")
            {
                Form9.t1 = "zh-TW";
            }
            else if (comboBox1.Text == "Corsican")
            {
                Form9.t1 = "co";
            }
            else if (comboBox1.Text == "Croatian")
            {
                Form9.t1 = "hr";
            }
            else if (comboBox1.Text == "Czech")
            {
                Form9.t1 = "cs";
            }
            else if (comboBox1.Text == "Danish")
            {
                Form9.t1 = "da";
            }
            else if (comboBox1.Text == "Divehi")
            {
                Form9.t1 = "dv";
            }
            else if (comboBox1.Text == "Dogri")
            {
                Form9.t1 = "doi";
            }
            else if (comboBox1.Text == "Dutch")
            {
                Form9.t1 = "nl";
            }
            else if (comboBox1.Text == "English")
            {
                Form9.t1 = "en";
            }
            else if (comboBox1.Text == "Esperanto")
            {
                Form9.t1 = "eo";
            }
            else if (comboBox1.Text == "Estonian")
            {
                Form9.t1 = "et";
            }
            else if (comboBox1.Text == "Ewe")
            {
                Form9.t1 = "ee";
            }
            else if (comboBox1.Text == "Filipino")
            {
                Form9.t1 = "tl";
            }
            else if (comboBox1.Text == "Finnish")
            {
                Form9.t1 = "fi";
            }
            else if (comboBox1.Text == "French")
            {
                Form9.t1 = "fr";
            }
            else if (comboBox1.Text == "Frisian")
            {
                Form9.t1 = "fy";
            }
            else if (comboBox1.Text == "Galician")
            {
                Form9.t1 = "gl";
            }

            else if (comboBox1.Text == "Georgian")
            {
                Form9.t1 = "ka";
            }
            else if (comboBox1.Text == "German")
            {
                Form9.t1 = "de";
            }
            else if (comboBox1.Text == "Goan Konkani")
            {
                Form9.t1 = "ko";
            }
            else if (comboBox1.Text == "Greek")
            {
                Form9.t1 = "el";
            }
            else if (comboBox1.Text == "Guarani")
            {
                Form9.t1 = "gn";
            }
            else if (comboBox1.Text == "Gujarati")
            {
                Form9.t1 = "gu";
            }
            else if (comboBox1.Text == "Haitian Creole")
            {
                Form9.t1 = "ht";
            }
            else if (comboBox1.Text == "Hausa")
            {
                Form9.t1 = "ha";
            }
            else if (comboBox1.Text == "Hawaiian")
            {
                Form9.t1 = "haw";
            }
            else if (comboBox1.Text == "Hebrew")
            {
                Form9.t1 = "iw";
            }
            else if (comboBox1.Text == "Hindi")
            {
                Form9.t1 = "hi";
            }
            else if (comboBox1.Text == "Hmong")
            {
                Form9.t1 = "hmn";
            }
            else if (comboBox1.Text == "Hungarian")
            {
                Form9.t1 = "hu";
            }
            else if (comboBox1.Text == "Icelandic")
            {
                Form9.t1 = "is";
            }
            else if (comboBox1.Text == "Igbo")
            {
                Form9.t1 = "ig";
            }
            else if (comboBox1.Text == "Iloko")
            {
                Form9.t1 = "ilo";
            }
            else if (comboBox1.Text == "Indonesian")
            {
                Form9.t1 = "id";
            }
            else if (comboBox1.Text == "Irish")
            {
                Form9.t1 = "ga";
            }
            else if (comboBox1.Text == "Italian")
            {
                Form9.t1 = "it";
            }
            else if (comboBox1.Text == "Japanese")
            {
                Form9.t1 = "ja";
            }
            else if (comboBox1.Text == "Javanese")
            {
                Form9.t1 = "jw";
            }
            else if (comboBox1.Text == "Kannada")
            {
                Form9.t1 = "kn";
            }
            else if (comboBox1.Text == "Kazakh")
            {
                Form9.t1 = "kk";
            }
            else if (comboBox1.Text == "Khmer")
            {
                Form9.t1 = "km";
            }
            else if (comboBox1.Text == "Kinyarwanda")
            {
                Form9.t1 = "rw";
            }
            else if (comboBox1.Text == "Konkani")
            {
                Form9.t1 = "gom";
            }
            else if (comboBox1.Text == "Korean")
            {
                Form9.t1 = "ko";
            }
            else if (comboBox1.Text == "Krio")
            {
                Form9.t1 = "kri";
            }
            else if (comboBox1.Text == "Kurdish (Kurmanji)")
            {
                Form9.t1 = "ku";
            }
            else if (comboBox1.Text == "Kurdish (Sorani)")
            {
                Form9.t1 = "ckb";
            }
            else if (comboBox1.Text == "Kyrgyz")
            {
                Form9.t1 = "ky";
            }
            else if (comboBox1.Text == "Lao")
            {
                Form9.t1 = "lo";
            }
            else if (comboBox1.Text == "Latin")
            {
                Form9.t1 = "la";
            }
            else if (comboBox1.Text == "Latvian")
            {
                Form9.t1 = "lv";
            }
            else if (comboBox1.Text == "Lingala")
            {
                Form9.t1 = "ln";
            }
            else if (comboBox1.Text == "Lithuanian")
            {
                Form9.t1 = "lt";
            }
            else if (comboBox1.Text == "Luganda")
            {
                Form9.t1 = "lg";
            }
            else if (comboBox1.Text == "Luxembourgish")
            {
                Form9.t1 = "lb";
            }
            else if (comboBox1.Text == "Macedonian")
            {
                Form9.t1 = "mk";
            }
            else if (comboBox1.Text == "Maithili")
            {
                Form9.t1 = "mai";
            }
            else if (comboBox1.Text == "Malagasy")
            {
                Form9.t1 = "mg";
            }
            else if (comboBox1.Text == "Malay")
            {
                Form9.t1 = "ms";
            }
            else if (comboBox1.Text == "Malayalam")
            {
                Form9.t1 = "ml";
            }
            else if (comboBox1.Text == "Maltese")
            {
                Form9.t1 = "mt";
            }
            else if (comboBox1.Text == "Meiteilon (Manipuri)")
            {
                Form9.t1 = "mni";
            }
            else if (comboBox1.Text == "Maori")
            {
                Form9.t1 = "mi";
            }
            else if (comboBox1.Text == "Marathi")
            {
                Form9.t1 = "mr";
            }
            else if (comboBox1.Text == "Mizo")
            {
                Form9.t1 = "lus";
            }
            else if (comboBox1.Text == "Mongolian")
            {
                Form9.t1 = "mn";
            }
            else if (comboBox1.Text == "Myanmar (Burmese)")
            {
                Form9.t1 = "my";
            }
            else if (comboBox1.Text == "Nepali")
            {
                Form9.t1 = "ne";
            }

            else if (comboBox1.Text == "Norwegian")
            {
                Form9.t1 = "no";
            }

            else if (comboBox1.Text == "Odia (Oriya)")
            {
                Form9.t1 = "or";
            }
            else if (comboBox1.Text == "Oromo")
            {
                Form9.t1 = "om";
            }
            else if (comboBox1.Text == "Pashto")
            {
                Form9.t1 = "ps";
            }
            else if (comboBox1.Text == "Persian")
            {
                Form9.t1 = "fa";
            }
            else if (comboBox1.Text == "Polish")
            {
                Form9.t1 = "pl";
            }
            else if (comboBox1.Text == "Portuguese")
            {
                Form9.t1 = "pt";
            }
            else if (comboBox1.Text == "Punjabi")
            {
                Form9.t1 = "pa";
            }
            else if (comboBox1.Text == "Quechua")
            {
                Form9.t1 = "qu";
            }
            else if (comboBox1.Text == "Romanian")
            {
                Form9.t1 = "ro";
            }
            else if (comboBox1.Text == "Russian")
            {
                Form9.t1 = "ru";
            }
            else if (comboBox1.Text == "Samoan")
            {
                Form9.t1 = "asm";
            }
            else if (comboBox1.Text == "Sanskrit")
            {
                Form9.t1 = "sa";
            }
            else if (comboBox1.Text == "Scots Gaeelic")
            {
                Form9.t1 = "gd";
            }
            else if (comboBox1.Text == "Sepedi")
            {
                Form9.t1 = "nso";
            }
            else if (comboBox1.Text == "Serbian")
            {
                Form9.t1 = "sr";
            }
            else if (comboBox1.Text == "Sesotho")
            {
                Form9.t1 = "st";
            }
            else if (comboBox1.Text == "Shona")
            {
                Form9.t1 = "sn";
            }
            else if (comboBox1.Text == "Sindhi")
            {
                Form9.t1 = "sd";
            }
            else if (comboBox1.Text == "Sinhala")
            {
                Form9.t1 = "si";
            }
            else if (comboBox1.Text == "Slovak")
            {
                Form9.t1 = "sk";
            }
            else if (comboBox1.Text == "Slovenian")
            {
                Form9.t1 = "sl";
            }
            else if (comboBox1.Text == "Somali")
            {
                Form9.t1 = "so";
            }
            else if (comboBox1.Text == "Spanish")
            {
                Form9.t1 = "es";
            }
            else if (comboBox1.Text == "Sundanese")
            {
                Form9.t1 = "su";
            }
            else if (comboBox1.Text == "Swahili")
            {
                Form9.t1 = "sw";
            }
            else if (comboBox1.Text == "Swedish")
            {
                Form9.t1 = "sv";
            }
            else if (comboBox1.Text == "Tajik")
            {
                Form9.t1 = "tg";
            }
            else if (comboBox1.Text == "Tamil")
            {
                Form9.t1 = "ta";
            }
            else if (comboBox1.Text == "Tatar")
            {
                Form9.t1 = "tt";
            }
            else if (comboBox1.Text == "Telugu")
            {
                Form9.t1 = "te";
            }
            else if (comboBox1.Text == "Thai")
            {
                Form9.t1 = "th";
            }
            else if (comboBox1.Text == "Tigrinya")
            {
                Form9.t1 = "ti";
            }
            else if (comboBox1.Text == "Tsonga")
            {
                Form9.t1 = "ts";
            }
            else if (comboBox1.Text == "Turkish")
            {
                Form9.t1 = "tr";
            }
            else if (comboBox1.Text == "Turkmen")
            {
                Form9.t1 = "tk";
            }
            else if (comboBox1.Text == "Twi")
            {
                Form9.t1 = "ak";
            }
            else if (comboBox1.Text == "Ukrainian")
            {
                Form9.t1 = "uk";
            }
            else if (comboBox1.Text == "Urdu")
            {
                Form9.t1 = "ur";
            }
            else if (comboBox1.Text == "Uygher")
            {
                Form9.t1 = "ug";
            }
            else if (comboBox1.Text == "Uzbek")
            {
                Form9.t1 = "uz";
            }
            else if (comboBox1.Text == "Vietnamese")
            {
                Form9.t1 = "vi";
            }
            else if (comboBox1.Text == "Welsh")
            {
                Form9.t1 = "cy";
            }

            else if (comboBox1.Text == "Xhosa")
            {
                Form9.t1 = "xh";
            }
            else if (comboBox1.Text == "Yiddish")
            {
                Form9.t1 = "yi";
            }
            else if (comboBox1.Text == "Yoruba")
            {
                Form9.t1 = "yo";
            }
            else if (comboBox1.Text == "Zulu")
            {
                Form9.t1 = "zu";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form10.learn=comboBox2.Text;
            if (comboBox2.Text == "Afrikaans")
            {
                Form10.t2 = "af";
            }
            else if (comboBox2.Text == "Albanian")
            {
                Form10.t2 = "sq";
            }
            else if (comboBox2.Text == "Amharic")
            {
                Form10.t2 = "sl";
            }
            else if (comboBox2.Text == "Arabic")
            {
                Form10.t2 = "ar";
            }
            else if (comboBox2.Text == "Armenian")
            {
                Form10.t2 = "hy";
            }
            else if (comboBox2.Text == "Assamese")
            {
                Form10.t2 = "as";
            }
            else if (comboBox2.Text == "Aymara")
            {
                Form10.t2 = "ay";
            }
            else if (comboBox2.Text == "Azerbaijani")
            {
                Form10.t2 = "az";
            }
            else if (comboBox2.Text == "Bambara")
            {
                Form10.t2 = "bm";
            }
            else if (comboBox2.Text == "Bengali")
            {
                Form10.t2 = "bn";
            }
            else if (comboBox2.Text == "Basque")
            {
                Form10.t2 = "eu";
            }
            else if (comboBox2.Text == "Belarusian")
            {
                Form10.t2 = "be";
            }
            else if (comboBox2.Text == "Bhojpuri")
            {
                Form10.t2 = "bho";
            }
            else if (comboBox2.Text == "Bosnian")
            {
                Form10.t2 = "bs";
            }
            else if (comboBox2.Text == "Bulgarian")
            {
                Form10.t2 = "bg";
            }

            else if (comboBox2.Text == "Catalan")
            {
                Form10.t2 = "ca";
            }
            else if (comboBox2.Text == "Cebuano")
            {
                Form10.t2 = "ceb";
            }
            else if (comboBox2.Text == "Chichewa")
            {
                Form10.t2 = "ny";
            }

            else if (comboBox2.Text == "Chinese (Simplified)")
            {
                Form10.t2 = "zh-CN";
            }
            else if (comboBox2.Text == "Chinese (Traditional)")
            {
                Form10.t2 = "zh-TW";
            }
            else if (comboBox2.Text == "Corsican")
            {
                Form10.t2 = "co";
            }
            else if (comboBox2.Text == "Croatian")
            {
                Form10.t2 = "hr";
            }
            else if (comboBox2.Text == "Czech")
            {
                Form10.t2 = "cs";
            }
            else if (comboBox2.Text == "Danish")
            {
                Form10.t2 = "da";
            }
            else if (comboBox2.Text == "Divehi")
            {
                Form10.t2 = "dv";
            }
            else if (comboBox2.Text == "Dogri")
            {
                Form10.t2 = "doi";
            }
            else if (comboBox2.Text == "Dutch")
            {
                Form10.t2 = "nl";
            }
            else if (comboBox2.Text == "English")
            {
                Form10.t2 = "en";
            }
            else if (comboBox2.Text == "Esperanto")
            {
                Form10.t2 = "eo";
            }
            else if (comboBox2.Text == "Estonian")
            {
                Form10.t2 = "et";
            }
            else if (comboBox2.Text == "Ewe")
            {
                Form10.t2 = "ee";
            }
            else if (comboBox2.Text == "Filipino")
            {
                Form10.t2 = "tl";
            }
            else if (comboBox2.Text == "Finnish")
            {
                Form10.t2 = "fi";
            }
            else if (comboBox2.Text == "French")
            {
                Form10.t2 = "fr";
            }
            else if (comboBox2.Text == "Frisian")
            {
                Form10.t2 = "fy";
            }
            else if (comboBox2.Text == "Galician")
            {
                Form10.t2 = "gl";
            }

            else if (comboBox2.Text == "Georgian")
            {
                Form10.t2 = "ka";
            }
            else if (comboBox2.Text == "German")
            {
                Form10.t2 = "de";
            }
            else if (comboBox2.Text == "Goan Konkani")
            {
                Form10.t2 = "ko";
            }
            else if (comboBox2.Text == "Greek")
            {
                Form10.t2 = "el";
            }
            else if (comboBox2.Text == "Guarani")
            {
                Form10.t2 = "gn";
            }
            else if (comboBox2.Text == "Gujarati")
            {
                Form10.t2 = "gu";
            }
            else if (comboBox2.Text == "Haitian Creole")
            {
                Form10.t2 = "ht";
            }
            else if (comboBox2.Text == "Hausa")
            {
                Form10.t2 = "ha";
            }
            else if (comboBox2.Text == "Hawaiian")
            {
                Form10.t2 = "haw";
            }
            else if (comboBox2.Text == "Hebrew")
            {
                Form10.t2 = "iw";
            }
            else if (comboBox2.Text == "Hindi")
            {
                Form10.t2 = "hi";
            }
            else if (comboBox2.Text == "Hmong")
            {
                Form10.t2 = "hmn";
            }
            else if (comboBox2.Text == "Hungarian")
            {
                Form10.t2 = "hu";
            }
            else if (comboBox2.Text == "Icelandic")
            {
                Form10.t2 = "is";
            }
            else if (comboBox2.Text == "Igbo")
            {
                Form10.t2 = "ig";
            }
            else if (comboBox2.Text == "Iloko")
            {
                Form10.t2 = "ilo";
            }
            else if (comboBox2.Text == "Indonesian")
            {
                Form10.t2 = "id";
            }
            else if (comboBox2.Text == "Irish")
            {
                Form10.t2 = "ga";
            }
            else if (comboBox2.Text == "Italian")
            {
                Form10.t2 = "it";
            }
            else if (comboBox2.Text == "Japanese")
            {
                Form10.t2 = "ja";
            }
            else if (comboBox2.Text == "Javanese")
            {
                Form10.t2 = "jw";
            }
            else if (comboBox2.Text == "Kannada")
            {
                Form10.t2 = "kn";
            }
            else if (comboBox2.Text == "Kazakh")
            {
                Form10.t2 = "kk";
            }
            else if (comboBox2.Text == "Khmer")
            {
                Form10.t2 = "km";
            }
            else if (comboBox2.Text == "Kinyarwanda")
            {
                Form10.t2 = "rw";
            }
            else if (comboBox2.Text == "Konkani")
            {
                Form10.t2 = "gom";
            }
            else if (comboBox2.Text == "Korean")
            {
                Form10.t2 = "ko";
            }
            else if (comboBox2.Text == "Krio")
            {
                Form10.t2 = "kri";
            }
            else if (comboBox2.Text == "Kurdish (Kurmanji)")
            {
                Form10.t2 = "ku";
            }
            else if (comboBox2.Text == "Kurdish (Sorani)")
            {
                Form10.t2 = "ckb";
            }
            else if (comboBox2.Text == "Kyrgyz")
            {
                Form10.t2 = "ky";
            }
            else if (comboBox2.Text == "Lao")
            {
                Form10.t2 = "lo";
            }
            else if (comboBox2.Text == "Latin")
            {
                Form10.t2 = "la";
            }
            else if (comboBox2.Text == "Latvian")
            {
                Form10.t2 = "lv";
            }
            else if (comboBox2.Text == "Lingala")
            {
                Form10.t2 = "ln";
            }
            else if (comboBox2.Text == "Lithuanian")
            {
                Form10.t2 = "lt";
            }
            else if (comboBox2.Text == "Luganda")
            {
                Form10.t2 = "lg";
            }
            else if (comboBox2.Text == "Luxembourgish")
            {
                Form10.t2 = "lb";
            }
            else if (comboBox2.Text == "Macedonian")
            {
                Form10.t2 = "mk";
            }
            else if (comboBox2.Text == "Maithili")
            {
                Form10.t2 = "mai";
            }
            else if (comboBox2.Text == "Malagasy")
            {
                Form10.t2 = "mg";
            }
            else if (comboBox2.Text == "Malay")
            {
                Form10.t2 = "ms";
            }
            else if (comboBox2.Text == "Malayalam")
            {
                Form10.t2 = "ml";
            }
            else if (comboBox2.Text == "Maltese")
            {
                Form10.t2 = "mt";
            }
            else if (comboBox2.Text == "Meiteilon (Manipuri)")
            {
                Form10.t2 = "mni";
            }
            else if (comboBox2.Text == "Maori")
            {
                Form10.t2 = "mi";
            }
            else if (comboBox2.Text == "Marathi")
            {
                Form10.t2 = "mr";
            }
            else if (comboBox2.Text == "Mizo")
            {
                Form10.t2 = "lus";
            }
            else if (comboBox2.Text == "Mongolian")
            {
                Form10.t2 = "mn";
            }
            else if (comboBox2.Text == "Myanmar (Burmese)")
            {
                Form10.t2 = "my";
            }
            else if (comboBox2.Text == "Nepali")
            {
                Form10.t2 = "ne";
            }

            else if (comboBox2.Text == "Norwegian")
            {
                Form10.t2 = "no";
            }

            else if (comboBox2.Text == "Odia (Oriya)")
            {
                Form10.t2 = "or";
            }
            else if (comboBox2.Text == "Oromo")
            {
                Form10.t2 = "om";
            }
            else if (comboBox2.Text == "Pashto")
            {
                Form10.t2 = "ps";
            }
            else if (comboBox2.Text == "Persian")
            {
                Form10.t2 = "fa";
            }
            else if (comboBox2.Text == "Polish")
            {
                Form10.t2 = "pl";
            }
            else if (comboBox2.Text == "Portuguese")
            {
                Form10.t2 = "pt";
            }
            else if (comboBox2.Text == "Punjabi")
            {
                Form10.t2 = "pa";
            }
            else if (comboBox2.Text == "Quechua")
            {
                Form10.t2 = "qu";
            }
            else if (comboBox2.Text == "Romanian")
            {
                Form10.t2 = "ro";
            }
            else if (comboBox2.Text == "Russian")
            {
                Form10.t2 = "ru";
            }
            else if (comboBox2.Text == "Samoan")
            {
                Form10.t2 = "asm";
            }
            else if (comboBox2.Text == "Sanskrit")
            {
                Form10.t2 = "sa";
            }
            else if (comboBox2.Text == "Scots Gaeelic")
            {
                Form10.t2 = "gd";
            }
            else if (comboBox2.Text == "Sepedi")
            {
                Form10.t2 = "nso";
            }
            else if (comboBox2.Text == "Serbian")
            {
                Form10.t2 = "sr";
            }
            else if (comboBox2.Text == "Sesotho")
            {
                Form10.t2 = "st";
            }
            else if (comboBox2.Text == "Shona")
            {
                Form10.t2 = "sn";
            }
            else if (comboBox2.Text == "Sindhi")
            {
                Form10.t2 = "sd";
            }
            else if (comboBox2.Text == "Sinhala")
            {
                Form10.t2 = "si";
            }
            else if (comboBox2.Text == "Slovak")
            {
                Form10.t2 = "sk";
            }
            else if (comboBox2.Text == "Slovenian")
            {
                Form10.t2 = "sl";
            }
            else if (comboBox2.Text == "Somali")
            {
                Form10.t2 = "so";
            }

            else if (comboBox2.Text == "Spanish")
            {
                Form10.t2 = "es";
            }
            else if (comboBox2.Text == "Sundanese")
            {
                Form10.t2 = "su";
            }
            else if (comboBox2.Text == "Swahili")
            {
                Form10.t2 = "sw";
            }
            else if (comboBox2.Text == "Swedish")
            {
                Form10.t2 = "sv";
            }
            else if (comboBox2.Text == "Tajik")
            {
                Form10.t2 = "tg";
            }
            else if (comboBox2.Text == "Tamil")
            {
                Form10.t2 = "ta";
            }
            else if (comboBox2.Text == "Tatar")
            {
                Form10.t2 = "tt";
            }
            else if (comboBox2.Text == "Telugu")
            {
                Form10.t2 = "te";
            }
            else if (comboBox2.Text == "Thai")
            {
                Form10.t2 = "th";
            }
            else if (comboBox2.Text == "Tigrinya")
            {
                Form10.t2 = "ti";
            }
            else if (comboBox2.Text == "Tsonga")
            {
                Form10.t2 = "ts";
            }
            else if (comboBox2.Text == "Turkish")
            {
                Form10.t2 = "tr";
            }
            else if (comboBox2.Text == "Turkmen")
            {
                Form10.t2 = "tk";
            }
            else if (comboBox2.Text == "Twi")
            {
                Form10.t2 = "ak";
            }
            else if (comboBox2.Text == "Ukrainian")
            {
                Form10.t2 = "uk";
            }
            else if (comboBox2.Text == "Urdu")
            {
                Form10.t2 = "ur";
            }
            else if (comboBox2.Text == "Uygher")
            {
                Form10.t2 = "ug";
            }
            else if (comboBox2.Text == "Uzbek")
            {
                Form10.t2 = "uz";
            }
            else if (comboBox2.Text == "Vietnamese")
            {
                Form10.t2 = "vi";
            }
            else if (comboBox2.Text == "Welsh")
            {
                Form10.t2 = "cy";
            }

            else if (comboBox2.Text == "Xhosa")
            {
                Form10.t2 = "xh";
            }
            else if (comboBox2.Text == "Yiddish")
            {
                Form10.t2 = "yi";
            }
            else if (comboBox2.Text == "Yoruba")
            {
                Form10.t2 = "yo";
            }
            else if (comboBox2.Text == "Zulu")
            {
                Form10.t2 = "zu";
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
