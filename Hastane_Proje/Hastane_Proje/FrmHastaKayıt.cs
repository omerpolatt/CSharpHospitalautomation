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

namespace Hastane_Proje
{
    public partial class FrmHastaKayıt : Form
    {
        public FrmHastaKayıt()
        {
            InitializeComponent();
        }


        // ekranın özelliklerinden  MaxsimizeBox özelliğğini False yaparak "Büyük Ekran" olmasını engelledik 
        //AutoSizeMode özelliğinide "Grow and Shrink" yaparak pencere ekraının büyütülmesini ve küçültülmesini engelledik 
        // AcceptButton özelliğini "btnkayıtyap" seçtiğimizde enter tuşuna basınca butonu çalıştıracaktır

        sqlbaglanti bgl = new sqlbaglanti();
        // sınıfımızdan nesne üretip bağlantımızı bağladık 
        // sınıf içinde bağlantı açık olduğu için tekrar bağlantıyı açmamıza gerek yok 

        private void btnkayıtyap_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Insert into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTC,HastaTelefon,HastaSifre,HastaCinsiyet) VALUES (@1,@2,@3,@4,@5,@6)",bgl.baglanti()) ;

            komut.Parameters.AddWithValue("@1",txtad.Text);
            komut.Parameters.AddWithValue("@2", txtsoyad.Text);
            komut.Parameters.AddWithValue("@3", msktc.Text);
            komut.Parameters.AddWithValue("@4", msktel.Text);
            komut.Parameters.AddWithValue("@5", txtsifre.Text);
            komut.Parameters.AddWithValue("@6", cmbcinsiyet.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("KAYDINIZ GEREÇEKLEŞMİŞTİR ŞİFRENİZ : " + txtsifre.Text ,"BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);





        }
    }
}
