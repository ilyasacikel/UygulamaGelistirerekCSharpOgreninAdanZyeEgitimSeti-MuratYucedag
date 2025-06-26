using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DbEntityUrunProje
{
    public partial class FrmAnaForm: Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void btnKategoriIslemleri_Click(object sender, EventArgs e)
        {
            FrmKategoriIslemleri frm = new FrmKategoriIslemleri();
            frm.Show();
        }

        private void btnUrunIslemleri_Click(object sender, EventArgs e)
        {
            FrmUrunIslemleri frm = new FrmUrunIslemleri();
            frm.Show();
        }

        private void btnIstatistikler_Click(object sender, EventArgs e)
        {
            FrmIstatistik frm = new FrmIstatistik();
            frm.Show();
        }
    }
}
