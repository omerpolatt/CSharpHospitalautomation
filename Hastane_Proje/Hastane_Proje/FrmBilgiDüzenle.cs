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
    public partial class FrmBilgiDüzenle : Form
    {
        public FrmBilgiDüzenle()
        {
            InitializeComponent();
        }

        public string tc; // tc değişkeni tanımlayıp bunu hastadetay formundan çektik 

        sqlbaglanti bgl = new sqlbaglanti();

        private void FrmBilgiDüzenle_Load(object sender, EventArgs e)
        {
            msktc.Text = tc;

            SqlCommand komut1 = new SqlCommand("Select * from Tbl_Hastalar where HastaTC = @1",bgl.baglanti());

            komut1.Parameters.AddWithValue("@1",msktc.Text);

            SqlDataReader dr = komut1.ExecuteReader();  
             while (dr.Read()) 
            { 
                txtad.Text = dr[1].ToString();
                txtsoyad.Text = dr[2].ToString();
                msktel.Text = dr[4].ToString();
                txtsifre.Text = dr[5].ToString();
                cmbcinsiyet.Text = dr[6].ToString();

            }
            bgl.baglanti().Close();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            // UPDATE sorgusunda muhakkak where şartı koymalısın yoksa tüm verileri güncelleme işlemi yapar 
            SqlCommand komut2 = new SqlCommand("Update Tbl_Hastalar set HastaAd=@1,HastaSoyad=@2,HastaTelefon=@3,HastaSifre=@4,HastaCinsiyet=@5 where HastaTC = @6",bgl.baglanti());

            komut2.Parameters.AddWithValue("@1",txtad.Text);
            komut2.Parameters.AddWithValue("@2",txtsoyad.Text);
            komut2.Parameters.AddWithValue("@3", msktel.Text);
            komut2.Parameters.AddWithValue("@4",txtsifre.Text);
            komut2.Parameters.AddWithValue("@5",cmbcinsiyet.Text);
            komut2.Parameters.AddWithValue("@6", msktc.Text);

            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("BİLGİLERİNİZ GÜNCELLENMİŞTİR","GÜNCELLEME",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }
    }
}
