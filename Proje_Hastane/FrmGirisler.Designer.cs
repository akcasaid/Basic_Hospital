namespace Proje_Hastane
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.btnDoktorGirisi = new System.Windows.Forms.Button();
            this.btnHastaGirisi = new System.Windows.Forms.Button();
            this.btnSekreterGirisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbldoktor = new System.Windows.Forms.Label();
            this.lblsekreter = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDoktorGirisi
            // 
            this.btnDoktorGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDoktorGirisi.BackgroundImage")));
            this.btnDoktorGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDoktorGirisi.Location = new System.Drawing.Point(489, 358);
            this.btnDoktorGirisi.Name = "btnDoktorGirisi";
            this.btnDoktorGirisi.Size = new System.Drawing.Size(296, 263);
            this.btnDoktorGirisi.TabIndex = 0;
            this.btnDoktorGirisi.UseVisualStyleBackColor = true;
            this.btnDoktorGirisi.Click += new System.EventHandler(this.btnDoktorGirisi_Click);
            // 
            // btnHastaGirisi
            // 
            this.btnHastaGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnHastaGirisi.BackgroundImage")));
            this.btnHastaGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHastaGirisi.Location = new System.Drawing.Point(64, 358);
            this.btnHastaGirisi.Name = "btnHastaGirisi";
            this.btnHastaGirisi.Size = new System.Drawing.Size(304, 263);
            this.btnHastaGirisi.TabIndex = 1;
            this.btnHastaGirisi.UseVisualStyleBackColor = true;
            this.btnHastaGirisi.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSekreterGirisi
            // 
            this.btnSekreterGirisi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSekreterGirisi.BackgroundImage")));
            this.btnSekreterGirisi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSekreterGirisi.Location = new System.Drawing.Point(915, 358);
            this.btnSekreterGirisi.Name = "btnSekreterGirisi";
            this.btnSekreterGirisi.Size = new System.Drawing.Size(304, 263);
            this.btnSekreterGirisi.TabIndex = 2;
            this.btnSekreterGirisi.UseVisualStyleBackColor = true;
            this.btnSekreterGirisi.Click += new System.EventHandler(this.btnSekreterGirisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 648);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hasta";
            // 
            // lbldoktor
            // 
            this.lbldoktor.AutoSize = true;
            this.lbldoktor.Location = new System.Drawing.Point(586, 648);
            this.lbldoktor.Name = "lbldoktor";
            this.lbldoktor.Size = new System.Drawing.Size(82, 27);
            this.lbldoktor.TabIndex = 4;
            this.lbldoktor.Text = "Doktor";
            // 
            // lblsekreter
            // 
            this.lblsekreter.AutoSize = true;
            this.lblsekreter.Location = new System.Drawing.Point(1019, 648);
            this.lblsekreter.Name = "lblsekreter";
            this.lblsekreter.Size = new System.Drawing.Size(96, 27);
            this.lblsekreter.TabIndex = 5;
            this.lblsekreter.Text = "Sekreter";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(873, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 279);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Firebrick;
            this.label2.Location = new System.Drawing.Point(113, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(480, 81);
            this.label2.TabIndex = 7;
            this.label2.Text = "C# Hospital";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FrmGirisler
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.ClientSize = new System.Drawing.Size(1248, 709);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblsekreter);
            this.Controls.Add(this.lbldoktor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSekreterGirisi);
            this.Controls.Add(this.btnHastaGirisi);
            this.Controls.Add(this.btnDoktorGirisi);
            this.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.Text = "Hastane Giriş Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDoktorGirisi;
        private System.Windows.Forms.Button btnHastaGirisi;
        private System.Windows.Forms.Button btnSekreterGirisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbldoktor;
        private System.Windows.Forms.Label lblsekreter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}

