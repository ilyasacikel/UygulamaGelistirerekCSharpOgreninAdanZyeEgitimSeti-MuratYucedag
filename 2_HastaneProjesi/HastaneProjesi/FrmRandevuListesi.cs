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
    public partial class FrmRandevuListesi: Form
    {
        
        public FrmRandevuListesi()
        {
            InitializeComponent();

        }

        SqlBaglantim bgl = new SqlBaglantim();
        private void FrmRandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * From Tbl_Randevular", bgl.baglanti());
            dataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            bgl.baglanti().Close();
        }

        public string RandevuId;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var secilen = dataGridView1.SelectedCells[0].RowIndex;
            RandevuId = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
        }
    }
}
