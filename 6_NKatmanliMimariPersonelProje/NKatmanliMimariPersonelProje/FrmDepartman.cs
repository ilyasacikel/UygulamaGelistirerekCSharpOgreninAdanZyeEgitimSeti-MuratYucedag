using EntityLayer;
using LogicLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NKatmanliMimariPersonelProje
{
    public partial class FrmDepartman: Form
    {
        public FrmDepartman()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            var departmanlar = LogicDepartman.LLDepartmanListesi();
            dataGridView1.DataSource = departmanlar;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EntityDepartman entity = new EntityDepartman();
            entity.Ad = txtAd.Text;
            entity.Aciklama = rchAciklama.Text;
            if (!LogicDepartman.LLDepartmanEkle(entity))
            {
                MessageBox.Show("Bir hata oluştu.");
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            LogicDepartman.LLDepartmanSil(int.Parse(txtID.Text));
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            EntityDepartman entity = new EntityDepartman();
            entity.Id = int.Parse(txtID.Text);
            entity.Ad = txtAd.Text;
            entity.Aciklama = rchAciklama.Text;
            LogicDepartman.LLDepartmanGuncelle(entity);
        }
    }
}
