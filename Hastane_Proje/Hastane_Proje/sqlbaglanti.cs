using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Hastane_Proje
{
     class sqlbaglanti
    {

        public SqlConnection baglanti()
        {
            // baglanti adında method tanımladık ve bunu methot içinde 
            //SqlConnection dan baglan nesneesi ile diğer forumlarda sql bağlantısını direk bu nesen üzerinden tanımlamış olacağız 
            SqlConnection baglan = new SqlConnection("Data Source=POLAT\\SQLEXPRESS;Initial Catalog=HastaneProje;Integrated Security=True");

            baglan.Open();
            return baglan;

        }


    }
}
