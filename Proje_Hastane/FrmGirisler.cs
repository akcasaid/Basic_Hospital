using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje_Hastane
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmHastaGiris fr = new FrmHastaGiris();
            fr.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
    
            
        }

        private void btnDoktorGirisi_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris fr1 = new FrmDoktorGiris();
            fr1.Show();
            this.Hide();
        }

        private void btnSekreterGirisi_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris fr2 = new FrmSekreterGiris();
            fr2.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
