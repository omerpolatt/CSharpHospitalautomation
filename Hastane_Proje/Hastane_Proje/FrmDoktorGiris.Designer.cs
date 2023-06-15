namespace Hastane_Proje
{
    partial class FrmDoktorGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDoktorGiris));
            this.btngiris = new System.Windows.Forms.Button();
            this.txtsifre = new System.Windows.Forms.TextBox();
            this.msktc = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btngiris
            // 
            this.btngiris.BackColor = System.Drawing.Color.Lime;
            this.btngiris.ForeColor = System.Drawing.Color.Black;
            this.btngiris.Location = new System.Drawing.Point(362, 242);
            this.btngiris.Name = "btngiris";
            this.btngiris.Size = new System.Drawing.Size(147, 40);
            this.btngiris.TabIndex = 12;
            this.btngiris.Text = "GİRİŞ YAP ";
            this.btngiris.UseVisualStyleBackColor = false;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(337, 193);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(210, 29);
            this.txtsifre.TabIndex = 11;
            // 
            // msktc
            // 
            this.msktc.Location = new System.Drawing.Point(337, 140);
            this.msktc.Mask = "00000000000";
            this.msktc.Name = "msktc";
            this.msktc.Size = new System.Drawing.Size(210, 29);
            this.msktc.TabIndex = 10;
            this.msktc.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "ŞİFRE :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "TC KİMLİK NUMARASI : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Goudy Old Style", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(82, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 43);
            this.label1.TabIndex = 7;
            this.label1.Text = "DOKTOR GİRİŞ PANELİ ";
            // 
            // FrmDoktorGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(625, 322);
            this.Controls.Add(this.btngiris);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.msktc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Corbel", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmDoktorGiris";
            this.Text = "DOKTOR GİRİŞ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btngiris;
        private System.Windows.Forms.TextBox txtsifre;
        private System.Windows.Forms.MaskedTextBox msktc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}