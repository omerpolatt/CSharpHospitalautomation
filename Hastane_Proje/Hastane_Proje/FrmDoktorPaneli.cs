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
    public partial class FrmDoktorPaneli : Form
    {
        public FrmDoktorPaneli()
        {
            InitializeComponent();
        }

        sqlbaglanti bgl = new sqlbaglanti();

        private void FrmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();

            SqlDataAdapter da1 = new SqlDataAdapter("Select * from Tbl_Doktorlar", bgl.baglanti());

            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Insert into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) Values (@1,@2,@3,@4,@5)", bgl.baglanti());
            komut1.Parameters.AddWithValue("@1", txtad.Text);
            komut1.Parameters.AddWithValue("@2", txtsoyad.Text);
            komut1.Parameters.AddWithValue("@3", cmbBrans.Text);
            komut1.Parameters.AddWithValue("@4", msktc.Text);
            komut1.Parameters.AddWithValue("@5", txtsifre.Text);

            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi","BİLGİ",MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Doktor Paneli alanındaki datagridviewde tıklanaan doktor bilgilerini stırlara atayan kodlarımız 
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            msktc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtsifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            SqlCommand komuts = new SqlCommand("Delete from Tbl_Doktorlar where DoktorTC = @1",bgl.baglanti());
            komuts.Parameters.AddWithValue("@1",msktc.Text);

            komuts.ExecuteNonQuery();
            bgl.baglanti() .Close();
            MessageBox.Show("Kayıt Silindi", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutg = new SqlCommand("Update  Tbl_Doktorlar set DoktorAd=@1 ,DoktorSoyad =@2,DoktorBrans =@3 ,DoktorSifre =@5 where DoktorTC =@4", bgl.baglanti());

            komutg.Parameters.AddWithValue("@1", txtad.Text);
            komutg.Parameters.AddWithValue("@2", txtsoyad.Text);
            komutg.Parameters.AddWithValue("@3", cmbBrans.Text);
            komutg.Parameters.AddWithValue("@4", msktc.Text);
            komutg.Parameters.AddWithValue("@5", txtsifre.Text);

            komutg.ExecuteNonQuery ();
            bgl.baglanti().Close();
            MessageBox.Show("GÜNCELLEME YAPILDI", "GÜNCELLEME", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
