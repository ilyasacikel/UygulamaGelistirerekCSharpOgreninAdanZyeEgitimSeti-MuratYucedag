using EOkulProje.DataSet1TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EOkulProje
{
    public partial class FrmSinavNotlar: Form
    {
        public FrmSinavNotlar()
        {
            InitializeComponent();
        }

        DataSet1TableAdapters.TBLNOTLARTableAdapter ds = new DataSet1TableAdapters.TBLNOTLARTableAdapter();

        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.NotListesi(int.Parse(txtOgrenciId.Text));
            
            dataGridView1.Columns["OGRENCIADSOYAD"].DisplayIndex = 1;
            dataGridView1.Columns["DERSAD"].DisplayIndex = 2;
            dataGridView1.Columns["YAZILI1"].DisplayIndex = 3;
            dataGridView1.Columns["YAZILI2"].DisplayIndex = 4;
            dataGridView1.Columns["YAZILI3"].DisplayIndex = 5;
            dataGridView1.Columns["PROJE"].DisplayIndex = 6;
            dataGridView1.Columns["ORTALAMA"].DisplayIndex = 7;
            dataGridView1.Columns["DURUM"].DisplayIndex = 8;
            dataGridView1.Columns["OGRID"].Visible = false;
            dataGridView1.Columns["NOTID"].Visible = false;
        }

        private void FrmSinavNotlar_Load(object sender, EventArgs e)
        {
            cmbDersler.DataSource = ds.DersleriListele();
            cmbDersler.DisplayMember = "DERSAD";
            cmbDersler.ValueMember = "DERSID";
        }

        int notId;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            notId = int.Parse(dataGridView1.Rows[secilen].Cells["NOTID"].Value.ToString());
            txtOgrenciId.Text = dataGridView1.Rows[secilen].Cells["OGRID"].Value.ToString();
            txtYazili1.Text = dataGridView1.Rows[secilen].Cells["YAZILI1"].Value.ToString();
            txtYazili2.Text = dataGridView1.Rows[secilen].Cells["YAZILI2"].Value.ToString();
            txtYazili3.Text = dataGridView1.Rows[secilen].Cells["YAZILI3"].Value.ToString();
            txtProje.Text = dataGridView1.Rows[secilen].Cells["PROJE"].Value.ToString();
            txtOrtalama.Text = dataGridView1.Rows[secilen].Cells["ORTALAMA"].Value.ToString();
            txtDurum.Text = dataGridView1.Rows[secilen].Cells["DURUM"].Value.ToString();
            cmbDersler.Text = dataGridView1.Rows[secilen].Cells["DERSAD"].Value.ToString();
        }

        int yazili1, yazili2, yazili3, proje;

        private void cmbDersler_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            txtOgrenciId.Text = "";
            txtDurum.Text = "";
            txtOrtalama.Text = "";
            txtProje.Text = "";
            txtYazili1.Text = "";
            txtYazili2.Text = "";
            txtYazili3.Text = "";
            cmbDersler.Text = null;
        }

        double ortalama;
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            yazili1 = Convert.ToInt32(txtYazili1.Text);
            yazili2 = Convert.ToInt32(txtYazili2.Text);
            yazili3 = Convert.ToInt32(txtYazili3.Text);
            proje = Convert.ToInt32(txtProje.Text);
            ortalama = (double) (yazili1 + yazili2 + yazili3 + proje) / 4;
            txtOrtalama.Text = ortalama.ToString();
            if (ortalama >= 50) txtDurum.Text = "True";
            else txtDurum.Text = "False";
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            ds.NotGuncelle(Convert.ToByte(cmbDersler.SelectedValue.ToString()), int.Parse(txtOgrenciId.Text), Convert.ToByte(yazili1), Convert.ToByte(yazili2), Convert.ToByte(yazili3), Convert.ToByte(proje), Convert.ToDecimal(ortalama), bool.Parse(txtDurum.Text), Convert.ToInt32(notId));
                MessageBox.Show("Başarıyla güncellendi.");
           
        }
    }
}
