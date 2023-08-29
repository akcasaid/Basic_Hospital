namespace Proje_Hastane
{
    partial class FrmHastaKayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaKayit));
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.mskTlfn = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnKayitYap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(68, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Telefon Numarası:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSoyad.Location = new System.Drawing.Point(248, 129);
            this.txtSoyad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(296, 34);
            this.txtSoyad.TabIndex = 2;
            // 
            // mskTlfn
            // 
            this.mskTlfn.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTlfn.Location = new System.Drawing.Point(248, 213);
            this.mskTlfn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskTlfn.Mask = "(999) 000-0000";
            this.mskTlfn.Name = "mskTlfn";
            this.mskTlfn.Size = new System.Drawing.Size(296, 34);
            this.mskTlfn.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(100, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 26);
            this.label2.TabIndex = 7;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(166, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAd.Location = new System.Drawing.Point(248, 87);
            this.txtAd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(296, 34);
            this.txtAd.TabIndex = 1;
            // 
            // mskTc
            // 
            this.mskTc.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskTc.Location = new System.Drawing.Point(248, 171);
            this.mskTc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(296, 34);
            this.mskTc.TabIndex = 3;
            this.mskTc.ValidatingType = typeof(int);
            this.mskTc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(196, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 26);
            this.label4.TabIndex = 11;
            this.label4.Text = "Ad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(179, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "Şifre:";
            // 
            // txtSifre
            // 
            this.txtSifre.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSifre.Location = new System.Drawing.Point(248, 255);
            this.txtSifre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(296, 34);
            this.txtSifre.TabIndex = 5;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(248, 299);
            this.cmbCinsiyet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(296, 34);
            this.cmbCinsiyet.TabIndex = 6;
            this.cmbCinsiyet.SelectedIndexChanged += new System.EventHandler(this.cmbCinsiyet_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(158, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 26);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cinsiyet:";
            // 
            // btnKayitYap
            // 
            this.btnKayitYap.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayitYap.Location = new System.Drawing.Point(332, 341);
            this.btnKayitYap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKayitYap.Name = "btnKayitYap";
            this.btnKayitYap.Size = new System.Drawing.Size(137, 38);
            this.btnKayitYap.TabIndex = 19;
            this.btnKayitYap.Text = "Kayıt Yap";
            this.btnKayitYap.UseVisualStyleBackColor = true;
            this.btnKayitYap.Click += new System.EventHandler(this.btnKayitYap_Click);
            // 
            // FrmHastaKayit
            // 
            this.AcceptButton = this.btnKayitYap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(22F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(621, 457);
            this.Controls.Add(this.btnKayitYap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.mskTlfn);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.MaximizeBox = false;
            this.Name = "FrmHastaKayit";
            this.Text = "Hasta Kayıt";
            this.Load += new System.EventHandler(this.FrmHastaKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.MaskedTextBox mskTlfn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnKayitYap;
    }
}