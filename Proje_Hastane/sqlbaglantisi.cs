using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Proje_Hastane
{
    class sqlbaglantisi
    {
        public SqlConnection baglanti()
        {
            // Data Source=saidakca;Initial Catalog=HastaneProje;Integrated Security=True
            // sqlbaglantisi -- sınıfımın adı
            // baglanti -- metodumun adı
            // bağlan -- sqlconnetiondan ürettiğim adresimi tutan nesne 
            SqlConnection baglan = new SqlConnection("Data Source=saidakca;Initial Catalog=HastaneProje;Integrated Security=True");
            baglan.Open();
            return baglan;

        }
    }
}
