namespace EOkulProje
{
    partial class FrmOgretmen
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
            this.btnDersIslemleri = new System.Windows.Forms.Button();
            this.btnKulupIslemleri = new System.Windows.Forms.Button();
            this.btnSinavNotlari = new System.Windows.Forms.Button();
            this.btnOgrenciIslemleri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDersIslemleri
            // 
            this.btnDersIslemleri.FlatAppearance.BorderSize = 2;
            this.btnDersIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDersIslemleri.Location = new System.Drawing.Point(54, 27);
            this.btnDersIslemleri.Name = "btnDersIslemleri";
            this.btnDersIslemleri.Size = new System.Drawing.Size(272, 60);
            this.btnDersIslemleri.TabIndex = 0;
            this.btnDersIslemleri.Text = "DERS İŞLEMLERİ";
            this.btnDersIslemleri.UseVisualStyleBackColor = true;
            this.btnDersIslemleri.Click += new System.EventHandler(this.btnDersIslemleri_Click);
            // 
            // btnKulupIslemleri
            // 
            this.btnKulupIslemleri.FlatAppearance.BorderSize = 2;
            this.btnKulupIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKulupIslemleri.Location = new System.Drawing.Point(54, 104);
            this.btnKulupIslemleri.Name = "btnKulupIslemleri";
            this.btnKulupIslemleri.Size = new System.Drawing.Size(272, 60);
            this.btnKulupIslemleri.TabIndex = 0;
            this.btnKulupIslemleri.Text = "KULÜP İŞLEMLERİ";
            this.btnKulupIslemleri.UseVisualStyleBackColor = true;
            this.btnKulupIslemleri.Click += new System.EventHandler(this.btnKulupIslemleri_Click);
            // 
            // btnSinavNotlari
            // 
            this.btnSinavNotlari.FlatAppearance.BorderSize = 2;
            this.btnSinavNotlari.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSinavNotlari.Location = new System.Drawing.Point(54, 181);
            this.btnSinavNotlari.Name = "btnSinavNotlari";
            this.btnSinavNotlari.Size = new System.Drawing.Size(272, 60);
            this.btnSinavNotlari.TabIndex = 0;
            this.btnSinavNotlari.Text = "SINAV NOTLARI";
            this.btnSinavNotlari.UseVisualStyleBackColor = true;
            this.btnSinavNotlari.Click += new System.EventHandler(this.btnSinavNotlari_Click);
            // 
            // btnOgrenciIslemleri
            // 
            this.btnOgrenciIslemleri.FlatAppearance.BorderSize = 2;
            this.btnOgrenciIslemleri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOgrenciIslemleri.Location = new System.Drawing.Point(54, 258);
            this.btnOgrenciIslemleri.Name = "btnOgrenciIslemleri";
            this.btnOgrenciIslemleri.Size = new System.Drawing.Size(272, 60);
            this.btnOgrenciIslemleri.TabIndex = 0;
            this.btnOgrenciIslemleri.Text = "ÖĞRENCİ İŞLEMLERİ";
            this.btnOgrenciIslemleri.UseVisualStyleBackColor = true;
            this.btnOgrenciIslemleri.Click += new System.EventHandler(this.btnOgrenciIslemleri_Click);
            // 
            // FrmOgretmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(370, 350);
            this.Controls.Add(this.btnOgrenciIslemleri);
            this.Controls.Add(this.btnSinavNotlari);
            this.Controls.Add(this.btnKulupIslemleri);
            this.Controls.Add(this.btnDersIslemleri);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmOgretmen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmOgretmen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDersIslemleri;
        private System.Windows.Forms.Button btnKulupIslemleri;
        private System.Windows.Forms.Button btnSinavNotlari;
        private System.Windows.Forms.Button btnOgrenciIslemleri;
    }
}