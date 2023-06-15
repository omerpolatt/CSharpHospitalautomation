namespace Hastane_Proje
{
    partial class FrmHastaDetay
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaDetay));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbladsoyad = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lnkbilgiduzenle = new System.Windows.Forms.LinkLabel();
            this.btnrandevual = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.rtbsikayet = new System.Windows.Forms.RichTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbdr = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbbrans = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.txtid = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbladsoyad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbltc);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(376, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KİŞİ BİLGİ";
            // 
            // lbladsoyad
            // 
            this.lbladsoyad.AutoSize = true;
            this.lbladsoyad.Location = new System.Drawing.Point(139, 89);
            this.lbladsoyad.Name = "lbladsoyad";
            this.lbladsoyad.Size = new System.Drawing.Size(100, 22);
            this.lbladsoyad.TabIndex = 2;
            this.lbladsoyad.Text = "NULL NULL";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "AD SOYAD :";
            // 
            // lbltc
            // 
            this.lbltc.AutoSize = true;
            this.lbltc.Location = new System.Drawing.Point(218, 49);
            this.lbltc.Name = "lbltc";
            this.lbltc.Size = new System.Drawing.Size(109, 22);
            this.lbltc.TabIndex = 1;
            this.lbltc.Text = "00000000000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC KİMLİK NUMARASI : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtid);
            this.groupBox2.Controls.Add(this.lnkbilgiduzenle);
            this.groupBox2.Controls.Add(this.btnrandevual);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rtbsikayet);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cmbdr);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbbrans);
            this.groupBox2.Location = new System.Drawing.Point(21, 165);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(376, 347);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RANDEVU";
            // 
            // lnkbilgiduzenle
            // 
            this.lnkbilgiduzenle.AutoSize = true;
            this.lnkbilgiduzenle.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkbilgiduzenle.LinkColor = System.Drawing.Color.Red;
            this.lnkbilgiduzenle.Location = new System.Drawing.Point(179, 304);
            this.lnkbilgiduzenle.Name = "lnkbilgiduzenle";
            this.lnkbilgiduzenle.Size = new System.Drawing.Size(135, 22);
            this.lnkbilgiduzenle.TabIndex = 1;
            this.lnkbilgiduzenle.TabStop = true;
            this.lnkbilgiduzenle.Text = "Bilgileri Düzenle";
            this.lnkbilgiduzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkbilgiduzenle_LinkClicked);
            // 
            // btnrandevual
            // 
            this.btnrandevual.BackColor = System.Drawing.Color.Lime;
            this.btnrandevual.ForeColor = System.Drawing.Color.Black;
            this.btnrandevual.Location = new System.Drawing.Point(169, 252);
            this.btnrandevual.Name = "btnrandevual";
            this.btnrandevual.Size = new System.Drawing.Size(148, 35);
            this.btnrandevual.TabIndex = 5;
            this.btnrandevual.Text = "RANDEVU AL";
            this.btnrandevual.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "ŞİKAYET :";
            // 
            // rtbsikayet
            // 
            this.rtbsikayet.Location = new System.Drawing.Point(139, 162);
            this.rtbsikayet.Name = "rtbsikayet";
            this.rtbsikayet.Size = new System.Drawing.Size(218, 75);
            this.rtbsikayet.TabIndex = 3;
            this.rtbsikayet.Text = "";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 22);
            this.label6.TabIndex = 4;
            this.label6.Text = "DOKTOR :";
            // 
            // cmbdr
            // 
            this.cmbdr.FormattingEnabled = true;
            this.cmbdr.Location = new System.Drawing.Point(139, 120);
            this.cmbdr.Name = "cmbdr";
            this.cmbdr.Size = new System.Drawing.Size(218, 30);
            this.cmbdr.TabIndex = 2;
            this.cmbdr.SelectedIndexChanged += new System.EventHandler(this.cmbdr_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "RANDEVU İD :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "BRANŞ :";
            // 
            // cmbbrans
            // 
            this.cmbbrans.FormattingEnabled = true;
            this.cmbbrans.Location = new System.Drawing.Point(139, 76);
            this.cmbbrans.Name = "cmbbrans";
            this.cmbbrans.Size = new System.Drawing.Size(218, 30);
            this.cmbbrans.TabIndex = 2;
            this.cmbbrans.SelectedIndexChanged += new System.EventHandler(this.cmbbrans_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Location = new System.Drawing.Point(423, 21);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(765, 235);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RANDEVU GEÇMİŞİ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(759, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView2);
            this.groupBox4.Location = new System.Drawing.Point(426, 276);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(765, 235);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "AKTİF RANDEVULAR";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(759, 207);
            this.dataGridView2.TabIndex = 0;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(183, 38);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(174, 29);
            this.txtid.TabIndex = 6;
            // 
            // FrmHastaDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(1236, 577);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmHastaDetay";
            this.Text = "HASTA DETAY";
            this.Load += new System.EventHandler(this.FrmHastaDetay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbladsoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbdr;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbbrans;
        private System.Windows.Forms.RichTextBox rtbsikayet;
        private System.Windows.Forms.Button btnrandevual;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.LinkLabel lnkbilgiduzenle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid;
    }
}