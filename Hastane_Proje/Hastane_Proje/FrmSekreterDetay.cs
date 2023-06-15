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
    public partial class FrmSekreterDetay : Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        public string tc;
        sqlbaglanti bgl =  new sqlbaglanti();

        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;

            //ad soyad çekme
            SqlCommand komut1 = new SqlCommand("Select SekreterAdSoyad from Tbl_Sekreter where SekreterTC = @1",bgl.baglanti());

            komut1.Parameters.AddWithValue("@1", lbltc.Text);
            SqlDataReader dr1 = komut1.ExecuteReader();  
            while (dr1.Read())
            {
                lbladsoyad.Text = dr1[0].ToString();    
            }
            bgl.baglanti().Close();



            // bu işlemi yapmadık ayarlarından direk biz branşları kendiimiz ekledik    
            // veritabanındaki branşları comboboxa ekleme işlemi (randevu oluşturmadaki comoboboxa )

            /*-
            SqlCommand ekle1 = new SqlCommand("Select BransAd from Tbl_Branslar", bgl.baglanti());
            SqlDataReader dr1 = ekle1.ExecuteReader();  
            while (dr1.Read())
            {
                cmbBrans.Items.Add(dr1[0].ToString());
            }
            bgl.baglanti().Close();-*/




            // bransları datagridviewde görüntüleme işlemi
            // datagridview de alanları otomatik tam doldurması için AutSizeColumnsMode ayarını 'Fill' yaptık
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from Tbl_Branslar",bgl.baglanti());

            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;


            // doktorları datagridview de görüntüleme işlemi 

            DataTable dt2 = new DataTable();

            SqlDataAdapter da2 = new SqlDataAdapter("Select Doktorid,DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC from Tbl_Doktorlar", bgl.baglanti());

            da2.Fill(dt2);
            dataGridView2.DataSource = dt2;


        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkayıt = new SqlCommand("Insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) Values (@1,@2,@3,@4)",bgl.baglanti());

            komutkayıt.Parameters.AddWithValue("@1", msktarih.Text);
            komutkayıt.Parameters.AddWithValue("@2", msksaat.Text);
            komutkayıt.Parameters.AddWithValue("@3", cmbBrans.Text);
            komutkayıt.Parameters.AddWithValue("@4", cmbdr.Text);

            komutkayıt.ExecuteNonQuery();
            bgl.baglanti().Close();
            
            MessageBox.Show("Randevunuz Oluşturulmuştur","BİLGİ",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            // bransa ait doktoorları göstermesi iiiçin bu kodları formun kısmınıa değil de bransın alanına yazıs olduk
            // dokotoları comboboxda gösterme işlemi 

            cmbdr.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where DoktorBrans = @1",bgl.baglanti());
            komut3.Parameters.AddWithValue("@1",cmbBrans.Text);
            SqlDataReader dr3 = komut3.ExecuteReader(); 
            while (dr3.Read()) 
            {
                cmbdr.Items.Add(dr3[0]+" " + dr3[1]);

            }
            bgl.baglanti().Close(); 
        }

        private void btnolustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Insert into Tbl_Duyurular (Duyuru) values (@1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@1",richTextBox1.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void btndoktorpaneli_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frmdoktorpaneli = new FrmDoktorPaneli();
            frmdoktorpaneli.Show();
        }
    }
}
