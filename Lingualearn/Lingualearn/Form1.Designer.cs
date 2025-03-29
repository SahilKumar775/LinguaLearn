namespace Se_iteration01
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Home = new System.Windows.Forms.Button();
            this.About = new System.Windows.Forms.Button();
            this.Services = new System.Windows.Forms.Button();
            this.Contact = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rjButton1 = new CustomControls.RJControls.RJButton();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(165)))), ((int)(((byte)(161)))));
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Home);
            this.panel1.Controls.Add(this.About);
            this.panel1.Controls.Add(this.Services);
            this.panel1.Controls.Add(this.Contact);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1268, 60);
            this.panel1.TabIndex = 0;
            // 
            // Home
            // 
            this.Home.FlatAppearance.BorderSize = 0;
            this.Home.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Home.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.Image = ((System.Drawing.Image)(resources.GetObject("Home.Image")));
            this.Home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Home.Location = new System.Drawing.Point(594, 5);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(150, 48);
            this.Home.TabIndex = 9;
            this.Home.Text = "Home";
            this.Home.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // About
            // 
            this.About.FlatAppearance.BorderSize = 0;
            this.About.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.About.Image = ((System.Drawing.Image)(resources.GetObject("About.Image")));
            this.About.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.About.Location = new System.Drawing.Point(750, 5);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(150, 48);
            this.About.TabIndex = 10;
            this.About.Text = "About";
            this.About.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // Services
            // 
            this.Services.FlatAppearance.BorderSize = 0;
            this.Services.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Services.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Services.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Services.Image = ((System.Drawing.Image)(resources.GetObject("Services.Image")));
            this.Services.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Services.Location = new System.Drawing.Point(906, 5);
            this.Services.Name = "Services";
            this.Services.Size = new System.Drawing.Size(150, 48);
            this.Services.TabIndex = 11;
            this.Services.Text = "Services";
            this.Services.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Services.UseVisualStyleBackColor = true;
            this.Services.Click += new System.EventHandler(this.Services_Click);
            // 
            // Contact
            // 
            this.Contact.FlatAppearance.BorderSize = 0;
            this.Contact.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.HotTrack;
            this.Contact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Contact.Font = new System.Drawing.Font("Cooper Black", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contact.Image = ((System.Drawing.Image)(resources.GetObject("Contact.Image")));
            this.Contact.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Contact.Location = new System.Drawing.Point(1062, 5);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(150, 48);
            this.Contact.TabIndex = 8;
            this.Contact.Text = "Contact";
            this.Contact.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Contact.UseVisualStyleBackColor = true;
            this.Contact.Click += new System.EventHandler(this.Contact_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lingualearn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Se_iteration01.Properties.Resources.image_1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(73, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // rjButton1
            // 
            this.rjButton1.BackColor = System.Drawing.Color.White;
            this.rjButton1.BackgroundColor = System.Drawing.Color.White;
            this.rjButton1.BorderColor = System.Drawing.Color.Purple;
            this.rjButton1.BorderRadius = 24;
            this.rjButton1.BorderSize = 3;
            this.rjButton1.FlatAppearance.BorderSize = 0;
            this.rjButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.rjButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton1.Font = new System.Drawing.Font("Cooper Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton1.ForeColor = System.Drawing.Color.Black;
            this.rjButton1.Location = new System.Drawing.Point(416, 461);
            this.rjButton1.Name = "rjButton1";
            this.rjButton1.Size = new System.Drawing.Size(375, 63);
            this.rjButton1.TabIndex = 1;
            this.rjButton1.Text = "Register";
            this.rjButton1.TextColor = System.Drawing.Color.Black;
            this.rjButton1.UseVisualStyleBackColor = false;
            this.rjButton1.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(1227, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 38);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Se_iteration01.Properties.Resources.download;
            this.ClientSize = new System.Drawing.Size(1268, 577);
            this.Controls.Add(this.rjButton1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private CustomControls.RJControls.RJButton rjButton1;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Button Services;
        private System.Windows.Forms.Button Contact;
        private System.Windows.Forms.Button button2;
    }
}

