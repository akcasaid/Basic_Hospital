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
    public partial class FrmDoktorDetay : Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        sqlbaglantisi bgl = new sqlbaglantisi();
        public string TC;

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TC;

            //Doktor ad soyad çekme

            SqlCommand komut = new SqlCommand("select doktorad,doktorsoyad from tbl_doktorlar where doktortc=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())

            {

                lblAdSoyad.Text = dr[0] + " " + dr[1];
            
            }
            bgl.baglanti().Close();


            // Randevularuı Getirme

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevular where RandevuDoktor='" + lblAdSoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;



             


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblTC_Click(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            FrmDoktorBilgiDuzenle fr = new FrmDoktorBilgiDuzenle();
            fr.TCNO = lblTC.Text;
            fr.Show();
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            RchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
