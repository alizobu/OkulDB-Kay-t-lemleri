namespace OkulAppSube1BIL
{
    partial class frmOgrBul
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
            this.grpOgrBul = new System.Windows.Forms.GroupBox();
            this.btnbul = new System.Windows.Forms.Button();
            this.ogrbullbl = new System.Windows.Forms.Label();
            this.ogrbultext = new System.Windows.Forms.TextBox();
            this.grpOgrBul.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOgrBul
            // 
            this.grpOgrBul.Controls.Add(this.btnbul);
            this.grpOgrBul.Controls.Add(this.ogrbullbl);
            this.grpOgrBul.Controls.Add(this.ogrbultext);
            this.grpOgrBul.Location = new System.Drawing.Point(0, 0);
            this.grpOgrBul.Name = "grpOgrBul";
            this.grpOgrBul.Size = new System.Drawing.Size(370, 279);
            this.grpOgrBul.TabIndex = 0;
            this.grpOgrBul.TabStop = false;
            this.grpOgrBul.Text = "Öğrenci Bul";
            // 
            // btnbul
            // 
            this.btnbul.Location = new System.Drawing.Point(121, 190);
            this.btnbul.Name = "btnbul";
            this.btnbul.Size = new System.Drawing.Size(121, 31);
            this.btnbul.TabIndex = 2;
            this.btnbul.Text = "Öğrenci Bul";
            this.btnbul.UseVisualStyleBackColor = true;
            this.btnbul.Click += new System.EventHandler(this.btnbul_Click);
            // 
            // ogrbullbl
            // 
            this.ogrbullbl.AutoSize = true;
            this.ogrbullbl.Location = new System.Drawing.Point(127, 83);
            this.ogrbullbl.Name = "ogrbullbl";
            this.ogrbullbl.Size = new System.Drawing.Size(115, 16);
            this.ogrbullbl.TabIndex = 1;
            this.ogrbullbl.Text = "Öğrenci Numarası";
            // 
            // ogrbultext
            // 
            this.ogrbultext.Location = new System.Drawing.Point(130, 134);
            this.ogrbultext.Name = "ogrbultext";
            this.ogrbultext.Size = new System.Drawing.Size(100, 22);
            this.ogrbultext.TabIndex = 0;
            // 
            // frmOgrBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 291);
            this.Controls.Add(this.grpOgrBul);
            this.Name = "frmOgrBul";
            this.Text = "Öğrenci Bulma İşlemi";
            this.grpOgrBul.ResumeLayout(false);
            this.grpOgrBul.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOgrBul;
        private System.Windows.Forms.Button btnbul;
        private System.Windows.Forms.Label ogrbullbl;
        private System.Windows.Forms.TextBox ogrbultext;
    }
}