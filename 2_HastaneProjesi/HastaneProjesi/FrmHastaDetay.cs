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

namespace HastaneProjesi
{
    public partial class FrmHastaDetay: Form
    {
        public FrmHastaDetay()
        {
            InitializeComponent();
        }

        public string TCNo;
        SqlBaglantim bgl = new SqlBaglantim();

        private void FrmHastaDetay_Load(object sender, EventArgs e)
        {
            lblTCNo.Text = TCNo;

            // Ad Soyad Çekme
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar Where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTCNo.Text);

            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                lblAdSoyad.Text = dataReader[0] + " " + dataReader[1];

            }

            bgl.baglanti().Close();

            // Randevu Geçmişi
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Tbl_Randevular Where HastaTC="+TCNo, bgl.baglanti());
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

            // Branşları Çekme

            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dataReader2 = komut2.ExecuteReader();
            while (dataReader2.Read())
            {
                cmbBrans.Items.Add(dataReader2[0]);
            }
            bgl.baglanti().Close();
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorBrans=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dataReader3 = komut3.ExecuteReader();

            while (dataReader3.Read())
            {
                cmbDoktor.Items.Add(dataReader3[0] + " " + dataReader3[1]);
            }

            bgl.baglanti().Close();

        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable2 = new DataTable();
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter("Select * From Tbl_Randevular Where RandevuBrans='" + cmbBrans.Text + "' and RandevuDoktor='"+ cmbDoktor.Text+"' and RandevuDurum=0", bgl.baglanti());
            dataAdapter2.Fill(dataTable2);
            dataGridView2.DataSource = dataTable2;
        }

        private void lnkBilgileriDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmBilgileriDuzenle frm = new FrmBilgileriDuzenle();
            frm.TCNo = TCNo;
            frm.Show();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Randevular set RandevuDurum=1, HastaTc=@p1, HastaSikayet=@p2 where RandevuId=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTCNo.Text);
            komut.Parameters.AddWithValue("@p2", rchSikayet.Text);
            komut.Parameters.AddWithValue("@p3", txtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu alındı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
