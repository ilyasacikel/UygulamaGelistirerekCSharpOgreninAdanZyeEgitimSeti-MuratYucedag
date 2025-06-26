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
    public partial class FrmOgrenciNotlar: Form
    {
        public FrmOgrenciNotlar()
        {
            InitializeComponent();
        }

        public string OGRID;
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GAARB72\\SQLEXPRESS;Initial Catalog=EOkulProje;Integrated Security=True;");
        private void FrmOgrenciNotlar_Load(object sender, EventArgs e)
        {

            baglanti.Open();
            SqlCommand komutAdSoyad = new SqlCommand("Select OGRAD,OGRSOYAD From TBLOGRENCILER Where OGRID=@p1", baglanti);
            komutAdSoyad.Parameters.AddWithValue("@p1", OGRID);
            SqlDataReader dataReader = komutAdSoyad.ExecuteReader();
            while (dataReader.Read())
            {
                this.Text = dataReader[0].ToString() + " " + dataReader[1].ToString() + " - ÖĞRENCİ NOT TABLOSU";
            }
            baglanti.Close();

            baglanti.Open();
            SqlCommand komut = new SqlCommand("SELECT DERSAD,YAZILI1,YAZILI2,YAZILI3,PROJE,ORTALAMA,DURUM From TBLNOTLAR INNER JOIN TBLDERSLER ON TBLNOTLAR.DERSID = TBLDERSLER.DERSID WHERE OGRID=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", OGRID);
            SqlDataAdapter dataAdapter = new SqlDataAdapter(komut);
            DataTable dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            baglanti.Close();
        }
    }
}
