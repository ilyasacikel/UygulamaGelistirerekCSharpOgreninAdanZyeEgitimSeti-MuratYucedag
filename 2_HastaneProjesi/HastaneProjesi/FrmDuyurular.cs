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
    public partial class FrmDuyurular: Form
    {
        public FrmDuyurular()
        {
            InitializeComponent();
        }

        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmDuyurular_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Tbl_Duyurular", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            bgl.baglanti().Close();
        }
    }
}
