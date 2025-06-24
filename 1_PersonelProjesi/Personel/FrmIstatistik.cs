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

namespace Personel
{
    public partial class FrmIstatistik: Form
    {
        public FrmIstatistik()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GAARB72\\SQLEXPRESS;Initial Catalog=Personel;Integrated Security=True;");
        private void Istatistik_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("Select Count(*) From Tbl_Personel", baglanti);
            SqlDataReader dataReader1 = komut1.ExecuteReader();
            while (dataReader1.Read())
            {
                lblToplamPersonel.Text = dataReader1[0].ToString();
            }

            baglanti.Close();

            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("Select Count(*) From Tbl_Personel Where PerMedeniDurum=1",baglanti);
            SqlDataReader dataReader2 = komut2.ExecuteReader();
            while (dataReader2.Read())
            {
                lblEvliPersonel.Text = dataReader2[0].ToString();
            }

            baglanti.Close();

            baglanti.Open();

            SqlCommand komut3 = new SqlCommand("Select Count(*) From Tbl_Personel Where PerMedeniDurum=0", baglanti);
            SqlDataReader dataReader3 = komut3.ExecuteReader();
            while(dataReader3.Read())
            {
                lblBekarPersonel.Text = dataReader3[0].ToString();
            }

            baglanti.Close();

            baglanti.Open();

            SqlCommand komut4 = new SqlCommand("Select Count(distinct(PerSehir)) From Tbl_Personel", baglanti);
            SqlDataReader dataReader4 = komut4.ExecuteReader();
            while (dataReader4.Read())
            {
                lblSehirSayisi.Text = dataReader4[0].ToString();
            }

            baglanti.Close();

            baglanti.Open();

            SqlCommand komut5 = new SqlCommand("Select Sum(PerMaas) From Tbl_Personel", baglanti);
            SqlDataReader dataReader5 = komut5.ExecuteReader();
            while (dataReader5.Read())
            {
                lblToplamMaas.Text = dataReader5[0].ToString()+ " ₺";
            }

            baglanti.Close();

            baglanti.Open();

            SqlCommand komut6 = new SqlCommand("Select Max(PerMaas) From Tbl_Personel", baglanti);
            SqlDataReader dataReader6 = komut6.ExecuteReader();
            while (dataReader6.Read())
            {
                lblMaksimumMaas.Text = dataReader6[0].ToString() + " ₺";
            }

            baglanti.Close();

            baglanti.Open();

            SqlCommand komut7 = new SqlCommand("Select Min(PerMaas) From Tbl_Personel", baglanti);
            SqlDataReader dataReader7 = komut7.ExecuteReader();
            while (dataReader7.Read())
            {
                lblMinimumMaas.Text = dataReader7[0].ToString() + " ₺";
            }

            baglanti.Close();

            baglanti.Open();

            SqlCommand komut8 = new SqlCommand("Select Avg(PerMaas) From Tbl_Personel", baglanti);
            SqlDataReader dataReader8 = komut8.ExecuteReader();
            while (dataReader8.Read())
            {
                lblOrtalamaMaas.Text = dataReader8[0].ToString() + " ₺";
            }

            baglanti.Close();

        }
    }
}
