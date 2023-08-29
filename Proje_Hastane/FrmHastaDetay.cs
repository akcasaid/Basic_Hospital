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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string tc;

        //Ad Soayd Çekme

        sqlbaglantisi bgl = new sqlbaglantisi();
       
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = tc;

            SqlCommand komut = new SqlCommand("select HastaAd, HastaSoyad from tbl_hastalar where HastaTc=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1",lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1]; // 2 sorgu dönüyor çünkü 
                bgl.baglanti().Close();
            }

            // Randevu geçmişi 

            DataTable dt = new DataTable();

            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevular where HastaTc=" + tc, bgl.baglanti());
            da.Fill(dt); // da'yı dt den gelen bilgilerle doldur
            dataGridView1.DataSource = dt;

            // Branşları çekme

            SqlCommand komut2 = new SqlCommand("select BransAd from Tbl_branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbBrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();           

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void RchSikayet_TextChanged(object sender, EventArgs e)
        {

        }

        //private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    cmbDoktor.Items.Clear();
        //    SqlCommand komut3 = new SqlCommand("select doktorAd,doktorSoyad from tbl_doktorlar where doktorBrans=@p1", bgl.baglanti());
        //    komut3.Parameters.AddWithValue("@p1", cmbBrans.Text);
        //    SqlDataReader dr3 = komut3.ExecuteReader();
        //    while (dr3.Read())
        //    {
        //        cmbDoktor.Items.Add(dr3[0] +" " + dr3[1]);

        //    }

        //    bgl.baglanti().Close();
        //}


        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevular where randevuBrans='" + cmbBrans.Text+ "'" + "and RandevuDoktor='"+ cmbDoktor.Text+"' and randevudurumu=0",bgl.baglanti()); //kelime bazlı arama sql de tek tırnaklar arası olur
            da.Fill(dt);
            dataGridView2.DataSource = dt;
                      
        }

        private void lnkbilgiduzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDuzenle fr = new FrmBilgiDuzenle();
            fr.TCno = lblTC.Text;
            fr.Show();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtid.Text = secilen.ToString();

        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_randevular set randevudurum=1,hastatc=@p1,hastasikaye=@p2 where randevuid=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            komut.Parameters.AddWithValue("@p2", RchSikayet.Text);
            komut.Parameters.AddWithValue("@p3", txtid.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alında", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void lblAdSoyad_Click(object sender, EventArgs e)
        {

        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("select doktorad,doktorsoyad from tbl_doktorlar where doktorbrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbDoktor.Items.Add(dr3[0] + " " + dr3[1]);

            }
            bgl.baglanti().Close();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
