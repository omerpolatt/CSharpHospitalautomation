namespace Hastane_Proje
{
    partial class FrmSekreterDetay
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSekreterDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnolustur = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.btnkaydet = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.cmbdr = new System.Windows.Forms.ComboBox();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.msksaat = new System.Windows.Forms.MaskedTextBox();
            this.msktarih = new System.Windows.Forms.MaskedTextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnbranspaneli = new System.Windows.Forms.Button();
            this.btnrandevulistesi = new System.Windows.Forms.Button();
            this.btndoktorpaneli = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbladsoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbltc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(29, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SEKRTER BİLGİ";
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.Location = new System.Drawing.Point(225, 85);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(100, 22);
            this.lbladsoyad.TabIndex = 9;
            this.lbladsoyad.Text = "NULL NULL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 10;
            this.label3.Text = "AD SOYAD :";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(225, 45);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(109, 22);
            this.lbltc.TabIndex = 8;
            this.lbltc.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "TC KİMLİK NUMARASI : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnolustur);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(29, 191);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 270);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DUYURU OLUŞTUR";
            // 
            // btnolustur
            // 
            this.btnolustur.Location = new System.Drawing.Point(95, 207);
            this.btnolustur.Name = "btnolustur";
            this.btnolustur.Size = new System.Drawing.Size(137, 31);
            this.btnolustur.TabIndex = 1;
            this.btnolustur.Text = "OLUŞTUR";
            this.btnolustur.UseVisualStyleBackColor = true;
            this.btnolustur.Click += new System.EventHandler(this.btnolustur_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(15, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(319, 163);
            this.richTextBox1.TabIndex = 77;
            this.richTextBox1.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnguncelle);
            this.groupBox3.Controls.Add(this.btnkaydet);
            this.groupBox3.Controls.Add(this.checkBox1);
            this.groupBox3.Controls.Add(this.msktc);
            this.groupBox3.Controls.Add(this.cmbdr);
            this.groupBox3.Controls.Add(this.cmbBrans);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.msksaat);
            this.groupBox3.Controls.Add(this.msktarih);
            this.groupBox3.Controls.Add(this.txtid);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(404, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 435);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RANDEVU PANELİ ";
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(117, 320);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(142, 32);
            this.btnguncelle.TabIndex = 3;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            // 
            // btnkaydet
            // 
            this.btnkaydet.Location = new System.Drawing.Point(117, 282);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(142, 32);
            this.btnkaydet.TabIndex = 2;
            this.btnkaydet.Text = "KAYDET ";
            this.btnkaydet.UseVisualStyleBackColor = true;
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(128, 250);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(98, 26);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "DURUM ";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(117, 205);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(142, 29);
            this.msktc.TabIndex = 7;
            this.msktc.ValidatingType = typeof(int);
            // 
            // cmbdr
            // 
            this.cmbdr.FormattingEnabled = true;
            this.cmbdr.Location = new System.Drawing.Point(117, 169);
            this.cmbdr.Name = "cmbdr";
            this.cmbdr.Size = new System.Drawing.Size(142, 30);
            this.cmbdr.TabIndex = 6;
            // 
            // cmbBrans
            // 
            this.cmbBrans.FormattingEnabled = true;
            this.cmbBrans.Items.AddRange(new object[] {
            "Acil Servis Kliniği",
            "Ağız ve Diş Sağlığı",
            "Beyin ve Sinir Cerrahisi",
            "Check-Up",
            "Çocuk Sağlığı ve Hastalıkları",
            "Damar Cerrahisi ve Varis Tedavisi",
            "Dermatoloji",
            "Enfeksiyon Hastalıkları ve Klinik Mikrobiyoloji",
            "Fizik Tedavi ve Rehabilitasyon",
            "Genel Cerrahi",
            "Genel Yoğun Bakım",
            "Göğüs Cerrahisi",
            "Göğüs Hastalıkları",
            "Göz Hastalıkları",
            "Hematoloji",
            "İç Hastalıkları",
            "Kadın Hastalıkları ve Doğum",
            "Kalp ve Damar Cerrahisi",
            "Kök Hücre",
            "Kulak-Burun-Boğaz Hastalıkları",
            "Nefroloji",
            "Nöroloji",
            "Organ Nakli",
            "Ortopedi ve Travmatoloji",
            "Psikiyatri",
            "Psikoloji",
            "Radyoloji",
            "Tüp Bebek (IVF)",
            "Üroloji",
            "Yeni Doğan Yoğun Bakım"});
            this.cmbBrans.Location = new System.Drawing.Point(117, 133);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(142, 30);
            this.cmbBrans.TabIndex = 5;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(39, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 22);
            this.label9.TabIndex = 4;
            this.label9.Text = "SAAT :";
            // 
            // msksaat
            // 
            this.msksaat.Location = new System.Drawing.Point(117, 98);
            this.msksaat.Mask = "90:00";
            this.msksaat.Name = "msksaat";
            this.msksaat.Size = new System.Drawing.Size(142, 29);
            this.msksaat.TabIndex = 4;
            this.msksaat.ValidatingType = typeof(System.DateTime);
            // 
            // msktarih
            // 
            this.msktarih.Location = new System.Drawing.Point(117, 63);
            this.msktarih.Mask = "00/00/0000";
            this.msktarih.Name = "msktarih";
            this.msktarih.Size = new System.Drawing.Size(142, 29);
            this.msktarih.TabIndex = 3;
            this.msktarih.ValidatingType = typeof(System.DateTime);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(117, 28);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(142, 29);
            this.txtid.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 22);
            this.label7.TabIndex = 1;
            this.label7.Text = "TC :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 22);
            this.label6.TabIndex = 0;
            this.label6.Text = "DOKTOR : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "BRANŞ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "TARİH :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "İD :";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(710, 33);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(603, 269);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "BRANŞLAR";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(597, 241);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dataGridView2);
            this.groupBox5.Location = new System.Drawing.Point(713, 308);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(597, 284);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "DOKTORLAR";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(591, 256);
            this.dataGridView2.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnbranspaneli);
            this.groupBox6.Controls.Add(this.btnrandevulistesi);
            this.groupBox6.Controls.Add(this.btndoktorpaneli);
            this.groupBox6.Location = new System.Drawing.Point(29, 478);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(664, 114);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "HIZLI ERİŞİMLER ";
            // 
            // btnbranspaneli
            // 
            this.btnbranspaneli.Location = new System.Drawing.Point(229, 42);
            this.btnbranspaneli.Name = "btnbranspaneli";
            this.btnbranspaneli.Size = new System.Drawing.Size(202, 41);
            this.btnbranspaneli.TabIndex = 5;
            this.btnbranspaneli.Text = "BRANŞ PANELİ ";
            this.btnbranspaneli.UseVisualStyleBackColor = true;
            // 
            // btnrandevulistesi
            // 
            this.btnrandevulistesi.Location = new System.Drawing.Point(443, 42);
            this.btnrandevulistesi.Name = "btnrandevulistesi";
            this.btnrandevulistesi.Size = new System.Drawing.Size(197, 41);
            this.btnrandevulistesi.TabIndex = 6;
            this.btnrandevulistesi.Text = "RANDEVU LİSTESİ";
            this.btnrandevulistesi.UseVisualStyleBackColor = true;
            // 
            // btndoktorpaneli
            // 
            this.btndoktorpaneli.Location = new System.Drawing.Point(17, 42);
            this.btndoktorpaneli.Name = "btndoktorpaneli";
            this.btndoktorpaneli.Size = new System.Drawing.Size(202, 41);
            this.btndoktorpaneli.TabIndex = 4;
            this.btndoktorpaneli.Text = "DOKTOR PANELİ ";
            this.btndoktorpaneli.UseVisualStyleBackColor = true;
            this.btndoktorpaneli.Click += new System.EventHandler(this.btndoktorpaneli_Click);
            // 
            // FrmSekreterDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1389, 707);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmSekreterDetay";
            this.Text = "SEKRETER DETAY ";
            this.Load += new System.EventHandler(this.FrmSekreterDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnolustur;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox msksaat;
        private System.Windows.Forms.MaskedTextBox msktarih;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Button btnkaydet;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.ComboBox cmbdr;
        private System.Windows.Forms.Button btnguncelle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnbranspaneli;
        private System.Windows.Forms.Button btnrandevulistesi;
        private System.Windows.Forms.Button btndoktorpaneli;
    }
}