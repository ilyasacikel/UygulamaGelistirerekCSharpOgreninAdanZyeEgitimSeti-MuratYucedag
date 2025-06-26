using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbEntityUrunProje
{
    public partial class FrmKategoriIslemleri: Form
    {
        public FrmKategoriIslemleri()
        {
            InitializeComponent();
        }

        DbEntityUrunProjeEntities db = new DbEntityUrunProjeEntities();
        private void btnListele_Click(object sender, EventArgs e)
        {
            var kategoriler = db.TBLKATEGORI.ToList();
            dataGridView1.DataSource = kategoriler;
            dataGridView1.Columns["TBLURUN"].Visible = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBLKATEGORI kategori = new TBLKATEGORI();
            kategori.AD = txtKategoriAd.Text;
            db.TBLKATEGORI.Add(kategori);
            db.SaveChanges();
            MessageBox.Show("Kategori başarıyla eklendi.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int silinecekKategoriId = Convert.ToInt32(txtKategoriId.Text);
            var silinecekKategori = db.TBLKATEGORI.Find(silinecekKategoriId);
            db.TBLKATEGORI.Remove(silinecekKategori);
            db.SaveChanges();
            MessageBox.Show("Kategori başarıyla silindi.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int guncellenecekKategoriId = Convert.ToInt32(txtKategoriId.Text);
            var guncellenecekKategori = db.TBLKATEGORI.Find(guncellenecekKategoriId);
            guncellenecekKategori.AD = txtKategoriAd.Text;
            db.SaveChanges();
            MessageBox.Show("Kategori başarıyla güncellendi.");
        }
    }
}
