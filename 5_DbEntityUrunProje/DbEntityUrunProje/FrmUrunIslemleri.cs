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
    public partial class FrmUrunIslemleri : Form
    {
        public FrmUrunIslemleri()
        {
            InitializeComponent();
        }

        DbEntityUrunProjeEntities db = new DbEntityUrunProjeEntities();
        private void btnListele_Click(object sender, EventArgs e)
        {
            //dataGridView1.DataSource = db.TBLURUN.ToList();
            dataGridView1.DataSource = (from x in db.TBLURUN
                                        select new
                                        {
                                            x.URUNID,
                                            x.URUNAD,
                                            x.MARKA,
                                            x.FIYAT,
                                            x.TBLKATEGORI.AD,
                                            x.STOK,
                                            DURUM = (x.DURUM ?? false) ? "Satışa Açık": "Satışa Kapalı" // ?? oparatörü Null-Caolescing oparetörütür. Burada x.DURUM eğer null ise false durumu çalışır. null değilse kendi değerini kullanır.
                                        }).ToList();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            TBLURUN yeniUrun = new TBLURUN();
            yeniUrun.URUNAD = txtUrunAd.Text;
            yeniUrun.MARKA = txtMarka.Text;
            yeniUrun.STOK = Convert.ToInt16(txtStok.Text);
            yeniUrun.DURUM = true;
            yeniUrun.KATEGORI = int.Parse(cmbKategori.SelectedValue.ToString());
            yeniUrun.FIYAT = decimal.Parse(txtFiyat.Text);
            db.TBLURUN.Add(yeniUrun);
            db.SaveChanges();
            MessageBox.Show("Yeni ürün başarıyla eklendi.");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int silinecekUrunId = int.Parse(txtUrunId.Text);
            var silinecekUrun = db.TBLURUN.Find(silinecekUrunId);
            db.TBLURUN.Remove(silinecekUrun);
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla silindi.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int guncellenecekUrunId = int.Parse(txtUrunId.Text);
            var guncellenecekUrun = db.TBLURUN.Find(guncellenecekUrunId);
            guncellenecekUrun.URUNAD = txtUrunAd.Text;
            guncellenecekUrun.MARKA = txtMarka.Text;
            guncellenecekUrun.FIYAT = decimal.Parse(txtFiyat.Text);
            guncellenecekUrun.STOK = short.Parse(txtStok.Text);
            guncellenecekUrun.KATEGORI = int.Parse(cmbKategori.SelectedValue.ToString());
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla güncellendi.");
        }

        private void FrmUrunIslemleri_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.TBLKATEGORI
                               select new
                               {
                                   x.ID,
                                   x.AD
                               }
                               ).ToList();
            cmbKategori.ValueMember = "ID";
            cmbKategori.DisplayMember = "AD";
            cmbKategori.DataSource = kategoriler;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
        }
    }
}
