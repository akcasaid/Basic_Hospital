namespace Proje_Hastane
{
    partial class FrmBilgiDuzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgiDuzenle));
            this.btnbilgiguncelle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.mskTlfn = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnbilgiguncelle
            // 
            this.btnbilgiguncelle.Location = new System.Drawing.Point(281, 488);
            this.btnbilgiguncelle.Name = "btnbilgiguncelle";
            this.btnbilgiguncelle.Size = new System.Drawing.Size(297, 52);
            this.btnbilgiguncelle.TabIndex = 32;
            this.btnbilgiguncelle.Text = "Güncelle";
            this.btnbilgiguncelle.UseVisualStyleBackColor = true;
            this.btnbilgiguncelle.Click += new System.EventHandler(this.btnbilgiguncelle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F);
            this.label6.Location = new System.Drawing.Point(143, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 34);
            this.label6.TabIndex = 31;
            this.label6.Text = "Cinsiyet:";
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(269, 416);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(311, 36);
            this.cmbCinsiyet.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(181, 353);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 34);
            this.label5.TabIndex = 29;
            this.label5.Text = "Şifre:";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(267, 351);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(311, 36);
            this.txtSifre.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(166, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 34);
            this.label1.TabIndex = 27;
            this.label1.Text = "Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(269, 81);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(309, 36);
            this.txtAd.TabIndex = 1;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(269, 216);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(309, 36);
            this.msktc.TabIndex = 3;
            this.msktc.ValidatingType = typeof(int);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(204, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 34);
            this.label4.TabIndex = 24;
            this.label4.Text = "Ad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(28, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 34);
            this.label3.TabIndex = 23;
            this.label3.Text = "Telefon Numarası:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(269, 149);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(309, 36);
            this.txtSoyad.TabIndex = 2;
            // 
            // mskTlfn
            // 
            this.mskTlfn.Location = new System.Drawing.Point(269, 286);
            this.mskTlfn.Mask = "(999) 000-0000";
            this.mskTlfn.Name = "mskTlfn";
            this.mskTlfn.Size = new System.Drawing.Size(309, 36);
            this.mskTlfn.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(68, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 34);
            this.label2.TabIndex = 20;
            this.label2.Text = "TC Kimlik No:";
            // 
            // FrmBilgiDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(692, 571);
            this.Controls.Add(this.btnbilgiguncelle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.mskTlfn);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimizeBox = false;
            this.Name = "FrmBilgiDuzenle";
            this.Text = "Bilgi Güncelleme";
            this.Load += new System.EventHandler(this.FrmBilgiDuzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnbilgiguncelle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.MaskedTextBox mskTlfn;
        private System.Windows.Forms.Label label2;
    }
}