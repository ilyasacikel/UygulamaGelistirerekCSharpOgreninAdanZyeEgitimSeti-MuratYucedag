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
    public partial class FrmSekreterDetay: Form
    {
        public FrmSekreterDetay()
        {
            InitializeComponent();
        }

        public string TCNo;
        //string RandevuId;
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTCNo.Text = TCNo;

            // Ad Soyad
            SqlCommand komut = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreterler Where SekreterTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblTCNo.Text);
            SqlDataReader dataReader = komut.ExecuteReader();

            while (dataReader.Read())
            {
                lblAdSoyad.Text = dataReader[0].ToString();
            }

            bgl.baglanti().Close();

            // Branşları dataGrid'e ekleme
            DataTable dataTable1 = new DataTable();
            SqlDataAdapter dataApadter1 = new SqlDataAdapter("Select * From Tbl_Branslar", bgl.baglanti());
            dataApadter1.Fill(dataTable1);
            dataGridView1.DataSource = dataTable1;
            bgl.baglanti().Close();

            // Doktorları dataGrid'e ekleme
            DataTable dataTable2 = new DataTable();
            SqlDataAdapter dataAdapter2 = new SqlDataAdapter("Select (DoktorAd+' '+DoktorSoyad) as 'DoktorAdSoyad', DoktorBrans From Tbl_Doktorlar", bgl.baglanti());
            dataAdapter2.Fill(dataTable2);
            dataGridView2.DataSource = dataTable2;
            bgl.baglanti().Close();

            // Branşları comboBox'a ekleme
            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dataReader2 = komut2.ExecuteReader();
            while (dataReader2.Read())
            {
                cmbBrans.Items.Add(dataReader2[0]);
            }
            bgl.baglanti().Close();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@p1,@p2,@p3,@p4)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTarih.Text);
            komut.Parameters.AddWithValue("@p2", mskSaat.Text);
            komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@p4", cmbDoktor.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Items.Clear();
            SqlCommand komut = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorBrans=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbBrans.Text);
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                cmbDoktor.Items.Add(dataReader[0]+" "+ dataReader[1]);
            }
            bgl.baglanti().Close();
        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into Tbl_Duyurular (DuyuruAciklama) values (@p1)", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", rchDuyuru.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru oluşturuldu.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDoktorPanel_Click(object sender, EventArgs e)
        {
            FrmDoktorPaneli frm = new FrmDoktorPaneli();
            frm.Show();
        }

        private void btnBransPanel_Click(object sender, EventArgs e)
        {
            FrmBrans frm = new FrmBrans();
            frm.Show();
        }

        private void btnRandevuListe_Click(object sender, EventArgs e)
        {
            FrmRandevuListesi frm = new FrmRandevuListesi();
            frm.ShowDialog();

            if (frm.RandevuId != null)
            {
                txtId.Text = frm.RandevuId;
                SqlCommand komut = new SqlCommand("Select * From Tbl_Randevular Where RandevuId=@p1", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", frm.RandevuId);
                SqlDataReader dataReader = komut.ExecuteReader();
                while (dataReader.Read())
                {
                    mskTarih.Text = dataReader[1].ToString();
                    mskSaat.Text = dataReader[2].ToString();
                    cmbBrans.Text = dataReader[3].ToString();
                    cmbDoktor.Text = dataReader[4].ToString();
                    chkDurum.Checked = Convert.ToBoolean(dataReader[5].ToString());
                    mskTC.Text = dataReader[6].ToString();
                }
                bgl.baglanti().Close();
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Randevular set RandevuTarih=@p1,RandevuSaat=@p2,RandevuBrans=@p3,RandevuDoktor=@p4, RandevuDurum=@p5, HastaTc=@p6 Where RandevuId=@p7", bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", mskTarih.Text);
            komut.Parameters.AddWithValue("@p2", mskSaat.Text);
            komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@p4", cmbDoktor.Text);
            komut.Parameters.AddWithValue("@p5", (chkDurum.Checked == true) ? "true" : "false");
            komut.Parameters.AddWithValue("@p6", mskTC.Text);
            komut.Parameters.AddWithValue("@p7", txtId.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
