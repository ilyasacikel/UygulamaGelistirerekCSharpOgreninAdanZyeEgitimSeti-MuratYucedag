using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccessLayer;
using LogicLayer;

namespace NKatmanliMimariPersonelProje
{
    public partial class FrmPersonel: Form
    {
        public FrmPersonel()
        {
            InitializeComponent();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> PerList = LogicPersonel.LLPersonelListesi();
            dataGridView1.DataSource = PerList;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EntityPersonel entity = new EntityPersonel();
            entity.Ad = txtAd.Text;
            entity.Soyad = txtSoyad.Text;
            entity.Maas = short.Parse(txtMaas.Text);
            entity.Gorev = txtGorev.Text;
            entity.Sehir = txtSehir.Text;
            LogicPersonel.LLPersonelEkle(entity);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            LogicPersonel.LLPersonelSil(int.Parse(txtID.Text));
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            EntityPersonel entity = new EntityPersonel();
            entity.Id = int.Parse(txtID.Text);
            entity.Ad = txtAd.Text;
            entity.Soyad = txtSoyad.Text;
            entity.Sehir = txtSehir.Text;
            entity.Gorev = txtGorev.Text;
            entity.Maas = short.Parse(txtMaas.Text);

            LogicPersonel.LLPersonelGuncelle(entity);
        }
    }
}
