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

namespace Personel
{
    public partial class FrmAnaForm: Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GAARB72\\SQLEXPRESS;Initial Catalog=Personel;Integrated Security=True;");

        void temizle()
        {
            txtAd.Text = "";
            txtMeslek.Text = "";
            txtPersonelId.Text = "";
            txtSoyad.Text = "";
            cmbSehir.Text = "";
            mskMaas.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            txtAd.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'personelDataSet.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter.Fill(this.personelDataSet.Tbl_Personel);

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("insert into Tbl_Personel (perAd,perSoyad,perSehir,perMaas,perMeslek,perMedeniDurum) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbSehir.Text);
            komut.Parameters.AddWithValue("@p4", mskMaas.Text);
            komut.Parameters.AddWithValue("@p5", txtMeslek.Text);
            bool medeniHal = false;
            if (radioButton1.Checked) medeniHal = true;
            komut.Parameters.AddWithValue("@p6", medeniHal.ToString());
            komut.ExecuteNonQuery();

            baglanti.Close();

            MessageBox.Show("Personel eklendi.");
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter.Fill(this.personelDataSet.Tbl_Personel);
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            txtPersonelId.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbSehir.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskMaas.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();

            bool medeniDurum = Convert.ToBoolean(dataGridView1.Rows[secilen].Cells[5].Value.ToString());
            if (medeniDurum) radioButton1.Checked = true;
            else radioButton2.Checked = true;

            txtMeslek.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Delete From Tbl_Personel Where PerId=@p1",baglanti);
            komut.Parameters.AddWithValue("@p1", txtPersonelId.Text);
            komut.ExecuteNonQuery();

            baglanti.Close();
            MessageBox.Show("Kayıt silindi.");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut = new SqlCommand("Update Tbl_Personel Set PerAd=@p1, PerSoyad=@p2, PerSehir=@p3, PerMaas=@p4, PerMedeniDurum=@p5, PerMeslek=@p6 Where PerId=@p7", baglanti);
            komut.Parameters.AddWithValue("@p7", txtPersonelId.Text);
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbSehir.Text);
            komut.Parameters.AddWithValue("@p4", mskMaas.Text);
            bool medeniHal = false;
            if (radioButton1.Checked) medeniHal = true;
            komut.Parameters.AddWithValue("@p5", medeniHal);
            komut.Parameters.AddWithValue("@p6", txtMeslek.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Güncelleme yapıldı");
        }

        private void btnIstatistik_Click(object sender, EventArgs e)
        {
            FrmIstatistik frm = new FrmIstatistik();
            frm.Show();
        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler frm = new FrmGrafikler();
            frm.Show();
        }
    }
}
