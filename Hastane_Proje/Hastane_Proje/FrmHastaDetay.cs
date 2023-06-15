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
    public partial class FrmHastaDetay : Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string tc; // tc adlı bir değişken tanıdık ve bu değişkeni hastagiriş formundaki msktc den almış olduk 

        sqlbaglanti bgl = new sqlbaglanti();
        
        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lbltc.Text = tc;
            // AD SOYAD ÇEKME İŞLMEİ 
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad from Tbl_Hastalar where HastaTC = @1",bgl.baglanti());

            komut.Parameters.AddWithValue("@1",lbltc.Text);
            SqlDataReader dr = komut.ExecuteReader();   
            while(dr.Read())
            {

                lbladsoyad.Text = dr[0] +" "+ dr[1]; // SQL sorgusunda çıkan 1. ve 2. indeks sonucu olduğu için dr den indeks komutlarını kullandık 
            }

            bgl.baglanti().Close();


            // RANDEVU GEÇMİŞİ İŞLEMİ 

            DataTable dt = new DataTable(); // veritablosu oluşturduk 

            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular where HastaTC = "+tc,bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            // Datatable değişkeni ile tablo oluşturuyoruz 
            // sqldataadapter ile verileri bu değişken ile aldık ve datagridviewi tablo ile doldurduk 



            // Branşları çekme 
            SqlCommand komut2 = new SqlCommand("Select BransAd from Tbl_Branslar ",bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader(); 
            while(dr2.Read())
            {
                cmbbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();


          
        }

        private void cmbbrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            // seçilen bransa göre doktor comboboxunda dr leri gösterttik 
            cmbdr.Items.Clear();

            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad from Tbl_Doktorlar where (DoktorBrans = @1)",bgl.baglanti());
            komut3.Parameters.AddWithValue("@1",cmbbrans.Text); 

            SqlDataReader dr3 = komut3.ExecuteReader(); 
            while(dr3.Read())
            {
                cmbdr.Items.Add(dr3[0] + " "+ dr3[1]);
            }
            

            bgl.baglanti().Close();


        }

        private void cmbdr_SelectedIndexChanged(object sender, EventArgs e)
        {
            // DOKTOR SEÇİMİ SONRASI tabloya randevuları ekleyip datagridwievde gözükmesini sağladık
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select *  From Tbl_Randevular where RandevuBrans = ' " + cmbbrans.Text + "'",bgl.baglanti());

            da.Fill(dt);    
            dataGridView2.DataSource = dt;



        }

        private void lnkbilgiduzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgiDüzenle frmbilgiduzenle = new FrmBilgiDüzenle();

            frmbilgiduzenle.tc = lbltc.Text;

            frmbilgiduzenle.Show();




        }
    }


        
    
}
