using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppQLKHO.Controller;
using WinFormsAppQLKHO.Model;

namespace WinFormsAppQLKHO.View
{
    public partial class FormHangHoa : Form
    {
        HanghoaController hangHoacontroller;
        List<Hanghoa> dsHanghoa;
        Hanghoa currentHanghoa;

        public FormHangHoa()
        {
            InitializeComponent();
            hangHoacontroller = new HanghoaController();
            dsHanghoa = new List<Hanghoa>();
            currentHanghoa = new Hanghoa();

            dtgridHanghoa.ColumnCount = 3;
            dtgridHanghoa.Columns[0].Name = "Mã mặt hàng";
            dtgridHanghoa.Columns[1].Name = "Tên mặt hàng";
            dtgridHanghoa.Columns[2].Name = "Đơn vị tính";
        }

        private void FormHangHoa_Load(object sender, EventArgs e)
        {
            if (dsHanghoa.Count > 0)
            {
                dsHanghoa.Clear();
            }

            dsHanghoa = hangHoacontroller.load();
            dtgridHanghoa.Rows.Clear();
            foreach (Hanghoa hangHoa in dsHanghoa)
            {

                String[] row = { hangHoa.getMamh(), hangHoa.getTenmh(), hangHoa.getDvt() };
                dtgridHanghoa.Rows.Add(row);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            currentHanghoa = new Hanghoa(tbMamh.Text, tbTenmh.Text, tbDVT.Text);
            if (!hangHoacontroller.isExist(tbMamh.Text))
            {
                bool updatedSuccess = hangHoacontroller.insert(currentHanghoa);
                if (updatedSuccess)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    tbMamh.Clear();
                    tbTenmh.Clear();
                    tbDVT.Clear();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại !");
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu đã tồn tại !");
            }
            FormHangHoa_Load(sender, e);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            currentHanghoa = new Hanghoa(tbMamh.Text, tbTenmh.Text, tbDVT.Text);
            if (hangHoacontroller.isExist(tbMamh.Text))
            {
                bool updatedSuccess = hangHoacontroller.update(currentHanghoa);
                if (updatedSuccess)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    tbMamh.Clear();
                    tbTenmh.Clear();
                    tbDVT.Clear();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại !");
                }
            }
            else
            {
                MessageBox.Show("Dữ liệu không tồn tại !");
            }

            FormHangHoa_Load(sender, e);


        }

        private void dtgridHanghoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgridHanghoa.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgridHanghoa.SelectedRows)
                {
                    string mamh = row.Cells[0].Value.ToString();
                    string tenmh = row.Cells[1].Value.ToString();
                    string dvt = row.Cells[2].Value.ToString();

                    tbMamh.Text = mamh;
                    tbTenmh.Text = tenmh;
                    tbDVT.Text = dvt;

                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            currentHanghoa = new Hanghoa(tbMamh.Text, tbTenmh.Text, tbDVT.Text);
            hangHoacontroller.delete(currentHanghoa);
            FormHangHoa_Load(sender, e);

            tbMamh.Clear();
            tbTenmh.Clear();
            tbDVT.Clear();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string mamhSearch = tbSearch.Text;
            if (!string.IsNullOrEmpty(mamhSearch))
            {
                dtgridHanghoa.Rows.Clear();
                Hanghoa hangHoa = hangHoacontroller.Get(mamhSearch);
                String[] row = { hangHoa.getMamh(), hangHoa.getTenmh(), hangHoa.getDvt() };
                dtgridHanghoa.Rows.Add(row);
            }
            else
            {
                FormHangHoa_Load(sender, e);
            }
        }
    }
}
