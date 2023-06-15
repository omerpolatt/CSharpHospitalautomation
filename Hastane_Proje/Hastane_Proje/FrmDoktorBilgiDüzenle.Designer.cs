namespace Hastane_Proje
{
    partial class FrmDoktorBilgiDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorBilgiDüzenle));
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbBrans = new System.Windows.Forms.ComboBox();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(244, 93);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(165, 29);
            this.txtsoyad.TabIndex = 29;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(244, 52);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(165, 29);
            this.txtad.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(184, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 22);
            this.label4.TabIndex = 27;
            this.label4.Text = "AD :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "SOYAD :";
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(244, 139);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(165, 29);
            this.msktc.TabIndex = 26;
            this.msktc.ValidatingType = typeof(int);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 22);
            this.label2.TabIndex = 25;
            this.label2.Text = "TC KİMLİK NUMARASI : ";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(244, 185);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(165, 29);
            this.txtsifre.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "ŞİFRE :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 33;
            this.label5.Text = "BRANŞ :";
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
            this.cmbBrans.Location = new System.Drawing.Point(244, 233);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Size = new System.Drawing.Size(165, 30);
            this.cmbBrans.TabIndex = 34;
            // 
            // btnguncelle
            // 
            this.btnguncelle.BackColor = System.Drawing.Color.Fuchsia;
            this.btnguncelle.Location = new System.Drawing.Point(255, 280);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(142, 38);
            this.btnguncelle.TabIndex = 35;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = false;
            // 
            // FrmDoktorBilgiDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(523, 381);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.cmbBrans);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDoktorBilgiDüzenle";
            this.Text = "FrmDoktorBilgiDüzenle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbBrans;
        private System.Windows.Forms.Button btnguncelle;
    }
}