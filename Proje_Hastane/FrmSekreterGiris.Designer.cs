namespace Proje_Hastane
{
    partial class FrmSekreterGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterGiris));
            this.label3 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lnkUyeOl = new System.Windows.Forms.LinkLabel();
            this.txbxSifre = new System.Windows.Forms.TextBox();
            this.mskTc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(309, 353);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Şifre:";
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(424, 381);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(124, 27);
            this.btnGiris.TabIndex = 12;
            this.btnGiris.Text = "Giriş Yap";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lnkUyeOl
            // 
            this.lnkUyeOl.AutoSize = true;
            this.lnkUyeOl.Location = new System.Drawing.Point(554, 348);
            this.lnkUyeOl.Name = "lnkUyeOl";
            this.lnkUyeOl.Size = new System.Drawing.Size(67, 22);
            this.lnkUyeOl.TabIndex = 11;
            this.lnkUyeOl.TabStop = true;
            this.lnkUyeOl.Text = "Üye Ol";
            // 
            // txbxSifre
            // 
            this.txbxSifre.Location = new System.Drawing.Point(370, 345);
            this.txbxSifre.Name = "txbxSifre";
            this.txbxSifre.Size = new System.Drawing.Size(178, 30);
            this.txbxSifre.TabIndex = 10;
            this.txbxSifre.Text = "1907";
            this.txbxSifre.UseSystemPasswordChar = true;
            // 
            // mskTc
            // 
            this.mskTc.Location = new System.Drawing.Point(370, 296);
            this.mskTc.Mask = "00000000000";
            this.mskTc.Name = "mskTc";
            this.mskTc.Size = new System.Drawing.Size(178, 30);
            this.mskTc.TabIndex = 9;
            this.mskTc.Text = "99999999999";
            this.mskTc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(234, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "TC Kimlik No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
            this.label1.Location = new System.Drawing.Point(156, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(726, 90);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sekreter Giriş Paneli ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmSekreterGiris
            // 
            this.AcceptButton = this.btnGiris;
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Clock;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(978, 677);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.lnkUyeOl);
            this.Controls.Add(this.txbxSifre);
            this.Controls.Add(this.mskTc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmSekreterGiris";
            this.Text = "Sekreter Giriş Paneli";
            this.Load += new System.EventHandler(this.FrmSekreterGiris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.LinkLabel lnkUyeOl;
        private System.Windows.Forms.TextBox txbxSifre;
        private System.Windows.Forms.MaskedTextBox mskTc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}