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
    public partial class FrmGrafikler: Form
    {
        public FrmGrafikler()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-GAARB72\\SQLEXPRESS;Initial Catalog=Personel;Integrated Security=True;");
        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("Select PerSehir,Count(*) From Tbl_Personel group by PerSehir",baglanti);
            SqlDataReader dataReader1 = komut1.ExecuteReader();
            while (dataReader1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dataReader1[0], dataReader1[1]);
            }

            baglanti.Close();

            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("Select PerMeslek, Avg(PerMaas) From Tbl_Personel group by PerMeslek", baglanti);
            SqlDataReader dataReader2 = komut2.ExecuteReader();
            while (dataReader2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(dataReader2[0], dataReader2[1]);
            }

            baglanti.Close();
        }
    }
}
