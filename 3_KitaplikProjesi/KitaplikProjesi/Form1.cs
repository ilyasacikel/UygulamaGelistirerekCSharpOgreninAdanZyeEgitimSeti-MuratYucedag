using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace KitaplikProjesi
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Ilyas\Documents\Kitaplik.accdb");

        void listele()
        {
            DataTable dataTable = new DataTable();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter("Select * From Kitaplar", baglanti);
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listele();

            // Kitap türleri
            string[] kitapTur = new string[] { "Roman", "Hikaye", "Araştırma", "Tiyatro", "Makale", "Şiir" };
            cmbKitapTur.Items.AddRange(kitapTur);
        }

        string durum = "";
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("insert into Kitaplar (KitapAd,KitapYazar,KitapTur,KitapSayfa,KitapDurum) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKitapAd.Text);
            komut.Parameters.AddWithValue("@p2", txtKitapYazar.Text);
            komut.Parameters.AddWithValue("@p3", cmbKitapTur.Text);
            komut.Parameters.AddWithValue("@p4", txtKitapSayfa.Text);
            komut.Parameters.AddWithValue("@p5", durum);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Yeni kitap başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void rdbSifir_CheckedChanged(object sender, EventArgs e)
        {
            durum = "1";
        }

        private void rdbKullanilmis_CheckedChanged(object sender, EventArgs e)
        {
            durum = "0";
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtKitapId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtKitapAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtKitapYazar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbKitapTur.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtKitapSayfa.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            bool durum = Convert.ToBoolean(dataGridView1.Rows[secilen].Cells[5].Value.ToString());
            if (durum == true) rdbSifir.Checked = true;
            else rdbKullanilmis.Checked = true;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Delete * From Kitaplar Where KitapId=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKitapId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap sistemden başarıyla kaldırıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Update Kitaplar Set KitapAd=@p1, KitapYazar=@p2, KitapSayfa=@p3, KitapTur=@p4, KitapDurum=@p5 Where KitapId=@p6", baglanti);
            komut.Parameters.AddWithValue("@p1", txtKitapAd.Text);
            komut.Parameters.AddWithValue("@p2", txtKitapYazar.Text);
            komut.Parameters.AddWithValue("@p3", txtKitapSayfa.Text);
            komut.Parameters.AddWithValue("@p4", cmbKitapTur.Text);
            komut.Parameters.AddWithValue("@p5", durum);
            komut.Parameters.AddWithValue("@p6", txtKitapId.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap bilgileri başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * From Kitaplar Where KitapAd like '%" + txtKitapAra.Text + "%'", baglanti);
            DataTable dataTable = new DataTable();
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(komut);
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglanti.Close();
        }
    }
}
