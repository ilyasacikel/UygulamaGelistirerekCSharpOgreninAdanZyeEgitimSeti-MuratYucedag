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
    public partial class FrmIstatistik: Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        DbEntityUrunProjeEntities db = new DbEntityUrunProjeEntities();
        private void FrmIstatistik_Load(object sender, EventArgs e)
        {
            lblToplamKategori.Text = db.TBLKATEGORI.Count().ToString();
            lblToplamUrunSayisi.Text = db.TBLURUN.Count().ToString();
            lblAktifMusteriSayisi.Text = db.TBLMUSTERI.Count(x => x.DURUM == true).ToString();
            lblPasifMusteriSayisi.Text = db.TBLMUSTERI.Count(x => x.DURUM == false).ToString();
            lblToplamStok.Text = db.TBLURUN.Sum(x => x.STOK).ToString();
            lblKasadakiTutar.Text = "₺" + db.TBLSATIS.Sum(x => x.FIYAT).ToString();
            lblEnYuksekFiyatliUrun.Text = (from x in db.TBLURUN orderby x.FIYAT descending select x.URUNAD).FirstOrDefault();
            lblEnDusukFiyatliUrun.Text = (from x in db.TBLURUN orderby x.FIYAT ascending select x.URUNAD).FirstOrDefault();
            lblBeyazEsyaSayisi.Text = db.TBLURUN.Count(x => x.TBLKATEGORI.AD == "BEYAZ EŞYA").ToString();
            lblToplamBuzdolabiSayisi.Text = db.TBLURUN.Count(x => x.URUNAD == "BUZDOLABI").ToString();
            lblSehirSayisi.Text = (from x in db.TBLMUSTERI select x.SEHIR).Distinct().Count().ToString();


            // SELECT TOP 1 MARKA,COUNT(*) FROM TBLURUN GROUP BY MARKA ORDER BY COUNT(*) DESC ==> Bu sorgu mesela KARACA -> 2 şeklinde bir sonuç veriyor. Eğer sorgumuzu
            // SELECT TOP 1 MARKA FROM TBLURUN GROUP BY MARKA ORDER BY COUNT(*) DESC ==> şeklinde değiştirirsek sadece KARACA yazar.
            lblEnFazlaUrunluMarka.Text = db.MARKAGETIR().FirstOrDefault();


        }
    }
}
