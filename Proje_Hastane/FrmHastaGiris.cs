using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmHastaGiris_Load(object sender, EventArgs e)
        {

        }
        sqlbaglantisi bgl = new sqlbaglantisi();

        private void lnkUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayit fr = new FrmHastaKayit();
            fr.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_Hastalar where hastatc=@p1 and hastaSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTc.Text);
            komut.Parameters.AddWithValue("@p2", txbxSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmHastaDetay fr = new FrmHastaDetay();
                fr.tc = mskTc.Text;
               
                fr.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Kullanıcı TC veya Şifre Yalnış girdiniz...");
            }

            bgl.baglanti().Close();


        }
    }
}
