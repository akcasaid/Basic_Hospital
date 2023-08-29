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
    public partial class FrmHastaKayit : Form
    {
        public FrmHastaKayit()
        {
            InitializeComponent();
        }

        private void FrmHastaKayit_Load(object sender, EventArgs e)
        {

        }

        sqlbaglantisi bgl = new sqlbaglantisi();

        private void btnKayitYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Hastalar ( HastaAd, HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) values (@p1, @p2,@p3,@p4,@p5,@p6)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTc.Text);
            komut.Parameters.AddWithValue("@p4", mskTlfn.Text);
            komut.Parameters.AddWithValue("@p5", txtSifre.Text);
            komut.Parameters.AddWithValue("@p6", cmbCinsiyet.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleşmiştir. Şifreniz:" + txtSifre.Text, "Bilgi", MessageBoxButtons.OK,MessageBoxIcon.Information);

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cmbCinsiyet_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
