namespace OgretmenKayitt
{
    partial class frmOgrtmnKayit
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
            this.grpOgretmen = new System.Windows.Forms.GroupBox();
            this.tctext = new System.Windows.Forms.TextBox();
            this.soyadtext = new System.Windows.Forms.TextBox();
            this.adtext = new System.Windows.Forms.TextBox();
            this.tclabel = new System.Windows.Forms.Label();
            this.soyadlabel = new System.Windows.Forms.Label();
            this.adlabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.kaydetbtn = new System.Windows.Forms.Button();
            this.bulbtn = new System.Windows.Forms.Button();
            this.guncellebtn = new System.Windows.Forms.Button();
            this.silbtn = new System.Windows.Forms.Button();
            this.grpOgretmen.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOgretmen
            // 
            this.grpOgretmen.Controls.Add(this.tctext);
            this.grpOgretmen.Controls.Add(this.soyadtext);
            this.grpOgretmen.Controls.Add(this.adtext);
            this.grpOgretmen.Controls.Add(this.tclabel);
            this.grpOgretmen.Controls.Add(this.soyadlabel);
            this.grpOgretmen.Controls.Add(this.adlabel);
            this.grpOgretmen.Location = new System.Drawing.Point(12, 0);
            this.grpOgretmen.Name = "grpOgretmen";
            this.grpOgretmen.Size = new System.Drawing.Size(431, 226);
            this.grpOgretmen.TabIndex = 0;
            this.grpOgretmen.TabStop = false;
            this.grpOgretmen.Text = "Öğretmen Bilgileri";
            // 
            // tctext
            // 
            this.tctext.Location = new System.Drawing.Point(178, 161);
            this.tctext.Name = "tctext";
            this.tctext.Size = new System.Drawing.Size(132, 22);
            this.tctext.TabIndex = 5;
            // 
            // soyadtext
            // 
            this.soyadtext.Location = new System.Drawing.Point(178, 111);
            this.soyadtext.Name = "soyadtext";
            this.soyadtext.Size = new System.Drawing.Size(132, 22);
            this.soyadtext.TabIndex = 4;
            // 
            // adtext
            // 
            this.adtext.Location = new System.Drawing.Point(178, 63);
            this.adtext.Name = "adtext";
            this.adtext.Size = new System.Drawing.Size(132, 22);
            this.adtext.TabIndex = 3;
            // 
            // tclabel
            // 
            this.tclabel.AutoSize = true;
            this.tclabel.Location = new System.Drawing.Point(92, 164);
            this.tclabel.Name = "tclabel";
            this.tclabel.Size = new System.Drawing.Size(25, 16);
            this.tclabel.TabIndex = 2;
            this.tclabel.Text = "TC";
            // 
            // soyadlabel
            // 
            this.soyadlabel.AutoSize = true;
            this.soyadlabel.Location = new System.Drawing.Point(81, 114);
            this.soyadlabel.Name = "soyadlabel";
            this.soyadlabel.Size = new System.Drawing.Size(47, 16);
            this.soyadlabel.TabIndex = 1;
            this.soyadlabel.Text = "Soyad";
            // 
            // adlabel
            // 
            this.adlabel.AutoSize = true;
            this.adlabel.Location = new System.Drawing.Point(92, 66);
            this.adlabel.Name = "adlabel";
            this.adlabel.Size = new System.Drawing.Size(24, 16);
            this.adlabel.TabIndex = 0;
            this.adlabel.Text = "Ad";
            // 
            // kaydetbtn
            // 
            this.kaydetbtn.Location = new System.Drawing.Point(178, 248);
            this.kaydetbtn.Name = "kaydetbtn";
            this.kaydetbtn.Size = new System.Drawing.Size(91, 37);
            this.kaydetbtn.TabIndex = 6;
            this.kaydetbtn.Text = "Kaydet";
            this.kaydetbtn.UseVisualStyleBackColor = true;
            this.kaydetbtn.Click += new System.EventHandler(this.kaydetbtn_Click_1);
            // 
            // bulbtn
            // 
            this.bulbtn.Location = new System.Drawing.Point(328, 263);
            this.bulbtn.Name = "bulbtn";
            this.bulbtn.Size = new System.Drawing.Size(95, 37);
            this.bulbtn.TabIndex = 7;
            this.bulbtn.Text = "BUL";
            this.bulbtn.UseVisualStyleBackColor = true;
            this.bulbtn.Click += new System.EventHandler(this.bulbtn_Click_1);
            // 
            // guncellebtn
            // 
            this.guncellebtn.Location = new System.Drawing.Point(41, 263);
            this.guncellebtn.Name = "guncellebtn";
            this.guncellebtn.Size = new System.Drawing.Size(87, 36);
            this.guncellebtn.TabIndex = 8;
            this.guncellebtn.Text = "Güncelle";
            this.guncellebtn.UseVisualStyleBackColor = true;
            this.guncellebtn.Click += new System.EventHandler(this.guncellebtn_Click_1);
            // 
            // silbtn
            // 
            this.silbtn.Location = new System.Drawing.Point(178, 317);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(91, 37);
            this.silbtn.TabIndex = 9;
            this.silbtn.Text = "Sil";
            this.silbtn.UseVisualStyleBackColor = true;
            this.silbtn.Click += new System.EventHandler(this.silbtn_Click_1);
            // 
            // frmOgrtmnKayit
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 376);
            this.Controls.Add(this.kaydetbtn);
            this.Controls.Add(this.bulbtn);
            this.Controls.Add(this.guncellebtn);
            this.Controls.Add(this.silbtn);
            this.Controls.Add(this.grpOgretmen);
            this.Name = "frmOgrtmnKayit";
            this.Text = "Öğretmen Kayıt İşlemleri";
            this.grpOgretmen.ResumeLayout(false);
            this.grpOgretmen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOgretmen;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        public System.Windows.Forms.TextBox tctext;
        public System.Windows.Forms.TextBox soyadtext;
        public System.Windows.Forms.TextBox adtext;
        private System.Windows.Forms.Label tclabel;
        private System.Windows.Forms.Label soyadlabel;
        private System.Windows.Forms.Label adlabel;
        private System.Windows.Forms.Button kaydetbtn;
        private System.Windows.Forms.Button bulbtn;
        private System.Windows.Forms.Button guncellebtn;
        private System.Windows.Forms.Button silbtn;
    }
}

