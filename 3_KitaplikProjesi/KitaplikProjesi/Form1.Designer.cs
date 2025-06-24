namespace KitaplikProjesi
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKitapAd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKitapYazar = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKitapSayfa = new System.Windows.Forms.TextBox();
            this.rdbKullanilmis = new System.Windows.Forms.RadioButton();
            this.rdbSifir = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbKitapTur = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKitapId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKitapAra = new System.Windows.Forms.TextBox();
            this.btnBul = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı:";
            // 
            // txtKitapAd
            // 
            this.txtKitapAd.Location = new System.Drawing.Point(160, 77);
            this.txtKitapAd.Name = "txtKitapAd";
            this.txtKitapAd.Size = new System.Drawing.Size(199, 36);
            this.txtKitapAd.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kitap Yazar:";
            // 
            // txtKitapYazar
            // 
            this.txtKitapYazar.Location = new System.Drawing.Point(160, 128);
            this.txtKitapYazar.Name = "txtKitapYazar";
            this.txtKitapYazar.Size = new System.Drawing.Size(199, 36);
            this.txtKitapYazar.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Kitap Sayfa:";
            // 
            // txtKitapSayfa
            // 
            this.txtKitapSayfa.Location = new System.Drawing.Point(160, 179);
            this.txtKitapSayfa.Name = "txtKitapSayfa";
            this.txtKitapSayfa.Size = new System.Drawing.Size(199, 36);
            this.txtKitapSayfa.TabIndex = 1;
            // 
            // rdbKullanilmis
            // 
            this.rdbKullanilmis.AutoSize = true;
            this.rdbKullanilmis.Location = new System.Drawing.Point(236, 282);
            this.rdbKullanilmis.Name = "rdbKullanilmis";
            this.rdbKullanilmis.Size = new System.Drawing.Size(132, 32);
            this.rdbKullanilmis.TabIndex = 2;
            this.rdbKullanilmis.TabStop = true;
            this.rdbKullanilmis.Text = "Kullanılmış";
            this.rdbKullanilmis.UseVisualStyleBackColor = true;
            this.rdbKullanilmis.CheckedChanged += new System.EventHandler(this.rdbKullanilmis_CheckedChanged);
            // 
            // rdbSifir
            // 
            this.rdbSifir.AutoSize = true;
            this.rdbSifir.Location = new System.Drawing.Point(161, 281);
            this.rdbSifir.Name = "rdbSifir";
            this.rdbSifir.Size = new System.Drawing.Size(69, 32);
            this.rdbSifir.TabIndex = 2;
            this.rdbSifir.TabStop = true;
            this.rdbSifir.Text = "Sıfır";
            this.rdbSifir.UseVisualStyleBackColor = true;
            this.rdbSifir.CheckedChanged += new System.EventHandler(this.rdbSifir_CheckedChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(387, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(730, 442);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // cmbKitapTur
            // 
            this.cmbKitapTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKitapTur.FormattingEnabled = true;
            this.cmbKitapTur.Location = new System.Drawing.Point(160, 230);
            this.cmbKitapTur.Name = "cmbKitapTur";
            this.cmbKitapTur.Size = new System.Drawing.Size(199, 36);
            this.cmbKitapTur.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 28);
            this.label4.TabIndex = 0;
            this.label4.Text = "Kitap Durum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(65, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 28);
            this.label5.TabIndex = 0;
            this.label5.Text = "Kitap Id:";
            // 
            // txtKitapId
            // 
            this.txtKitapId.Location = new System.Drawing.Point(160, 26);
            this.txtKitapId.Name = "txtKitapId";
            this.txtKitapId.ReadOnly = true;
            this.txtKitapId.Size = new System.Drawing.Size(199, 36);
            this.txtKitapId.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 28);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kitap Tür:";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(119, 319);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(117, 42);
            this.btnListele.TabIndex = 5;
            this.btnListele.Text = "Listele";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(241, 319);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(117, 42);
            this.btnKaydet.TabIndex = 5;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(120, 367);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(117, 42);
            this.btnSil.TabIndex = 5;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(241, 367);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(117, 42);
            this.btnGuncelle.TabIndex = 5;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 435);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 28);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kitap Ara:";
            // 
            // txtKitapAra
            // 
            this.txtKitapAra.Location = new System.Drawing.Point(111, 432);
            this.txtKitapAra.Name = "txtKitapAra";
            this.txtKitapAra.Size = new System.Drawing.Size(199, 36);
            this.txtKitapAra.TabIndex = 1;
            // 
            // btnBul
            // 
            this.btnBul.Location = new System.Drawing.Point(315, 428);
            this.btnBul.Name = "btnBul";
            this.btnBul.Size = new System.Drawing.Size(67, 42);
            this.btnBul.TabIndex = 5;
            this.btnBul.Text = "Bul";
            this.btnBul.UseVisualStyleBackColor = true;
            this.btnBul.Click += new System.EventHandler(this.btnBul_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1129, 496);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnBul);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.cmbKitapTur);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rdbSifir);
            this.Controls.Add(this.rdbKullanilmis);
            this.Controls.Add(this.txtKitapSayfa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKitapYazar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKitapId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKitapAra);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKitapAd);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKitapAd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKitapYazar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKitapSayfa;
        private System.Windows.Forms.RadioButton rdbKullanilmis;
        private System.Windows.Forms.RadioButton rdbSifir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbKitapTur;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKitapId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKitapAra;
        private System.Windows.Forms.Button btnBul;
    }
}

