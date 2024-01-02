namespace OgretmenKayitt
{
    partial class frmOgretmenBul
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
            this.grpogretmenbul = new System.Windows.Forms.GroupBox();
            this.tclabel = new System.Windows.Forms.Label();
            this.ogretmenbultext = new System.Windows.Forms.TextBox();
            this.ogretmenbulbtn = new System.Windows.Forms.Button();
            this.grpogretmenbul.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpogretmenbul
            // 
            this.grpogretmenbul.Controls.Add(this.ogretmenbulbtn);
            this.grpogretmenbul.Controls.Add(this.ogretmenbultext);
            this.grpogretmenbul.Controls.Add(this.tclabel);
            this.grpogretmenbul.Location = new System.Drawing.Point(0, 0);
            this.grpogretmenbul.Name = "grpogretmenbul";
            this.grpogretmenbul.Size = new System.Drawing.Size(344, 269);
            this.grpogretmenbul.TabIndex = 0;
            this.grpogretmenbul.TabStop = false;
            this.grpogretmenbul.Text = "Öğretmen Bul";
            // 
            // tclabel
            // 
            this.tclabel.AutoSize = true;
            this.tclabel.Location = new System.Drawing.Point(106, 66);
            this.tclabel.Name = "tclabel";
            this.tclabel.Size = new System.Drawing.Size(87, 16);
            this.tclabel.TabIndex = 0;
            this.tclabel.Text = "Öğretmen TC";
            // 
            // ogretmenbultext
            // 
            this.ogretmenbultext.Location = new System.Drawing.Point(87, 113);
            this.ogretmenbultext.Name = "ogretmenbultext";
            this.ogretmenbultext.Size = new System.Drawing.Size(135, 22);
            this.ogretmenbultext.TabIndex = 1;
            // 
            // ogretmenbulbtn
            // 
            this.ogretmenbulbtn.Location = new System.Drawing.Point(109, 170);
            this.ogretmenbulbtn.Name = "ogretmenbulbtn";
            this.ogretmenbulbtn.Size = new System.Drawing.Size(98, 32);
            this.ogretmenbulbtn.TabIndex = 2;
            this.ogretmenbulbtn.Text = "BUL";
            this.ogretmenbulbtn.UseVisualStyleBackColor = true;
            this.ogretmenbulbtn.Click += new System.EventHandler(this.ogretmenbulbtn_Click);
            // 
            // frmOgretmenBul
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 280);
            this.Controls.Add(this.grpogretmenbul);
            this.Name = "frmOgretmenBul";
            this.Text = "Öğretmen Bulma İşlemleri";
            this.grpogretmenbul.ResumeLayout(false);
            this.grpogretmenbul.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpogretmenbul;
        private System.Windows.Forms.TextBox ogretmenbultext;
        private System.Windows.Forms.Label tclabel;
        private System.Windows.Forms.Button ogretmenbulbtn;
    }
}