using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HastaneProjesi
{
    public partial class FrmDoktorDetay: Form
    {
        public FrmDoktorDetay()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        public string TCNo;
        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            FrmDuyurular frm = new FrmDuyurular();
            frm.Show();
        }

        private void FrmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblTCNo.Text = TCNo;

            // Doktor Ad Soyadını çekme
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTCNo.Text);
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                lblAdSoyad.Text = dataReader[0] + " " + dataReader[1];
            }
            bgl.baglanti().Close();

            // Randevular
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Tbl_Randevular Where RandevuDoktor='"+lblAdSoyad.Text+"'", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            bgl.baglanti().Close();
            

        }

        private void lnkBilgileriDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmDoktorBilgiDuzenle frm = new FrmDoktorBilgiDuzenle();
            frm.TCNo = lblTCNo.Text;
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }

        private void btnInternet_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.saglik.gov.tr/",
                UseShellExecute = true
            });
        }

        private void btnGoogleAramaYap_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.google.com/",
                UseShellExecute = true
            });
        }
    }
}
