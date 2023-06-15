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
    public partial class FrmSekreterGiris : Form
    {
        public FrmSekreterGiris()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();    

        private void FrmSekreterGiris_Load(object sender, EventArgs e)
        {

        }

        private void btngiris_Click(object sender, EventArgs e)
        {

            SqlCommand komut1 = new SqlCommand("Select * From Tbl_Sekreter where SekreterTC = @1 and SekreterSifre = @2",bgl.baglanti());

            komut1.Parameters.AddWithValue("@1", msktcno.Text);
            komut1.Parameters.AddWithValue("@2", txtsifre.Text);

            SqlDataReader dr1 = komut1.ExecuteReader();  

            if(dr1.Read())
            {

                FrmSekreterDetay frmsekreterdetay = new FrmSekreterDetay();

                frmsekreterdetay.tc = msktcno.Text;

                frmsekreterdetay.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("HATALI KİMLİK NUMARASI YADA ŞİFRE GİRİŞİ ","UYARI",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            bgl.baglanti().Close();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
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
