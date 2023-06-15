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
    public partial class FrmHastaGiris : Form
    {
        public FrmHastaGiris()
        {
            InitializeComponent();
        }


        // ekranın özelliklerinden  MaxsimizeBox özelliğğini False yaparak "Büyük Ekran" olmasını engelledik 
        //AutoSizeMode özelliğinide "Grow and Shrink" yaparak pencere ekraının büyütülmesini ve küçültülmesini engelledik 
        // AcceptButton özelliğini "btngiris" seçtiğimizde enter tuşuna basınca butonu çalıştıracaktır

        private void lnkuyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmHastaKayıt frmhastakayıt = new FrmHastaKayıt();
            frmhastakayıt.Show();   
        }
        //sql bagalnti sınıfını çagırıyoruz
        sqlbaglanti bgl = new sqlbaglanti();

        private void btngiris_Click(object sender, EventArgs e)
        {

            SqlCommand komut = new SqlCommand("Select * from Tbl_Hastalar where HastaTC = @1 and HastaSifre = @2",bgl.baglanti());

            komut.Parameters.AddWithValue("@1", msktc.Text);
            komut.Parameters.AddWithValue("@2",txtsifre.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                FrmHastaDetay frmHastaDetay = new FrmHastaDetay();

                frmHastaDetay.tc = msktc.Text;

                frmHastaDetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("HATALI KİMLİK NUMARASI YADA ŞİFRE HATASI", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            bgl.baglanti().Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txtsifre.UseSystemPasswordChar = false;
            }
            else
            {
                txtsifre.UseSystemPasswordChar = true;
            }
        }
    }
}
