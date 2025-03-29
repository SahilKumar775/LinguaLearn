namespace Se_iteration01
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Services = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Pause = new CustomControls.RJControls.RJButton();
            this.Resume = new CustomControls.RJControls.RJButton();
            this.play = new CustomControls.RJControls.RJButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(0, 56);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 249);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(174)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.Services);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 57);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Services
            // 
            this.Services.FlatAppearance.BorderSize = 0;
            this.Services.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Services.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Services.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Services.Image = ((System.Drawing.Image)(resources.GetObject("Services.Image")));
            this.Services.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Services.Location = new System.Drawing.Point(682, 7);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(39, 43);
            this.Services.TabIndex = 12;
            this.Services.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Services.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(727, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(39, 38);
            this.button1.TabIndex = 13;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(118, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Text to speech";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Afrikaans",
            "Albanian",
            "Amharic",
            "Arabic",
            "Armenian",
            "Assamese",
            "Aymara",
            "Azerbaijani",
            "Bambara",
            "Basque",
            "Belarusian",
            "Bengali",
            "Bhojpuri",
            "Bosnian",
            "Bulgarian",
            "Catalan",
            "Cebuano",
            "Chichewa",
            "Chinese (Simplified)",
            "Chinese (Traditional)",
            "Corsican",
            "Croatian",
            "Czech",
            "Danish",
            "Dhivehi",
            "Dogri",
            "Dutch",
            "check",
            "English(recently used language)",
            "Esperanto",
            "Estonian",
            "Ewe",
            "Filipino",
            "Finnish",
            "French",
            "Frisian",
            "Galician",
            "Georgian",
            "German",
            "Greek",
            "Guarani",
            "Gujarati",
            "Haitian Creole",
            "Hausa",
            "Hawaiian",
            "Hebrew",
            "Hindi",
            "Hmong",
            "Hungarian",
            "Icelandic",
            "Igbo",
            "Ilocano",
            "Indonesian",
            "Irish",
            "Italian",
            "Japanese",
            "Javanese",
            "Kannada",
            "Kazakh",
            "history",
            "Khmer(recently used language)",
            "Kinyarwanda",
            "Konkani",
            "Korean",
            "Krio",
            "Kurdish (Kurmanji)",
            "Kurdish (Sorani)",
            "Kyrgyz",
            "Lao",
            "Latin",
            "Latvian",
            "Lingala",
            "Lithuanian",
            "Luganda",
            "Luxembourgish",
            "Macedonian",
            "Maithili",
            "Malagasy",
            "Malay",
            "Malayalam",
            "Maltese",
            "Maori",
            "Marathi",
            "Meiteilon (Manipuri)",
            "Mizo",
            "Mongolian",
            "Myanmar (Burmese)",
            "Nepali",
            "Norwegian",
            "Odia (Oriya)",
            "Oromo",
            "Pashto",
            "Persian",
            "Polish",
            "Portuguese",
            "Punjabi",
            "Quechua",
            "Romanian",
            "Russian",
            "Samoan",
            "Sanskrit",
            "Scots Gaelic",
            "Sepedi",
            "Serbian",
            "Sesotho",
            "Shona",
            "Sindhi",
            "Sinhala",
            "Slovak",
            "Slovenian",
            "Somali",
            "Spanish",
            "Sundanese",
            "Swahili",
            "Swedish",
            "Tajik",
            "Tamil",
            "Tatar",
            "Telugu",
            "Thai",
            "Tigrinya",
            "Tsonga",
            "Turkish",
            "Turkmen",
            "Twi",
            "Ukrainian",
            "Urdu",
            "Uyghur",
            "Uzbek",
            "Vietnamese",
            "Welsh",
            "Xhosa",
            "Yiddish",
            "Yoruba",
            "Zulu"});
            this.comboBox1.Location = new System.Drawing.Point(12, 405);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(754, 24);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Pause.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Pause.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Pause.BorderRadius = 0;
            this.Pause.BorderSize = 0;
            this.Pause.FlatAppearance.BorderSize = 0;
            this.Pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pause.ForeColor = System.Drawing.Color.White;
            this.Pause.Location = new System.Drawing.Point(319, 311);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(174, 68);
            this.Pause.TabIndex = 19;
            this.Pause.Text = "Pause";
            this.Pause.TextColor = System.Drawing.Color.White;
            this.Pause.UseVisualStyleBackColor = false;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Resume
            // 
            this.Resume.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.Resume.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.Resume.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.Resume.BorderRadius = 0;
            this.Resume.BorderSize = 0;
            this.Resume.FlatAppearance.BorderSize = 0;
            this.Resume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resume.ForeColor = System.Drawing.Color.White;
            this.Resume.Location = new System.Drawing.Point(626, 311);
            this.Resume.Name = "Resume";
            this.Resume.Size = new System.Drawing.Size(174, 68);
            this.Resume.TabIndex = 18;
            this.Resume.Text = "Resume";
            this.Resume.TextColor = System.Drawing.Color.White;
            this.Resume.UseVisualStyleBackColor = false;
            this.Resume.Click += new System.EventHandler(this.Resume_Click);
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.play.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.play.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.play.BorderRadius = 0;
            this.play.BorderSize = 0;
            this.play.FlatAppearance.BorderSize = 0;
            this.play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.play.ForeColor = System.Drawing.Color.White;
            this.play.Location = new System.Drawing.Point(12, 311);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(174, 68);
            this.play.TabIndex = 1;
            this.play.Text = "play";
            this.play.TextColor = System.Drawing.Color.White;
            this.play.UseVisualStyleBackColor = false;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pause);
            this.Controls.Add(this.Resume);
            this.Controls.Add(this.play);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private CustomControls.RJControls.RJButton play;
        private CustomControls.RJControls.RJButton Resume;
        private CustomControls.RJControls.RJButton Pause;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Services;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
    }
}