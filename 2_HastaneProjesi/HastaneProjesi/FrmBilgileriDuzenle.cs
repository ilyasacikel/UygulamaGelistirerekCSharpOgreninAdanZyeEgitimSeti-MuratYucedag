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
    public partial class FrmBilgileriDuzenle: Form
    {
        public FrmBilgileriDuzenle()
        {
            InitializeComponent();
        }

        public string TCNo;
        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmBilgileriDuzenle_Load(object sender, EventArgs e)
        {
            mskTCNo.Text = this.TCNo;

            cmbCinsiyet.Items.Add("Erkek");
            cmbCinsiyet.Items.Add("Kadın");

            SqlCommand komut = new SqlCommand("Select * From Tbl_Hastalar Where HastaTC=" + TCNo, bgl.baglanti());
            SqlDataReader dataReader = komut.ExecuteReader();

            while (dataReader.Read())
            {
                txtAd.Text = dataReader[1].ToString();
                txtSoyad.Text = dataReader[2].ToString();
                mskTelefon.Text = dataReader[4].ToString();
                txtSifre.Text = dataReader[5].ToString();
                cmbCinsiyet.Text = dataReader[6].ToString();
            }

            bgl.baglanti().Close();
        }

        private void btnBilgileriDuzenle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update Tbl_Hastalar set HastaAd=@p1, HastaSoyad=@p2, HastaTelefon=@p3, HastaSifre=@p4, HastaCinsiyet=@p5 Where HastaTC=" + TCNo, bgl.baglanti());

            komut.Parameters.AddWithValue("@p1", txtAd.Text);
            komut.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut.Parameters.AddWithValue("@p3", mskTelefon.Text);
            komut.Parameters.AddWithValue("@p4", txtSifre.Text);
            komut.Parameters.AddWithValue("@p5", cmbCinsiyet.Text);

            komut.ExecuteNonQuery();

            bgl.baglanti().Close();

            MessageBox.Show("Bilgileriniz Başarıyla Güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
