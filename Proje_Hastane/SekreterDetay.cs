using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class SekreterDetay : Form
    {
        public SekreterDetay()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli drp = new FrmDoktorPaneli();
            drp.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public string tcnumara;
  

        

        sqlbaglantisi bgl = new sqlbaglantisi();


        private void SekreterDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tcnumara;
   
            //sqlbaglantisi bgl = new sqlbaglantisi();
            // ad soyad getitrme
            SqlCommand komut1 = new SqlCommand("select SekreterAdSoyad from Tbl_Sekreterler where sekretertc=@p1", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", lbltc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                //lblAdSoyad.Text = dr1[0];
                lblAdSoyad.Text = dr1[0].ToString();

            }
            bgl.baglanti().Close();

            //Branşlar  datagride aktarma

            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_branslar", bgl.baglanti());
            da.Fill(dt1);

            dataGridView2.DataSource = dt1;

            //Doktorları listeye aktarma

            DataTable dt2 = new DataTable();
            SqlDataAdapter da2 = new SqlDataAdapter("select (doktorad + ' ' + doktorsoyad) as 'Doktorlar', doktorbrans as 'Branşlar' from tbl_doktorlar", bgl.baglanti());
            da2.Fill(dt2);
            dataGridView3.DataSource = dt2;

            //Branş comco box'a aktarma

            SqlCommand komut2 = new SqlCommand("Select bransad from tbl_branslar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmcBrans.Items.Add(dr2[0].ToString());

            }
            bgl.baglanti().Close();

            //doktorları getirme

            SqlCommand komutdr = new SqlCommand("select doktorad,doktorsoyad from tbl_doktorlar where doktortc=@p1", bgl.baglanti());
            komutdr.Parameters.AddWithValue("@p1", cmbDoktor.Text);
            SqlDataReader drdr = komutdr.ExecuteReader();
            while (drdr.Read())

            {

             lblAdSoyad.Text = drdr[0] + " " + drdr[1];

           }
             bgl.baglanti().Close();


        }

        private void mskTc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into tbl_randevular (RandevuTarih,randevusaat,randevubrans,randevudoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", mskTarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", MskSaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cmcBrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cmbDoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu...");

        }

        private void cmcBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();

            SqlCommand komut = new SqlCommand("select Doktorad,doktorsoyad from tbl_doktorlar where doktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmcBrans.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbDoktor.Items.Add(dr[0] + " " + dr[1]);
      
            }
            bgl.baglanti().Close();
        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (duyuru) values (@d1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@d1", rchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru oluşturuldu");
            rchDuyuru.Clear();

        }

        private void btnBransPanle_Click(object sender, EventArgs e)
        {
            FrmBransPaneli frb = new FrmBransPaneli();
            frb.Show();

        }

        private void btnListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frmr = new FrmRandevuListesi();
            frmr.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {

        }

        private void btnduyuru_Click(object sender, EventArgs e)
        {
            FrmDuyurular fr = new FrmDuyurular();
            fr.Show();

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
