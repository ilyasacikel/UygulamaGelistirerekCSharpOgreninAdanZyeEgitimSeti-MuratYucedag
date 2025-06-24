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

namespace HastaneProjesi
{
    public partial class FrmDoktorBilgiDuzenle: Form
    {
        public FrmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string TCNo;

        SqlBaglantim bgl = new SqlBaglantim();
        private void btnBilgileriDuzenle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Doktorlar set DoktorAd=@p1, DoktorSoyad=@p2, DoktorBrans=@p3, DoktorSifre=@p4 Where DoktorTC=@p5", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", cmbBrans.Text);
            komut.Parameters.AddWithValue("@p4", txtSifre.Text);
            komut.Parameters.AddWithValue("@p5", mskTCNo.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgiler başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskTCNo.Text = TCNo;

            SqlCommand komut2 = new SqlCommand("Select BransAd From Tbl_Branslar", bgl.baglanti());
            SqlDataReader dataReader2 = komut2.ExecuteReader();
            while (dataReader2.Read())
            {
                cmbBrans.Items.Add(dataReader2[0].ToString());
            }
            bgl.baglanti().Close();

            SqlCommand komut = new SqlCommand("Select * From Tbl_Doktorlar Where DoktorTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mskTCNo.Text);
            SqlDataReader dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                txtAd.Text = dataReader[1].ToString();
                txtSoyad.Text = dataReader[2].ToString();
                cmbBrans.Text = dataReader[4].ToString();
                txtSifre.Text = dataReader[5].ToString();
            }
            bgl.baglanti().Close();
        }
    }
}
