using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppQLKHO.View
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();


        }

        private void dSKhoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKho formKho = new FormKho();
            formKho.Show();
        }

        private void phiếuNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormPhieuNhap formPhieuNhap = new FormPhieuNhap();
            formPhieuNhap.Show();
        }

        private void hàngHóaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormHangHoa formHangHoa = new FormHangHoa();
            formHangHoa.Show();
        }
    }
}
