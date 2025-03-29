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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Se_iteration01
{
    public partial class Form5 : Form
    {
        SpeechSynthesizer speech;
        public static int ff4 { get; set; }
        public Form5()
        {

            InitializeComponent();
            speech = new SpeechSynthesizer();
            timer1.Interval = 60000;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Pause.Enabled = false;
            Resume.Enabled = false;
            timer1.Start();
        }

        private void play_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text != "")
            {
                if (comboBox1.Text == "Afrikaans")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("af-AF"));
                }
                else if (comboBox1.Text == "Albanian")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("sq-SQ"));
                }
                else if (comboBox1.Text == "Amharic")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("sl-SL"));
                }
                else if (comboBox1.Text == "Arabic")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ar-AR"));
                }
                else if (comboBox1.Text == "Armenian")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("hy-HY"));
                }
                else if (comboBox1.Text == "Assamese")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("as-AS"));
                }
                else if (comboBox1.Text == "Aymara")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ay-AY"));
                }
                else if (comboBox1.Text == "Azerbaijani")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("az-AZ"));
                }
                else if (comboBox1.Text == "Bambara")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("bm-BM"));
                }
                else if (comboBox1.Text == "Bengali")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("bn-BN"));
                }
                else if (comboBox1.Text == "Basque")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("eu-EU"));
                }
                else if (comboBox1.Text == "Belarusian")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("be-BE"));
                }
                else if (comboBox1.Text == "Bhojpuri")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("bho-BHO"));
                }
                else if (comboBox1.Text == "Bosnian")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("bs-BS"));
                }
                else if (comboBox1.Text == "Bulgarian")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("bg-BG"));
                }
              
                else if (comboBox1.Text == "Catalan")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ca-CA"));
                }
                else if (comboBox1.Text == "Cebuano")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ceb-CEB"));
                }
                else if (comboBox1.Text == "Chichewa")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ny-NY"));
                }
                
                else if (comboBox1.Text == "Chinese (Simplified)")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("zh-CN"));
                }
                else if (comboBox1.Text == "Chinese (Traditional)")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("zh-TW"));
                }
                else if (comboBox1.Text == "Corsican")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("co-CO"));
                }
                else if (comboBox1.Text == "Croatian")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("hr-HR"));
                }
                else if (comboBox1.Text == "Czech")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("cs-CS"));
                }
                else if (comboBox1.Text == "Danish")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("da-DA"));
                }
                else if (comboBox1.Text == "Divehi")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("dv-DV"));
                }
                else if (comboBox1.Text == "Dogri")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("doi-DOI"));
                }
                else if (comboBox1.Text == "Dutch")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("nl-NL"));
                }
                else if (comboBox1.Text == "English")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("en-EN"));
                }
                else if (comboBox1.Text == "Esperanto")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("eo-EO"));
                }
                else if (comboBox1.Text == "Estonian")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("et-ET"));
                }
                else if (comboBox1.Text == "Ewe")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ee-EE"));
                }
                else if (comboBox1.Text == "Filipino")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("tl-TL"));
                }
                else if (comboBox1.Text == "Finnish")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("fi-FI"));
                }
                else if (comboBox1.Text == "French")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("fr-FR"));
                }
                else if (comboBox1.Text == "Frisian")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("fy-FY"));
                }
                else if (comboBox1.Text == "Galician")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("gl-GL"));
                }
            
                else if (comboBox1.Text == "Georgian")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ka-KA"));
                }
                else if (comboBox1.Text == "German")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("de-DE"));
                }
                else if (comboBox1.Text == "Goan Konkani")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ko-KO"));
                }
                else if (comboBox1.Text == "Greek")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("el-EL"));
                }
                else if (comboBox1.Text == "Guarani")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("gn-GN"));
                }
                else if (comboBox1.Text == "Gujarati")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("gu-GU"));
                }
                else if (comboBox1.Text == "Haitian Creole")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ht-HT"));
                }
                else if (comboBox1.Text == "Hausa")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ha-HA"));
                }
                else if (comboBox1.Text == "Hawaiian")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("haw-HAW"));
                }
                else if (comboBox1.Text == "Hebrew")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("iw-IW"));
                }
                else if (comboBox1.Text == "Hindi")
                {
                    speech.SelectVoiceByHints(VoiceGender.NotSet, VoiceAge.NotSet, 1, new System.Globalization.CultureInfo("hi-IN"));
                }
                else if (comboBox1.Text == "Hmong")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("hmn-HMN"));
                }
                else if (comboBox1.Text == "Hungarian")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("hu-HU"));
                }
                else if (comboBox1.Text == "Icelandic")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("is-IS"));
                }
                else if (comboBox1.Text == "Igbo")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ig-IG"));
                }
                else if (comboBox1.Text == "Iloko")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ilo-ILO"));
                }
                else if (comboBox1.Text == "Indonesian")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("id-ID"));
                }
                else if (comboBox1.Text == "Irish")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ga-GA"));
                }
                else if (comboBox1.Text == "Italian")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("it-IT"));
                }
                else if (comboBox1.Text == "Japanese")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ja-JA"));
                }
                else if (comboBox1.Text == "Javanese")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("jw-JW"));
                }
                else if (comboBox1.Text == "Kannada")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("kn-KN"));
                }
                else if (comboBox1.Text == "Kazakh")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("kk-KK"));
                }
                else if (comboBox1.Text == "Khmer")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("km-KM"));
                }
                else if (comboBox1.Text == "Kinyarwanda")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("rw-RW"));
                }
                else if (comboBox1.Text == "Konkani")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("gom-GOM"));
                }
                else if (comboBox1.Text == "Korean")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ko-KO"));
                }
                else if (comboBox1.Text == "Krio")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("kri-KRI"));
                }
                else if (comboBox1.Text == "Kurdish (Kurmanji)")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ku-KU"));
                }
                else if (comboBox1.Text == "Kurdish (Sorani)")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ckb-CKB"));
                }
                else if (comboBox1.Text == "Kyrgyz")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ky-KY"));
                }
                else if (comboBox1.Text == "Lao")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("lo-LO"));
                }
                else if (comboBox1.Text == "Latin")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("la-LA"));
                }
                else if (comboBox1.Text == "Latvian")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("lv-LV"));
                }
                else if (comboBox1.Text == "Lingala")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ln-LN"));
                }
                else if (comboBox1.Text == "Lithuanian")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("lt-LT"));
                }
                else if (comboBox1.Text == "Luganda")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("lg-LG"));
                }
                else if (comboBox1.Text == "Luxembourgish")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("lb-LB"));
                }
                else if (comboBox1.Text == "Macedonian")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("mk-MK"));
                }
                else if (comboBox1.Text == "Maithili")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("mai-MAI"));
                }
                else if (comboBox1.Text == "Malagasy")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("mg-MG"));
                }
                else if (comboBox1.Text == "Malay")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ms-MS"));
                }
                else if (comboBox1.Text == "Malayalam")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ml-ML"));
                }
                else if (comboBox1.Text == "Maltese")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("mt-MT"));
                }
                else if (comboBox1.Text == "Meiteilon (Manipuri)")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("mni-Mtei"));
                }
                else if (comboBox1.Text == "Maori")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("mi-MI"));
                }
                else if (comboBox1.Text == "Marathi")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("mr-MR"));
                }
                else if (comboBox1.Text == "Mizo")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("lus-LUS"));
                }
                else if (comboBox1.Text == "Mongolian")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("mn-MN"));
                }
                else if (comboBox1.Text == "Myanmar (Burmese)")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("my-MY"));
                }
                else if (comboBox1.Text == "Nepali")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ne-NE"));
                }
               
                else if (comboBox1.Text == "Norwegian")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("no-NO"));
                }
                
                else if (comboBox1.Text == "Odia (Oriya)")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("or-OR"));
                }
                else if (comboBox1.Text == "Oromo")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("om-OM"));
                }
                else if (comboBox1.Text == "Pashto")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ps-PS"));
                }
                else if (comboBox1.Text == "Persian")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("fa-FA"));
                }
                else if (comboBox1.Text == "Polish")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("pl-PL"));
                }
                else if (comboBox1.Text == "Portuguese")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("pt-PT"));
                }
                else if (comboBox1.Text == "Punjabi")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("pa-PA"));
                }
                else if (comboBox1.Text == "Quechua")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("qu-QU"));
                }
                else if (comboBox1.Text == "Romanian")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ro-RO"));
                }
                else if (comboBox1.Text == "Russian")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ru-RU"));
                }
                else if (comboBox1.Text == "Samoan")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("sm-SM"));
                }
                else if (comboBox1.Text == "Sanskrit")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("sa-SA"));
                }
                else if (comboBox1.Text == "Scots Gaeelic")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("gd-GD"));
                }
                else if (comboBox1.Text == "Sepedi")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("nso-NSO"));
                }
                else if (comboBox1.Text == "Serbian")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("sr-SR"));
                }
                else if (comboBox1.Text == "Sesotho")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("st-ST"));
                }
                else if (comboBox1.Text == "Shona")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("sn-SN"));
                }
                else if (comboBox1.Text == "Sindhi")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("sd-SD"));
                }
                else if (comboBox1.Text == "Sinhala")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("si-SI"));
                }
                else if (comboBox1.Text == "Slovak")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("sk-SK"));
                }
                else if (comboBox1.Text == "Slovenian")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("sl-SL"));
                }
                else if (comboBox1.Text == "Somali")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("so-SO"));
                }
               
                else if (comboBox1.Text == "Spanish")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("es-ES"));
                }
                else if (comboBox1.Text == "Sundanese")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("su-SU"));
                }
                else if (comboBox1.Text == "Swahili")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("sw-SW"));
                }
                else if (comboBox1.Text == "Swedish")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("sv-SV"));
                }
                else if (comboBox1.Text == "Tajik")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("tg-TG"));
                }
                else if (comboBox1.Text == "Tamil")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ta-TA"));
                }
                else if (comboBox1.Text == "Tatar")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("tt-TT"));
                }
                else if (comboBox1.Text == "Telugu")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("te-TE"));
                }
                else if (comboBox1.Text == "Thai")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("th-TH"));
                }
                else if (comboBox1.Text == "Tigrinya")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ti-TI"));
                }
                else if (comboBox1.Text == "Tsonga")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ts-TS"));
                }
                else if (comboBox1.Text == "Turkish")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("tr-TR"));
                }
                else if (comboBox1.Text == "Turkmen")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("tk-TK"));
                }
                else if (comboBox1.Text == "Twi")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ak-AK"));
                }
                else if (comboBox1.Text == "Ukrainian")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("uk-UK"));
                }
                else if (comboBox1.Text == "Urdu")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ur-PK"));
                }
                else if (comboBox1.Text == "Uygher")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("ug-UG"));
                }
                else if (comboBox1.Text == "Uzbek")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("uz-UZ"));
                }
                else if (comboBox1.Text == "Vietnamese")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("vi-VI"));
                }
                else if (comboBox1.Text == "Welsh")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("cy-CY"));
                }
                
                else if (comboBox1.Text == "Xhosa")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("xh-XH"));
                }
                else if (comboBox1.Text == "Yiddish")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("yi-YI"));
                }
                else if (comboBox1.Text == "Yoruba")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("yo-YO"));
                }
                else if (comboBox1.Text == "Zulu")
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("zu-ZU"));
                }
                else
                {
                    speech.SelectVoiceByHints(VoiceGender.Female, VoiceAge.Adult, 1, new System.Globalization.CultureInfo("en-EN"));
                }
            
                speech.SpeakAsync(richTextBox1.Text);
                Pause.Enabled = true;
                //Pause.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f8 = new Form8();
            f8.ShowDialog();
        }

        private void Pause_Click(object sender, EventArgs e)
        {
            if (speech.State == SynthesizerState.Speaking)
            {
                speech.Pause();
                Resume.Enabled = true;
                play.Enabled = false;
            }
        }

        private void Resume_Click(object sender, EventArgs e)
        {
            if (speech.State == SynthesizerState.Paused)
            {
                speech.Resume();
                Resume.Enabled = false;
                play.Enabled = true;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f5 = new Form8();
            f5.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ff4 < 20)
            {
                ff4 += 1;
            }
        }
    }
}
