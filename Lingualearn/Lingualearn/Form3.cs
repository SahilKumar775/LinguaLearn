using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Web;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AIMLbot;
using System.Web;
using System.Net;
using System.Speech;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Threading;
namespace Se_iteration01
{
    public partial class Form3 : Form
    {
        public static Form3 instance;
        SpeechSynthesizer TexttoSpeech = new SpeechSynthesizer();
        string text;
        public static int ff3 { get; set; }
        string from;
        string to;
        public Form3()
        {
            InitializeComponent();
            instance = this;
            from = Form9.t1;
            to = Form10.t2;
            timer1.Interval = 60000;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Afrikaans")
            {
                from = "af";
            }
            else if (comboBox1.Text == "Albanian")
            {
                from = "sq";
            }
            else if (comboBox1.Text == "Amharic")
            {
                from = "sl";
            }
            else if (comboBox1.Text == "Arabic")
            {
                from = "ar";
            }
            else if (comboBox1.Text == "Armenian")
            {
                from = "hy";
            }
            else if (comboBox1.Text == "Assamese")
            {
                from = "as";
            }
            else if (comboBox1.Text == "Aymara")
            {
                from = "ay";
            }
            else if (comboBox1.Text == "Azerbaijani")
            {
                from = "az";
            }
            else if (comboBox1.Text == "Bambara")
            {
                from = "bm";
            }
            else if (comboBox1.Text == "Bengali")
            {
                from = "bn";
            }
            else if (comboBox1.Text == "Basque")
            {
                from = "eu";
            }
            else if (comboBox1.Text == "Belarusian")
            {
                from = "be";
            }
            else if (comboBox1.Text == "Bhojpuri")
            {
                from = "bho";
            }
            else if (comboBox1.Text == "Bosnian")
            {
                from = "bs";
            }
            else if (comboBox1.Text == "Bulgarian")
            {
                from = "bg";
            }

            else if (comboBox1.Text == "Catalan")
            {
                from = "ca";
            }
            else if (comboBox1.Text == "Cebuano")
            {
                from = "ceb";
            }
            else if (comboBox1.Text == "Chichewa")
            {
                from = "ny";
            }

            else if (comboBox1.Text == "Chinese (Simplified)")
            {
                from = "zh-CN";
            }
            else if (comboBox1.Text == "Chinese (Traditional)")
            {
                from = "zh-TW";
            }
            else if (comboBox1.Text == "Corsican")
            {
                from = "co";
            }
            else if (comboBox1.Text == "Croatian")
            {
                from = "hr";
            }
            else if (comboBox1.Text == "Czech")
            {
                from = "cs";
            }
            else if (comboBox1.Text == "Danish")
            {
                from = "da";
            }
            else if (comboBox1.Text == "Divehi")
            {
                from = "dv";
            }
            else if (comboBox1.Text == "Dogri")
            {
                from = "doi";
            }
            else if (comboBox1.Text == "Dutch")
            {
                from = "nl";
            }
            else if (comboBox1.Text == "English")
            {
                from = "en";
            }
            else if (comboBox1.Text == "Esperanto")
            {
                from = "eo";
            }
            else if (comboBox1.Text == "Estonian")
            {
                from = "et";
            }
            else if (comboBox1.Text == "Ewe")
            {
                from = "ee";
            }
            else if (comboBox1.Text == "Filipino")
            {
                from = "tl";
            }
            else if (comboBox1.Text == "Finnish")
            {
                from = "fi";
            }
            else if (comboBox1.Text == "French")
            {
                from = "fr";
            }
            else if (comboBox1.Text == "Frisian")
            {
                from = "fy";
            }
            else if (comboBox1.Text == "Galician")
            {
                from = "gl";
            }

            else if (comboBox1.Text == "Georgian")
            {
                from = "ka";
            }
            else if (comboBox1.Text == "German")
            {
                from = "de";
            }
            else if (comboBox1.Text == "Goan Konkani")
            {
                from = "ko";
            }
            else if (comboBox1.Text == "Greek")
            {
                from = "el";
            }
            else if (comboBox1.Text == "Guarani")
            {
                from = "gn";
            }
            else if (comboBox1.Text == "Gujarati")
            {
                from = "gu";
            }
            else if (comboBox1.Text == "Haitian Creole")
            {
                from = "ht";
            }
            else if (comboBox1.Text == "Hausa")
            {
                from = "ha";
            }
            else if (comboBox1.Text == "Hawaiian")
            {
                from = "haw";
            }
            else if (comboBox1.Text == "Hebrew")
            {
                from = "iw";
            }
            else if (comboBox1.Text == "Hindi")
            {
                from = "hi";
            }
            else if (comboBox1.Text == "Hmong")
            {
                from = "hmn";
            }
            else if (comboBox1.Text == "Hungarian")
            {
                from = "hu";
            }
            else if (comboBox1.Text == "Icelandic")
            {
                from = "is";
            }
            else if (comboBox1.Text == "Igbo")
            {
                from = "ig";
            }
            else if (comboBox1.Text == "Iloko")
            {
                from = "ilo";
            }
            else if (comboBox1.Text == "Indonesian")
            {
                from = "id";
            }
            else if (comboBox1.Text == "Irish")
            {
                from = "ga";
            }
            else if (comboBox1.Text == "Italian")
            {
                from = "it";
            }
            else if (comboBox1.Text == "Japanese")
            {
                from = "ja";
            }
            else if (comboBox1.Text == "Javanese")
            {
                from = "jw";
            }
            else if (comboBox1.Text == "Kannada")
            {
                from = "kn";
            }
            else if (comboBox1.Text == "Kazakh")
            {
                from = "kk";
            }
            else if (comboBox1.Text == "Khmer")
            {
                from = "km";
            }
            else if (comboBox1.Text == "Kinyarwanda")
            {
                from = "rw";
            }
            else if (comboBox1.Text == "Konkani")
            {
                from = "gom";
            }
            else if (comboBox1.Text == "Korean")
            {
                from = "ko";
            }
            else if (comboBox1.Text == "Krio")
            {
                from = "kri";
            }
            else if (comboBox1.Text == "Kurdish (Kurmanji)")
            {
                from = "ku";
            }
            else if (comboBox1.Text == "Kurdish (Sorani)")
            {
                from = "ckb";
            }
            else if (comboBox1.Text == "Kyrgyz")
            {
                from = "ky";
            }
            else if (comboBox1.Text == "Lao")
            {
                from = "lo";
            }
            else if (comboBox1.Text == "Latin")
            {
                from = "la";
            }
            else if (comboBox1.Text == "Latvian")
            {
                from = "lv";
            }
            else if (comboBox1.Text == "Lingala")
            {
                from = "ln";
            }
            else if (comboBox1.Text == "Lithuanian")
            {
                from = "lt";
            }
            else if (comboBox1.Text == "Luganda")
            {
                from = "lg";
            }
            else if (comboBox1.Text == "Luxembourgish")
            {
                from = "lb";
            }
            else if (comboBox1.Text == "Macedonian")
            {
                from = "mk";
            }
            else if (comboBox1.Text == "Maithili")
            {
                from = "mai";
            }
            else if (comboBox1.Text == "Malagasy")
            {
                from = "mg";
            }
            else if (comboBox1.Text == "Malay")
            {
                from = "ms";
            }
            else if (comboBox1.Text == "Malayalam")
            {
                from = "ml";
            }
            else if (comboBox1.Text == "Maltese")
            {
                from = "mt";
            }
            else if (comboBox1.Text == "Meiteilon (Manipuri)")
            {
                from = "mni";
            }
            else if (comboBox1.Text == "Maori")
            {
                from = "mi";
            }
            else if (comboBox1.Text == "Marathi")
            {
                from = "mr";
            }
            else if (comboBox1.Text == "Mizo")
            {
                from = "lus";
            }
            else if (comboBox1.Text == "Mongolian")
            {
                from = "mn";
            }
            else if (comboBox1.Text == "Myanmar (Burmese)")
            {
                from = "my";
            }
            else if (comboBox1.Text == "Nepali")
            {
                from = "ne";
            }

            else if (comboBox1.Text == "Norwegian")
            {
                from = "no";
            }

            else if (comboBox1.Text == "Odia (Oriya)")
            {
                from = "or";
            }
            else if (comboBox1.Text == "Oromo")
            {
                from = "om";
            }
            else if (comboBox1.Text == "Pashto")
            {
                from = "ps";
            }
            else if (comboBox1.Text == "Persian")
            {
                from = "fa";
            }
            else if (comboBox1.Text == "Polish")
            {
                from = "pl";
            }
            else if (comboBox1.Text == "Portuguese")
            {
                from = "pt";
            }
            else if (comboBox1.Text == "Punjabi")
            {
                from = "pa";
            }
            else if (comboBox1.Text == "Quechua")
            {
                from = "qu";
            }
            else if (comboBox1.Text == "Romanian")
            {
                from = "ro";
            }
            else if (comboBox1.Text == "Russian")
            {
                from = "ru";
            }
            else if (comboBox1.Text == "Samoan")
            {
                from = "asm";
            }
            else if (comboBox1.Text == "Sanskrit")
            {
                from = "sa";
            }
            else if (comboBox1.Text == "Scots Gaeelic")
            {
                from = "gd";
            }
            else if (comboBox1.Text == "Sepedi")
            {
                from = "nso";
            }
            else if (comboBox1.Text == "Serbian")
            {
                from = "sr";
            }
            else if (comboBox1.Text == "Sesotho")
            {
                from = "st";
            }
            else if (comboBox1.Text == "Shona")
            {
                from = "sn";
            }
            else if (comboBox1.Text == "Sindhi")
            {
                from = "sd";
            }
            else if (comboBox1.Text == "Sinhala")
            {
                from = "si";
            }
            else if (comboBox1.Text == "Slovak")
            {
                from = "sk";
            }
            else if (comboBox1.Text == "Slovenian")
            {
                from = "sl";
            }
            else if (comboBox1.Text == "Somali")
            {
                from = "so";
            }

            else if (comboBox1.Text == "Spanish")
            {
                from = "es";
            }
            else if (comboBox1.Text == "Sundanese")
            {
                from = "su";
            }
            else if (comboBox1.Text == "Swahili")
            {
                from = "sw";
            }
            else if (comboBox1.Text == "Swedish")
            {
                from = "sv";
            }
            else if (comboBox1.Text == "Tajik")
            {
                from = "tg";
            }
            else if (comboBox1.Text == "Tamil")
            {
                from = "ta";
            }
            else if (comboBox1.Text == "Tatar")
            {
                from = "tt";
            }
            else if (comboBox1.Text == "Telugu")
            {
                from = "te";
            }
            else if (comboBox1.Text == "Thai")
            {
                from = "th";
            }
            else if (comboBox1.Text == "Tigrinya")
            {
                from = "ti";
            }
            else if (comboBox1.Text == "Tsonga")
            {
                from = "ts";
            }
            else if (comboBox1.Text == "Turkish")
            {
                from = "tr";
            }
            else if (comboBox1.Text == "Turkmen")
            {
                from = "tk";
            }
            else if (comboBox1.Text == "Twi")
            {
                from = "ak";
            }
            else if (comboBox1.Text == "Ukrainian")
            {
                from = "uk";
            }
            else if (comboBox1.Text == "Urdu")
            {
                from = "ur";
            }
            else if (comboBox1.Text == "Uygher")
            {
                from = "ug";
            }
            else if (comboBox1.Text == "Uzbek")
            {
                from = "uz";
            }
            else if (comboBox1.Text == "Vietnamese")
            {
                from = "vi";
            }
            else if (comboBox1.Text == "Welsh")
            {
                from = "cy";
            }

            else if (comboBox1.Text == "Xhosa")
            {
                from = "xh";
            }
            else if (comboBox1.Text == "Yiddish")
            {
                from = "yi";
            }
            else if (comboBox1.Text == "Yoruba")
            {
                from = "yo";
            }
            else if (comboBox1.Text == "Zulu")
            {
                from = "zu";
            }

            if (comboBox2.Text == "Afrikaans")
            {
                to = "af";
            }
            else if (comboBox2.Text == "Albanian")
            {
                to = "sq";
            }
            else if (comboBox2.Text == "Amharic")
            {
                to = "sl";
            }
            else if (comboBox2.Text == "Arabic")
            {
                to = "ar";
            }
            else if (comboBox2.Text == "Armenian")
            {
                to = "hy";
            }
            else if (comboBox2.Text == "Assamese")
            {
                to = "as";
            }
            else if (comboBox2.Text == "Aymara")
            {
                to = "ay";
            }
            else if (comboBox2.Text == "Azerbaijani")
            {
                to = "az";
            }
            else if (comboBox2.Text == "Bambara")
            {
                to = "bm";
            }
            else if (comboBox2.Text == "Bengali")
            {
                to = "bn";
            }
            else if (comboBox2.Text == "Basque")
            {
                to = "eu";
            }
            else if (comboBox2.Text == "Belarusian")
            {
                to = "be";
            }
            else if (comboBox2.Text == "Bhojpuri")
            {
                to = "bho";
            }
            else if (comboBox2.Text == "Bosnian")
            {
                to = "bs";
            }
            else if (comboBox2.Text == "Bulgarian")
            {
                to = "bg";
            }

            else if (comboBox2.Text == "Catalan")
            {
                to = "ca";
            }
            else if (comboBox2.Text == "Cebuano")
            {
                to = "ceb";
            }
            else if (comboBox2.Text == "Chichewa")
            {
                to = "ny";
            }

            else if (comboBox2.Text == "Chinese (Simplified)")
            {
                to = "zh-CN";
            }
            else if (comboBox2.Text == "Chinese (Traditional)")
            {
                to = "zh-TW";
            }
            else if (comboBox2.Text == "Corsican")
            {
                to = "co";
            }
            else if (comboBox2.Text == "Croatian")
            {
                to = "hr";
            }
            else if (comboBox2.Text == "Czech")
            {
                to = "cs";
            }
            else if (comboBox2.Text == "Danish")
            {
                to = "da";
            }
            else if (comboBox2.Text == "Divehi")
            {
                to = "dv";
            }
            else if (comboBox2.Text == "Dogri")
            {
                to = "doi";
            }
            else if (comboBox2.Text == "Dutch")
            {
                to = "nl";
            }
            else if (comboBox2.Text == "English")
            {
                to = "en";
            }
            else if (comboBox2.Text == "Esperanto")
            {
                to = "eo";
            }
            else if (comboBox2.Text == "Estonian")
            {
                to = "et";
            }
            else if (comboBox2.Text == "Ewe")
            {
                to = "ee";
            }
            else if (comboBox2.Text == "Filipino")
            {
                to = "tl";
            }
            else if (comboBox2.Text == "Finnish")
            {
                to = "fi";
            }
            else if (comboBox2.Text == "French")
            {
                to = "fr";
            }
            else if (comboBox2.Text == "Frisian")
            {
                to = "fy";
            }
            else if (comboBox2.Text == "Galician")
            {
                to = "gl";
            }

            else if (comboBox2.Text == "Georgian")
            {
                to = "ka";
            }
            else if (comboBox2.Text == "German")
            {
                to = "de";
            }
            else if (comboBox2.Text == "Goan Konkani")
            {
                to = "ko";
            }
            else if (comboBox2.Text == "Greek")
            {
                to = "el";
            }
            else if (comboBox2.Text == "Guarani")
            {
                to = "gn";
            }
            else if (comboBox2.Text == "Gujarati")
            {
                to = "gu";
            }
            else if (comboBox2.Text == "Haitian Creole")
            {
                to = "ht";
            }
            else if (comboBox2.Text == "Hausa")
            {
                to = "ha";
            }
            else if (comboBox2.Text == "Hawaiian")
            {
                to = "haw";
            }
            else if (comboBox2.Text == "Hebrew")
            {
                to = "iw";
            }
            else if (comboBox2.Text == "Hindi")
            {
                to = "hi";
            }
            else if (comboBox2.Text == "Hmong")
            {
                to = "hmn";
            }
            else if (comboBox2.Text == "Hungarian")
            {
                to = "hu";
            }
            else if (comboBox2.Text == "Icelandic")
            {
                to = "is";
            }
            else if (comboBox2.Text == "Igbo")
            {
                to = "ig";
            }
            else if (comboBox2.Text == "Iloko")
            {
                to = "ilo";
            }
            else if (comboBox2.Text == "Indonesian")
            {
                to = "id";
            }
            else if (comboBox2.Text == "Irish")
            {
                to = "ga";
            }
            else if (comboBox2.Text == "Italian")
            {
                to = "it";
            }
            else if (comboBox2.Text == "Japanese")
            {
                to = "ja";
            }
            else if (comboBox2.Text == "Javanese")
            {
                to = "jw";
            }
            else if (comboBox2.Text == "Kannada")
            {
                to = "kn";
            }
            else if (comboBox2.Text == "Kazakh")
            {
                to = "kk";
            }
            else if (comboBox2.Text == "Khmer")
            {
                to = "km";
            }
            else if (comboBox2.Text == "Kinyarwanda")
            {
                to = "rw";
            }
            else if (comboBox2.Text == "Konkani")
            {
                to = "gom";
            }
            else if (comboBox2.Text == "Korean")
            {
                to = "ko";
            }
            else if (comboBox2.Text == "Krio")
            {
                to = "kri";
            }
            else if (comboBox2.Text == "Kurdish (Kurmanji)")
            {
                to = "ku";
            }
            else if (comboBox2.Text == "Kurdish (Sorani)")
            {
                to = "ckb";
            }
            else if (comboBox2.Text == "Kyrgyz")
            {
                to = "ky";
            }
            else if (comboBox2.Text == "Lao")
            {
                to = "lo";
            }
            else if (comboBox2.Text == "Latin")
            {
                to = "la";
            }
            else if (comboBox2.Text == "Latvian")
            {
                to = "lv";
            }
            else if (comboBox2.Text == "Lingala")
            {
                to = "ln";
            }
            else if (comboBox2.Text == "Lithuanian")
            {
                to = "lt";
            }
            else if (comboBox2.Text == "Luganda")
            {
                to = "lg";
            }
            else if (comboBox2.Text == "Luxembourgish")
            {
                to = "lb";
            }
            else if (comboBox2.Text == "Macedonian")
            {
                to = "mk";
            }
            else if (comboBox2.Text == "Maithili")
            {
                to = "mai";
            }
            else if (comboBox2.Text == "Malagasy")
            {
                to = "mg";
            }
            else if (comboBox2.Text == "Malay")
            {
                to = "ms";
            }
            else if (comboBox2.Text == "Malayalam")
            {
                to = "ml";
            }
            else if (comboBox2.Text == "Maltese")
            {
                to = "mt";
            }
            else if (comboBox2.Text == "Meiteilon (Manipuri)")
            {
                to = "mni";
            }
            else if (comboBox2.Text == "Maori")
            {
                to = "mi";
            }
            else if (comboBox2.Text == "Marathi")
            {
                to = "mr";
            }
            else if (comboBox2.Text == "Mizo")
            {
                to = "lus";
            }
            else if (comboBox2.Text == "Mongolian")
            {
                to = "mn";
            }
            else if (comboBox2.Text == "Myanmar (Burmese)")
            {
                to = "my";
            }
            else if (comboBox2.Text == "Nepali")
            {
                to = "ne";
            }

            else if (comboBox2.Text == "Norwegian")
            {
                to = "no";
            }

            else if (comboBox2.Text == "Odia (Oriya)")
            {
                to = "or";
            }
            else if (comboBox2.Text == "Oromo")
            {
                to = "om";
            }
            else if (comboBox2.Text == "Pashto")
            {
                to = "ps";
            }
            else if (comboBox2.Text == "Persian")
            {
                to = "fa";
            }
            else if (comboBox2.Text == "Polish")
            {
                to = "pl";
            }
            else if (comboBox2.Text == "Portuguese")
            {
                to = "pt";
            }
            else if (comboBox2.Text == "Punjabi")
            {
                to = "pa";
            }
            else if (comboBox2.Text == "Quechua")
            {
                to = "qu";
            }
            else if (comboBox2.Text == "Romanian")
            {
                to = "ro";
            }
            else if (comboBox2.Text == "Russian")
            {
                to = "ru";
            }
            else if (comboBox2.Text == "Samoan")
            {
                to = "asm";
            }
            else if (comboBox2.Text == "Sanskrit")
            {
                to = "sa";
            }
            else if (comboBox2.Text == "Scots Gaeelic")
            {
                to = "gd";
            }
            else if (comboBox2.Text == "Sepedi")
            {
                to = "nso";
            }
            else if (comboBox2.Text == "Serbian")
            {
                to = "sr";
            }
            else if (comboBox2.Text == "Sesotho")
            {
                to = "st";
            }
            else if (comboBox2.Text == "Shona")
            {
                to = "sn";
            }
            else if (comboBox2.Text == "Sindhi")
            {
                to = "sd";
            }
            else if (comboBox2.Text == "Sinhala")
            {
                to = "si";
            }
            else if (comboBox2.Text == "Slovak")
            {
                to = "sk";
            }
            else if (comboBox2.Text == "Slovenian")
            {
                to = "sl";
            }
            else if (comboBox2.Text == "Somali")
            {
                to = "so";
            }

            else if (comboBox2.Text == "Spanish")
            {
                to = "es";
            }
            else if (comboBox2.Text == "Sundanese")
            {
                to = "su";
            }
            else if (comboBox2.Text == "Swahili")
            {
                to = "sw";
            }
            else if (comboBox2.Text == "Swedish")
            {
                to = "sv";
            }
            else if (comboBox2.Text == "Tajik")
            {
                to = "tg";
            }
            else if (comboBox2.Text == "Tamil")
            {
                to = "ta";
            }
            else if (comboBox2.Text == "Tatar")
            {
                to = "tt";
            }
            else if (comboBox2.Text == "Telugu")
            {
                to = "te";
            }
            else if (comboBox2.Text == "Thai")
            {
                to = "th";
            }
            else if (comboBox2.Text == "Tigrinya")
            {
                to = "ti";
            }
            else if (comboBox2.Text == "Tsonga")
            {
                to = "ts";
            }
            else if (comboBox2.Text == "Turkish")
            {
                to = "tr";
            }
            else if (comboBox2.Text == "Turkmen")
            {
                to = "tk";
            }
            else if (comboBox2.Text == "Twi")
            {
                to = "ak";
            }
            else if (comboBox2.Text == "Ukrainian")
            {
                to = "uk";
            }
            else if (comboBox2.Text == "Urdu")
            {
                to = "ur";
            }
            else if (comboBox2.Text == "Uygher")
            {
                to = "ug";
            }
            else if (comboBox2.Text == "Uzbek")
            {
                to = "uz";
            }
            else if (comboBox2.Text == "Vietnamese")
            {
                to = "vi";
            }
            else if (comboBox2.Text == "Welsh")
            {
                to = "cy";
            }

            else if (comboBox2.Text == "Xhosa")
            {
                to = "xh";
            }
            else if (comboBox2.Text == "Yiddish")
            {
                to = "yi";
            }
            else if (comboBox2.Text == "Yoruba")
            {
                to = "yo";
            }
            else if (comboBox2.Text == "Zulu")
            {
                to = "zu";
            }
            Bot AI = new Bot();
            AI.loadSettings(); //It will Load Settings from its Config Folder with this code
            AI.loadAIMLFromFiles(); //With this Code It Will Load AIML Files from its AIML Folder
            AI.isAcceptingUserInput = false; //With this Code it will Disable UserInput For Now
            User myuser = new User("Username Here", AI); //With This Code We Will Add The User Through AI/Bot
            AI.isAcceptingUserInput = true; //Now The User Input is Enabled Again with this Code
            string en= translate(textBox1.Text, from, "en");
            Request r = new Request(en, myuser, AI); //With This Code it will Request The Response From AIML Folders
            Result res = AI.Chat(r); //With This Code It Will Get Result
            //= Form10.instance.t2.Text;
            InputBox.Text = textBox1.Text;
            text= translate(res.Output, "en", to);
            OutputBox.Text = "Efface C# Bot: " + translate(res.Output,"en",to);
            textBox1.Text = "";//With this Code It Will Write the Result of Textbox1 Response to Textbox2 text
        }

        private void OutputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void InputBox_TextChanged(object sender, EventArgs e)
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
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Account f8 = new Account();
            f8.ShowDialog();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            string from = Form9.t1;
            string to = Form10.t2;
            OutputBox.Text = translate(OutputBox.Text, to, from);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Afrikaans")
            {
                from = "af";
            }
            else if (comboBox1.Text == "Albanian")
            {
                from = "sq";
            }
            else if (comboBox1.Text == "Amharic")
            {
                from = "sl";
            }
            else if (comboBox1.Text == "Arabic")
            {
                from = "ar";
            }
            else if (comboBox1.Text == "Armenian")
            {
                from = "hy";
            }
            else if (comboBox1.Text == "Assamese")
            {
                from = "as";
            }
            else if (comboBox1.Text == "Aymara")
            {
                from = "ay";
            }
            else if (comboBox1.Text == "Azerbaijani")
            {
                from = "az";
            }
            else if (comboBox1.Text == "Bambara")
            {
                from = "bm";
            }
            else if (comboBox1.Text == "Bengali")
            {
                from = "bn";
            }
            else if (comboBox1.Text == "Basque")
            {
                from = "eu";
            }
            else if (comboBox1.Text == "Belarusian")
            {
                from = "be";
            }
            else if (comboBox1.Text == "Bhojpuri")
            {
                from = "bho";
            }
            else if (comboBox1.Text == "Bosnian")
            {
                from = "bs";
            }
            else if (comboBox1.Text == "Bulgarian")
            {
                from = "bg";
            }

            else if (comboBox1.Text == "Catalan")
            {
                from = "ca";
            }
            else if (comboBox1.Text == "Cebuano")
            {
                from = "ceb";
            }
            else if (comboBox1.Text == "Chichewa")
            {
                from = "ny";
            }

            else if (comboBox1.Text == "Chinese (Simplified)")
            {
                from = "zh-CN";
            }
            else if (comboBox1.Text == "Chinese (Traditional)")
            {
                from = "zh-TW";
            }
            else if (comboBox1.Text == "Corsican")
            {
                from = "co";
            }
            else if (comboBox1.Text == "Croatian")
            {
                from = "hr";
            }
            else if (comboBox1.Text == "Czech")
            {
                from = "cs";
            }
            else if (comboBox1.Text == "Danish")
            {
                from = "da";
            }
            else if (comboBox1.Text == "Divehi")
            {
                from = "dv";
            }
            else if (comboBox1.Text == "Dogri")
            {
                from = "doi";
            }
            else if (comboBox1.Text == "Dutch")
            {
                from = "nl";
            }
            else if (comboBox1.Text == "English")
            {
                from = "en";
            }
            else if (comboBox1.Text == "Esperanto")
            {
                from = "eo";
            }
            else if (comboBox1.Text == "Estonian")
            {
                from = "et";
            }
            else if (comboBox1.Text == "Ewe")
            {
                from = "ee";
            }
            else if (comboBox1.Text == "Filipino")
            {
                from = "tl";
            }
            else if (comboBox1.Text == "Finnish")
            {
                from = "fi";
            }
            else if (comboBox1.Text == "French")
            {
                from = "fr";
            }
            else if (comboBox1.Text == "Frisian")
            {
                from = "fy";
            }
            else if (comboBox1.Text == "Galician")
            {
                from = "gl";
            }

            else if (comboBox1.Text == "Georgian")
            {
                from = "ka";
            }
            else if (comboBox1.Text == "German")
            {
                from = "de";
            }
            else if (comboBox1.Text == "Goan Konkani")
            {
                from = "ko";
            }
            else if (comboBox1.Text == "Greek")
            {
                from = "el";
            }
            else if (comboBox1.Text == "Guarani")
            {
                from = "gn";
            }
            else if (comboBox1.Text == "Gujarati")
            {
                from = "gu";
            }
            else if (comboBox1.Text == "Haitian Creole")
            {
                from = "ht";
            }
            else if (comboBox1.Text == "Hausa")
            {
                from = "ha";
            }
            else if (comboBox1.Text == "Hawaiian")
            {
                from = "haw";
            }
            else if (comboBox1.Text == "Hebrew")
            {
                from = "iw";
            }
            else if (comboBox1.Text == "Hindi")
            {
                from = "hi";
            }
            else if (comboBox1.Text == "Hmong")
            {
                from = "hmn";
            }
            else if (comboBox1.Text == "Hungarian")
            {
                from = "hu";
            }
            else if (comboBox1.Text == "Icelandic")
            {
                from = "is";
            }
            else if (comboBox1.Text == "Igbo")
            {
                from = "ig";
            }
            else if (comboBox1.Text == "Iloko")
            {
                from = "ilo";
            }
            else if (comboBox1.Text == "Indonesian")
            {
                from = "id";
            }
            else if (comboBox1.Text == "Irish")
            {
                from = "ga";
            }
            else if (comboBox1.Text == "Italian")
            {
                from = "it";
            }
            else if (comboBox1.Text == "Japanese")
            {
                from = "ja";
            }
            else if (comboBox1.Text == "Javanese")
            {
                from = "jw";
            }
            else if (comboBox1.Text == "Kannada")
            {
                from = "kn";
            }
            else if (comboBox1.Text == "Kazakh")
            {
                from = "kk";
            }
            else if (comboBox1.Text == "Khmer")
            {
                from = "km";
            }
            else if (comboBox1.Text == "Kinyarwanda")
            {
                from = "rw";
            }
            else if (comboBox1.Text == "Konkani")
            {
                from = "gom";
            }
            else if (comboBox1.Text == "Korean")
            {
                from = "ko";
            }
            else if (comboBox1.Text == "Krio")
            {
                from = "kri";
            }
            else if (comboBox1.Text == "Kurdish (Kurmanji)")
            {
                from = "ku";
            }
            else if (comboBox1.Text == "Kurdish (Sorani)")
            {
                from = "ckb";
            }
            else if (comboBox1.Text == "Kyrgyz")
            {
                from = "ky";
            }
            else if (comboBox1.Text == "Lao")
            {
                from = "lo";
            }
            else if (comboBox1.Text == "Latin")
            {
                from = "la";
            }
            else if (comboBox1.Text == "Latvian")
            {
                from = "lv";
            }
            else if (comboBox1.Text == "Lingala")
            {
                from = "ln";
            }
            else if (comboBox1.Text == "Lithuanian")
            {
                from = "lt";
            }
            else if (comboBox1.Text == "Luganda")
            {
                from = "lg";
            }
            else if (comboBox1.Text == "Luxembourgish")
            {
                from = "lb";
            }
            else if (comboBox1.Text == "Macedonian")
            {
                from = "mk";
            }
            else if (comboBox1.Text == "Maithili")
            {
                from = "mai";
            }
            else if (comboBox1.Text == "Malagasy")
            {
                from = "mg";
            }
            else if (comboBox1.Text == "Malay")
            {
                from = "ms";
            }
            else if (comboBox1.Text == "Malayalam")
            {
                from = "ml";
            }
            else if (comboBox1.Text == "Maltese")
            {
                from = "mt";
            }
            else if (comboBox1.Text == "Meiteilon (Manipuri)")
            {
                from = "mni";
            }
            else if (comboBox1.Text == "Maori")
            {
                from = "mi";
            }
            else if (comboBox1.Text == "Marathi")
            {
                from = "mr";
            }
            else if (comboBox1.Text == "Mizo")
            {
                from = "lus";
            }
            else if (comboBox1.Text == "Mongolian")
            {
                from = "mn";
            }
            else if (comboBox1.Text == "Myanmar (Burmese)")
            {
                from = "my";
            }
            else if (comboBox1.Text == "Nepali")
            {
                from = "ne";
            }

            else if (comboBox1.Text == "Norwegian")
            {
                from = "no";
            }

            else if (comboBox1.Text == "Odia (Oriya)")
            {
                from = "or";
            }
            else if (comboBox1.Text == "Oromo")
            {
                from = "om";
            }
            else if (comboBox1.Text == "Pashto")
            {
                from = "ps";
            }
            else if (comboBox1.Text == "Persian")
            {
                from = "fa";
            }
            else if (comboBox1.Text == "Polish")
            {
                from = "pl";
            }
            else if (comboBox1.Text == "Portuguese")
            {
                from = "pt";
            }
            else if (comboBox1.Text == "Punjabi")
            {
                from = "pa";
            }
            else if (comboBox1.Text == "Quechua")
            {
                from = "qu";
            }
            else if (comboBox1.Text == "Romanian")
            {
                from = "ro";
            }
            else if (comboBox1.Text == "Russian")
            {
                from = "ru";
            }
            else if (comboBox1.Text == "Samoan")
            {
                from = "asm";
            }
            else if (comboBox1.Text == "Sanskrit")
            {
                from = "sa";
            }
            else if (comboBox1.Text == "Scots Gaeelic")
            {
                from = "gd";
            }
            else if (comboBox1.Text == "Sepedi")
            {
                from = "nso";
            }
            else if (comboBox1.Text == "Serbian")
            {
                from = "sr";
            }
            else if (comboBox1.Text == "Sesotho")
            {
                from = "st";
            }
            else if (comboBox1.Text == "Shona")
            {
                from = "sn";
            }
            else if (comboBox1.Text == "Sindhi")
            {
                from = "sd";
            }
            else if (comboBox1.Text == "Sinhala")
            {
                from = "si";
            }
            else if (comboBox1.Text == "Slovak")
            {
                from = "sk";
            }
            else if (comboBox1.Text == "Slovenian")
            {
                from = "sl";
            }
            else if (comboBox1.Text == "Somali")
            {
                from = "so";
            }

            else if (comboBox1.Text == "Spanish")
            {
                from = "es";
            }
            else if (comboBox1.Text == "Sundanese")
            {
                from = "su";
            }
            else if (comboBox1.Text == "Swahili")
            {
                from = "sw";
            }
            else if (comboBox1.Text == "Swedish")
            {
                from = "sv";
            }
            else if (comboBox1.Text == "Tajik")
            {
                from = "tg";
            }
            else if (comboBox1.Text == "Tamil")
            {
                from = "ta";
            }
            else if (comboBox1.Text == "Tatar")
            {
                from = "tt";
            }
            else if (comboBox1.Text == "Telugu")
            {
                from = "te";
            }
            else if (comboBox1.Text == "Thai")
            {
                from = "th";
            }
            else if (comboBox1.Text == "Tigrinya")
            {
                from = "ti";
            }
            else if (comboBox1.Text == "Tsonga")
            {
                from = "ts";
            }
            else if (comboBox1.Text == "Turkish")
            {
                from = "tr";
            }
            else if (comboBox1.Text == "Turkmen")
            {
                from = "tk";
            }
            else if (comboBox1.Text == "Twi")
            {
                from = "ak";
            }
            else if (comboBox1.Text == "Ukrainian")
            {
                from = "uk";
            }
            else if (comboBox1.Text == "Urdu")
            {
                from = "ur";
            }
            else if (comboBox1.Text == "Uygher")
            {
                from = "ug";
            }
            else if (comboBox1.Text == "Uzbek")
            {
                from = "uz";
            }
            else if (comboBox1.Text == "Vietnamese")
            {
                from = "vi";
            }
            else if (comboBox1.Text == "Welsh")
            {
                from = "cy";
            }

            else if (comboBox1.Text == "Xhosa")
            {
                from = "xh";
            }
            else if (comboBox1.Text == "Yiddish")
            {
                from = "yi";
            }
            else if (comboBox1.Text == "Yoruba")
            {
                from = "yo";
            }
            else if (comboBox1.Text == "Zulu")
            {
                from = "zu";
            }

            if (comboBox2.Text == "Afrikaans")
            {
                to = "af";
            }
            else if (comboBox2.Text == "Albanian")
            {
                to = "sq";
            }
            else if (comboBox2.Text == "Amharic")
            {
                to = "sl";
            }
            else if (comboBox2.Text == "Arabic")
            {
                to = "ar";
            }
            else if (comboBox2.Text == "Armenian")
            {
                to = "hy";
            }
            else if (comboBox2.Text == "Assamese")
            {
                to = "as";
            }
            else if (comboBox2.Text == "Aymara")
            {
                to = "ay";
            }
            else if (comboBox2.Text == "Azerbaijani")
            {
                to = "az";
            }
            else if (comboBox2.Text == "Bambara")
            {
                to = "bm";
            }
            else if (comboBox2.Text == "Bengali")
            {
                to = "bn";
            }
            else if (comboBox2.Text == "Basque")
            {
                to = "eu";
            }
            else if (comboBox2.Text == "Belarusian")
            {
                to = "be";
            }
            else if (comboBox2.Text == "Bhojpuri")
            {
                to = "bho";
            }
            else if (comboBox2.Text == "Bosnian")
            {
                to = "bs";
            }
            else if (comboBox2.Text == "Bulgarian")
            {
                to = "bg";
            }

            else if (comboBox2.Text == "Catalan")
            {
                to = "ca";
            }
            else if (comboBox2.Text == "Cebuano")
            {
                to = "ceb";
            }
            else if (comboBox2.Text == "Chichewa")
            {
                to = "ny";
            }

            else if (comboBox2.Text == "Chinese (Simplified)")
            {
                to = "zh-CN";
            }
            else if (comboBox2.Text == "Chinese (Traditional)")
            {
                to = "zh-TW";
            }
            else if (comboBox2.Text == "Corsican")
            {
                to = "co";
            }
            else if (comboBox2.Text == "Croatian")
            {
                to = "hr";
            }
            else if (comboBox2.Text == "Czech")
            {
                to = "cs";
            }
            else if (comboBox2.Text == "Danish")
            {
                to = "da";
            }
            else if (comboBox2.Text == "Divehi")
            {
                to = "dv";
            }
            else if (comboBox2.Text == "Dogri")
            {
                to = "doi";
            }
            else if (comboBox2.Text == "Dutch")
            {
                to = "nl";
            }
            else if (comboBox2.Text == "English")
            {
                to = "en";
            }
            else if (comboBox2.Text == "Esperanto")
            {
                to = "eo";
            }
            else if (comboBox2.Text == "Estonian")
            {
                to = "et";
            }
            else if (comboBox2.Text == "Ewe")
            {
                to = "ee";
            }
            else if (comboBox2.Text == "Filipino")
            {
                to = "tl";
            }
            else if (comboBox2.Text == "Finnish")
            {
                to = "fi";
            }
            else if (comboBox2.Text == "French")
            {
                to = "fr";
            }
            else if (comboBox2.Text == "Frisian")
            {
                to = "fy";
            }
            else if (comboBox2.Text == "Galician")
            {
                to = "gl";
            }

            else if (comboBox2.Text == "Georgian")
            {
                to = "ka";
            }
            else if (comboBox2.Text == "German")
            {
                to = "de";
            }
            else if (comboBox2.Text == "Goan Konkani")
            {
                to = "ko";
            }
            else if (comboBox2.Text == "Greek")
            {
                to = "el";
            }
            else if (comboBox2.Text == "Guarani")
            {
                to = "gn";
            }
            else if (comboBox2.Text == "Gujarati")
            {
                to = "gu";
            }
            else if (comboBox2.Text == "Haitian Creole")
            {
                to = "ht";
            }
            else if (comboBox2.Text == "Hausa")
            {
                to = "ha";
            }
            else if (comboBox2.Text == "Hawaiian")
            {
                to = "haw";
            }
            else if (comboBox2.Text == "Hebrew")
            {
                to = "iw";
            }
            else if (comboBox2.Text == "Hindi")
            {
                to = "hi";
            }
            else if (comboBox2.Text == "Hmong")
            {
                to = "hmn";
            }
            else if (comboBox2.Text == "Hungarian")
            {
                to = "hu";
            }
            else if (comboBox2.Text == "Icelandic")
            {
                to = "is";
            }
            else if (comboBox2.Text == "Igbo")
            {
                to = "ig";
            }
            else if (comboBox2.Text == "Iloko")
            {
                to = "ilo";
            }
            else if (comboBox2.Text == "Indonesian")
            {
                to = "id";
            }
            else if (comboBox2.Text == "Irish")
            {
                to = "ga";
            }
            else if (comboBox2.Text == "Italian")
            {
                to = "it";
            }
            else if (comboBox2.Text == "Japanese")
            {
                to = "ja";
            }
            else if (comboBox2.Text == "Javanese")
            {
                to = "jw";
            }
            else if (comboBox2.Text == "Kannada")
            {
                to = "kn";
            }
            else if (comboBox2.Text == "Kazakh")
            {
                to = "kk";
            }
            else if (comboBox2.Text == "Khmer")
            {
                to = "km";
            }
            else if (comboBox2.Text == "Kinyarwanda")
            {
                to = "rw";
            }
            else if (comboBox2.Text == "Konkani")
            {
                to = "gom";
            }
            else if (comboBox2.Text == "Korean")
            {
                to = "ko";
            }
            else if (comboBox2.Text == "Krio")
            {
                to = "kri";
            }
            else if (comboBox2.Text == "Kurdish (Kurmanji)")
            {
                to = "ku";
            }
            else if (comboBox2.Text == "Kurdish (Sorani)")
            {
                to = "ckb";
            }
            else if (comboBox2.Text == "Kyrgyz")
            {
                to = "ky";
            }
            else if (comboBox2.Text == "Lao")
            {
                to = "lo";
            }
            else if (comboBox2.Text == "Latin")
            {
                to = "la";
            }
            else if (comboBox2.Text == "Latvian")
            {
                to = "lv";
            }
            else if (comboBox2.Text == "Lingala")
            {
                to = "ln";
            }
            else if (comboBox2.Text == "Lithuanian")
            {
                to = "lt";
            }
            else if (comboBox2.Text == "Luganda")
            {
                to = "lg";
            }
            else if (comboBox2.Text == "Luxembourgish")
            {
                to = "lb";
            }
            else if (comboBox2.Text == "Macedonian")
            {
                to = "mk";
            }
            else if (comboBox2.Text == "Maithili")
            {
                to = "mai";
            }
            else if (comboBox2.Text == "Malagasy")
            {
                to = "mg";
            }
            else if (comboBox2.Text == "Malay")
            {
                to = "ms";
            }
            else if (comboBox2.Text == "Malayalam")
            {
                to = "ml";
            }
            else if (comboBox2.Text == "Maltese")
            {
                to = "mt";
            }
            else if (comboBox2.Text == "Meiteilon (Manipuri)")
            {
                to = "mni";
            }
            else if (comboBox2.Text == "Maori")
            {
                to = "mi";
            }
            else if (comboBox2.Text == "Marathi")
            {
                to = "mr";
            }
            else if (comboBox2.Text == "Mizo")
            {
                to = "lus";
            }
            else if (comboBox2.Text == "Mongolian")
            {
                to = "mn";
            }
            else if (comboBox2.Text == "Myanmar (Burmese)")
            {
                to = "my";
            }
            else if (comboBox2.Text == "Nepali")
            {
                to = "ne";
            }

            else if (comboBox2.Text == "Norwegian")
            {
                to = "no";
            }

            else if (comboBox2.Text == "Odia (Oriya)")
            {
                to = "or";
            }
            else if (comboBox2.Text == "Oromo")
            {
                to = "om";
            }
            else if (comboBox2.Text == "Pashto")
            {
                to = "ps";
            }
            else if (comboBox2.Text == "Persian")
            {
                to = "fa";
            }
            else if (comboBox2.Text == "Polish")
            {
                to = "pl";
            }
            else if (comboBox2.Text == "Portuguese")
            {
                to = "pt";
            }
            else if (comboBox2.Text == "Punjabi")
            {
                to = "pa";
            }
            else if (comboBox2.Text == "Quechua")
            {
                to = "qu";
            }
            else if (comboBox2.Text == "Romanian")
            {
                to = "ro";
            }
            else if (comboBox2.Text == "Russian")
            {
                to = "ru";
            }
            else if (comboBox2.Text == "Samoan")
            {
                to = "asm";
            }
            else if (comboBox2.Text == "Sanskrit")
            {
                to = "sa";
            }
            else if (comboBox2.Text == "Scots Gaeelic")
            {
                to = "gd";
            }
            else if (comboBox2.Text == "Sepedi")
            {
                to = "nso";
            }
            else if (comboBox2.Text == "Serbian")
            {
                to = "sr";
            }
            else if (comboBox2.Text == "Sesotho")
            {
                to = "st";
            }
            else if (comboBox2.Text == "Shona")
            {
                to = "sn";
            }
            else if (comboBox2.Text == "Sindhi")
            {
                to = "sd";
            }
            else if (comboBox2.Text == "Sinhala")
            {
                to = "si";
            }
            else if (comboBox2.Text == "Slovak")
            {
                to = "sk";
            }
            else if (comboBox2.Text == "Slovenian")
            {
                to = "sl";
            }
            else if (comboBox2.Text == "Somali")
            {
                to = "so";
            }

            else if (comboBox2.Text == "Spanish")
            {
                to = "es";
            }
            else if (comboBox2.Text == "Sundanese")
            {
                to = "su";
            }
            else if (comboBox2.Text == "Swahili")
            {
                to = "sw";
            }
            else if (comboBox2.Text == "Swedish")
            {
                to = "sv";
            }
            else if (comboBox2.Text == "Tajik")
            {
                to = "tg";
            }
            else if (comboBox2.Text == "Tamil")
            {
                to = "ta";
            }
            else if (comboBox2.Text == "Tatar")
            {
                to = "tt";
            }
            else if (comboBox2.Text == "Telugu")
            {
                to = "te";
            }
            else if (comboBox2.Text == "Thai")
            {
                to = "th";
            }
            else if (comboBox2.Text == "Tigrinya")
            {
                to = "ti";
            }
            else if (comboBox2.Text == "Tsonga")
            {
                to = "ts";
            }
            else if (comboBox2.Text == "Turkish")
            {
                to = "tr";
            }
            else if (comboBox2.Text == "Turkmen")
            {
                to = "tk";
            }
            else if (comboBox2.Text == "Twi")
            {
                to = "ak";
            }
            else if (comboBox2.Text == "Ukrainian")
            {
                to = "uk";
            }
            else if (comboBox2.Text == "Urdu")
            {
                to = "ur";
            }
            else if (comboBox2.Text == "Uygher")
            {
                to = "ug";
            }
            else if (comboBox2.Text == "Uzbek")
            {
                to = "uz";
            }
            else if (comboBox2.Text == "Vietnamese")
            {
                to = "vi";
            }
            else if (comboBox2.Text == "Welsh")
            {
                to = "cy";
            }

            else if (comboBox2.Text == "Xhosa")
            {
                to = "xh";
            }
            else if (comboBox2.Text == "Yiddish")
            {
                to = "yi";
            }
            else if (comboBox2.Text == "Yoruba")
            {
                to = "yo";
            }
            else if (comboBox2.Text == "Zulu")
            {
                to = "zu";
            }
            OutputBox.Text = translate(OutputBox.Text, to, from);
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void Form3_Load_1(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ff3 < 20)
            {
                ff3 += 1;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            TexttoSpeech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo(to));
            TexttoSpeech.SpeakAsync(text);
        }
    }
}
