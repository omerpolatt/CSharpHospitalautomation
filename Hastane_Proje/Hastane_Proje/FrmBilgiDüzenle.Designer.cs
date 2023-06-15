namespace Hastane_Proje
{
    partial class FrmBilgiDüzenle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBilgiDüzenle));
            this.cmbcinsiyet = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtsoyad = new System.Windows.Forms.TextBox();
            this.txtad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.msktel = new System.Windows.Forms.MaskedTextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnguncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbcinsiyet
            // 
            this.cmbcinsiyet.FormattingEnabled = true;
            this.cmbcinsiyet.Items.AddRange(new object[] {
            "ERKEK ",
            "KADIN"});
            this.cmbcinsiyet.Location = new System.Drawing.Point(274, 247);
            this.cmbcinsiyet.Name = "cmbcinsiyet";
            this.cmbcinsiyet.Size = new System.Drawing.Size(165, 30);
            this.cmbcinsiyet.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 247);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 25;
            this.label6.Text = "CİNSİYET :";
            // 
            // txtsoyad
            // 
            this.txtsoyad.Location = new System.Drawing.Point(274, 79);
            this.txtsoyad.Name = "txtsoyad";
            this.txtsoyad.Size = new System.Drawing.Size(165, 29);
            this.txtsoyad.TabIndex = 2;
            // 
            // txtad
            // 
            this.txtad.Location = new System.Drawing.Point(274, 38);
            this.txtad.Name = "txtad";
            this.txtad.Size = new System.Drawing.Size(165, 29);
            this.txtad.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 22);
            this.label5.TabIndex = 22;
            this.label5.Text = "TELEFON :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 22);
            this.label4.TabIndex = 20;
            this.label4.Text = "AD :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 22);
            this.label1.TabIndex = 21;
            this.label1.Text = "SOYAD :";
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(274, 207);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(165, 29);
            this.txtsifre.TabIndex = 5;
            // 
            // msktel
            // 
            this.msktel.Location = new System.Drawing.Point(274, 166);
            this.msktel.Mask = "(999) 000-0000";
            this.msktel.Name = "msktel";
            this.msktel.Size = new System.Drawing.Size(165, 29);
            this.msktel.TabIndex = 4;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(274, 125);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(165, 29);
            this.msktc.TabIndex = 3;
            this.msktc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 16;
            this.label3.Text = "ŞİFRE :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "TC KİMLİK NUMARASI : ";
            // 
            // btnguncelle
            // 
            this.btnguncelle.Location = new System.Drawing.Point(290, 283);
            this.btnguncelle.Name = "btnguncelle";
            this.btnguncelle.Size = new System.Drawing.Size(133, 32);
            this.btnguncelle.TabIndex = 26;
            this.btnguncelle.Text = "GÜNCELLE";
            this.btnguncelle.UseVisualStyleBackColor = true;
            this.btnguncelle.Click += new System.EventHandler(this.btnguncelle_Click);
            // 
            // FrmBilgiDüzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(593, 362);
            this.Controls.Add(this.btnguncelle);
            this.Controls.Add(this.cmbcinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtsoyad);
            this.Controls.Add(this.txtad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.msktel);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmBilgiDüzenle";
            this.Text = "BİLGİ DÜZENLE";
            this.Load += new System.EventHandler(this.FrmBilgiDüzenle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbcinsiyet;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtsoyad;
        private System.Windows.Forms.TextBox txtad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.MaskedTextBox msktel;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnguncelle;
    }
}