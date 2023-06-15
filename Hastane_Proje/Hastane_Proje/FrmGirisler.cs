using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hastane_Proje
{
    public partial class FrmGirisler : Form
    {
        public FrmGirisler()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // ekranın özelliklerinden  MaxsimizeBox özelliğğini False yaparak "Büyük Ekran" olmasını engelledik 
        //AutoSizeMode özelliğinide "Grow and Shrink" yaparak pencere ekraının büyütülmesini ve küçültülmesini engelledik 
        private void btnhastagiris_Click(object sender, EventArgs e)
        {
            FrmHastaGiris frmhastagiris = new FrmHastaGiris();
            frmhastagiris.Show();
            this.Hide();
        }

        private void btndrgiris_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris frmdoktorgiris = new FrmDoktorGiris();
            frmdoktorgiris.Show();  
            this.Hide();
        }

        private void btnsekretergiris_Click(object sender, EventArgs e)
        {
            FrmSekreterGiris frmsekretergiris = new FrmSekreterGiris();

           

            frmsekretergiris.Show();    
            this.Hide();
           
        }
    }
}
