using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EOkulProje
{
    public partial class FrmOgretmen: Form
    {
        public FrmOgretmen()
        {
            InitializeComponent();
        }

        private void btnKulupIslemleri_Click(object sender, EventArgs e)
        {
            FrmKulupIslemleri frm = new FrmKulupIslemleri();
            frm.Show();
        }

        private void btnDersIslemleri_Click(object sender, EventArgs e)
        {
            FrmDersler frm = new FrmDersler();
            frm.Show();
        }

        private void btnOgrenciIslemleri_Click(object sender, EventArgs e)
        {
            FrmOgrenciIslemleri frm = new FrmOgrenciIslemleri();
            frm.Show();
        }

        private void btnSinavNotlari_Click(object sender, EventArgs e)
        {
            FrmSinavNotlar frm = new FrmSinavNotlar();
            frm.Show();
        }
    }
}
