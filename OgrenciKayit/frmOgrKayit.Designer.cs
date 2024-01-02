namespace OkulAppSube1BIL
{
    partial class frmOgrKayit
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
            this.grpOgrenci = new System.Windows.Forms.GroupBox();
            this.lblNumara = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtNumara = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.ogrencibul = new System.Windows.Forms.Button();
            this.ogrguncelle = new System.Windows.Forms.Button();
            this.ogrsil = new System.Windows.Forms.Button();
            this.grpOgrenci.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOgrenci
            // 
            this.grpOgrenci.Controls.Add(this.lblNumara);
            this.grpOgrenci.Controls.Add(this.lblSoyad);
            this.grpOgrenci.Controls.Add(this.lblAd);
            this.grpOgrenci.Controls.Add(this.txtNumara);
            this.grpOgrenci.Controls.Add(this.txtSoyad);
            this.grpOgrenci.Controls.Add(this.txtAd);
            this.grpOgrenci.Location = new System.Drawing.Point(16, 15);
            this.grpOgrenci.Margin = new System.Windows.Forms.Padding(4);
            this.grpOgrenci.Name = "grpOgrenci";
            this.grpOgrenci.Padding = new System.Windows.Forms.Padding(4);
            this.grpOgrenci.Size = new System.Drawing.Size(452, 249);
            this.grpOgrenci.TabIndex = 0;
            this.grpOgrenci.TabStop = false;
            this.grpOgrenci.Text = "Öğrenci Bilgileri";
            // 
            // lblNumara
            // 
            this.lblNumara.AutoSize = true;
            this.lblNumara.Location = new System.Drawing.Point(93, 162);
            this.lblNumara.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumara.Name = "lblNumara";
            this.lblNumara.Size = new System.Drawing.Size(55, 16);
            this.lblNumara.TabIndex = 5;
            this.lblNumara.Text = "Numara";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(93, 132);
            this.lblSoyad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(47, 16);
            this.lblSoyad.TabIndex = 4;
            this.lblSoyad.Text = "Soyad";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(93, 97);
            this.lblAd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(24, 16);
            this.lblAd.TabIndex = 3;
            this.lblAd.Text = "Ad";
            // 
            // txtNumara
            // 
            this.txtNumara.Location = new System.Drawing.Point(163, 159);
            this.txtNumara.Margin = new System.Windows.Forms.Padding(4);
            this.txtNumara.Name = "txtNumara";
            this.txtNumara.Size = new System.Drawing.Size(132, 22);
            this.txtNumara.TabIndex = 2;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(163, 123);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(132, 22);
            this.txtSoyad.TabIndex = 1;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(163, 89);
            this.txtAd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(132, 22);
            this.txtAd.TabIndex = 0;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(178, 279);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(133, 28);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // ogrencibul
            // 
            this.ogrencibul.Location = new System.Drawing.Point(349, 279);
            this.ogrencibul.Name = "ogrencibul";
            this.ogrencibul.Size = new System.Drawing.Size(100, 28);
            this.ogrencibul.TabIndex = 7;
            this.ogrencibul.Text = "BUL";
            this.ogrencibul.UseVisualStyleBackColor = true;
            this.ogrencibul.Click += new System.EventHandler(this.ogrencibul_Click);
            // 
            // ogrguncelle
            // 
            this.ogrguncelle.Location = new System.Drawing.Point(45, 279);
            this.ogrguncelle.Name = "ogrguncelle";
            this.ogrguncelle.Size = new System.Drawing.Size(88, 28);
            this.ogrguncelle.TabIndex = 8;
            this.ogrguncelle.Text = "Güncelle";
            this.ogrguncelle.UseVisualStyleBackColor = true;
            this.ogrguncelle.Click += new System.EventHandler(this.ogrguncelle_Click);
            // 
            // ogrsil
            // 
            this.ogrsil.Location = new System.Drawing.Point(179, 334);
            this.ogrsil.Name = "ogrsil";
            this.ogrsil.Size = new System.Drawing.Size(132, 32);
            this.ogrsil.TabIndex = 9;
            this.ogrsil.Text = "Sil";
            this.ogrsil.UseVisualStyleBackColor = true;
            this.ogrsil.Click += new System.EventHandler(this.ogrsil_Click);
            // 
            // frmOgrKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 389);
            this.Controls.Add(this.ogrsil);
            this.Controls.Add(this.ogrguncelle);
            this.Controls.Add(this.ogrencibul);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.grpOgrenci);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmOgrKayit";
            this.Text = "Öğrenci Kayıt İşlemleri";
            this.grpOgrenci.ResumeLayout(false);
            this.grpOgrenci.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOgrenci;
        private System.Windows.Forms.Label lblNumara;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button ogrencibul;
        public System.Windows.Forms.TextBox txtNumara;
        public System.Windows.Forms.TextBox txtSoyad;
        public System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Button ogrguncelle;
        private System.Windows.Forms.Button ogrsil;
    }
}

