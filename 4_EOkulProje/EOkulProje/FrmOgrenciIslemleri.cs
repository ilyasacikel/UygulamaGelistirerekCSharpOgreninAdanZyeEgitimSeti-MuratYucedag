using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOkulProje
{
    public partial class FrmOgrenciIslemleri: Form
    {
        public FrmOgrenciIslemleri()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GAARB72\\SQLEXPRESS;Initial Catalog=EOkulProje;Integrated Security=True;");

        DataSet1TableAdapters.DataTable1TableAdapter ds = new DataSet1TableAdapters.DataTable1TableAdapter();
        private void listele()
        {
            dataGridView1.DataSource = ds.OgrenciListele();
        }
        private void FrmOgrenciIslemleri_Load(object sender, EventArgs e)
        {
            listele();

            #region Klasik Yöntem
            /*baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From TBLKULUPLER ", baglanti);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            cmbOgrenciKulubu.DisplayMember = "KULUPAD";
            cmbOgrenciKulubu.ValueMember = "KULUPID";
            cmbOgrenciKulubu.DataSource = dataTable;
            baglanti.Close();*/
            #endregion

            cmbOgrenciKulubu.DataSource = ds.KulupleriListele();
            cmbOgrenciKulubu.DisplayMember = "KULUPAD";
            cmbOgrenciKulubu.ValueMember = "KULUPID";

        }

        private string cinsiyet = "";
        private void btnEkle_Click(object sender, EventArgs e)
        {
           
            if (rdbErkek.Checked) cinsiyet = rdbErkek.Text.ToUpper();
            if (rdbKiz.Checked) cinsiyet = rdbKiz.Text.ToUpper();
            ds.OgrenciEkle(txtOgrenciAd.Text, txtOgrenciSoyad.Text, cinsiyet, byte.Parse(cmbOgrenciKulubu.SelectedValue.ToString()));
            MessageBox.Show("Yeni öğrenci başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void cmbOgrenciKulubu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txtOgrenciId.Text = cmbOgrenciKulubu.SelectedIndex.ToString(); // indek i verir
            //txtOgrenciId.Text = cmbOgrenciKulubu.SelectedValue.ToString();  // seçili seçeneğin arkasındaki değeri verir.
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (rdbErkek.Checked) cinsiyet = rdbErkek.Text.ToUpper();
            if (rdbKiz.Checked) cinsiyet = rdbKiz.Text.ToUpper();
            ds.OgrenciGuncelle(txtOgrenciAd.Text, txtOgrenciSoyad.Text, cinsiyet, byte.Parse(cmbOgrenciKulubu.SelectedValue.ToString()), int.Parse(txtOgrenciId.Text));
            MessageBox.Show("Öğrenci başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            ds.OgrenciSil(int.Parse(txtOgrenciId.Text));
            MessageBox.Show("Öğrenci başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            listele();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtOgrenciId.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtOgrenciAd.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtOgrenciSoyad.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cinsiyet = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (cinsiyet == "ERKEK") rdbErkek.Checked = true;
            if (cinsiyet == "KIZ") rdbKiz.Checked = true;
            cmbOgrenciKulubu.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ds.OgrenciGetir(txtOgrenciArama.Text);
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            listele();
        }
    }
}
