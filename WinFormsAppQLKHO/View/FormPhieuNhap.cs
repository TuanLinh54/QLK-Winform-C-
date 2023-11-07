using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsAppQLKHO.Model;
using WinFormsAppQLKHO.Controller;

namespace WinFormsAppQLKHO.View
{
    public partial class FormPhieuNhap : Form
    {
        khoController KhoController;//kho controller
        HanghoaController hangHoaController;// HangHoaController
        List<kho> dskho;//danh sach kho
        List<Hanghoa> dsHangHoa;//danh sach hang hoa
        PhieunhapController phieunhapController;
        CTPhieunhapController ctPhieuNhapController;
        Phieunhap currentPN;
        CTPhieunhap chitietPN;

        public FormPhieuNhap()
        {
            InitializeComponent();
            phieunhapController = new PhieunhapController();
            currentPN = new Phieunhap();
            ctPhieuNhapController = new CTPhieunhapController();
            chitietPN = new CTPhieunhap();
        }

        private void FormPhieuNhap_Load(object sender, EventArgs e)
        {
            dskho = new List<kho>(); //chứa danh sách kho
            KhoController = new khoController();//Kho controller
            dskho = KhoController.load();
            dsHangHoa = new List<Hanghoa>();
            hangHoaController = new HanghoaController();
            dsHangHoa = hangHoaController.load();


            foreach (kho k in dskho)
            {
                cbbMakho.Items.Add(k.getMakho());

            }
            DataGridViewComboBoxColumn comboboxColumn;
            comboboxColumn = new DataGridViewComboBoxColumn();
            comboboxColumn.DataPropertyName = "ID";
            comboboxColumn.HeaderText = "Mã hàng";
            comboboxColumn.DropDownWidth = 160;
            comboboxColumn.Width = 150;
            comboboxColumn.MaxDropDownItems = 3;
            comboboxColumn.FlatStyle = FlatStyle.Flat;
            foreach (Hanghoa k in dsHangHoa)
            {
                comboboxColumn.Items.Add(k.getMamh());
            }
            dtgridCTPhieuNhap.Columns.Clear();
            dtgridCTPhieuNhap.Columns.Add(comboboxColumn);//Ma hang
            //tên hàng
            DataGridViewTextBoxColumn colTenHang = new DataGridViewTextBoxColumn();
            colTenHang.DataPropertyName = "TenHang";
            colTenHang.HeaderText = "Tên hàng";
            dtgridCTPhieuNhap.Columns.Add(colTenHang);
            // Đơn vị tính
            DataGridViewTextBoxColumn colDVT = new DataGridViewTextBoxColumn();
            colDVT.DataPropertyName = "DVT";
            colDVT.HeaderText = "Đơn vị tính";
            dtgridCTPhieuNhap.Columns.Add(colDVT);
            // Số lượng
            DataGridViewTextBoxColumn colSoLuong = new DataGridViewTextBoxColumn();
            colSoLuong.DataPropertyName = "SoLuong";
            colSoLuong.HeaderText = "Số lượng";
            dtgridCTPhieuNhap.Columns.Add(colSoLuong);
            // Đơn giá
            DataGridViewTextBoxColumn colDongia = new DataGridViewTextBoxColumn();
            colDongia.DataPropertyName = "Dongia";
            colDongia.HeaderText = "Đơn giá";
            dtgridCTPhieuNhap.Columns.Add(colDongia);
            // Thành tiền
            DataGridViewTextBoxColumn colThanhTien = new DataGridViewTextBoxColumn();
            colThanhTien.DataPropertyName = "ThanhTien";
            colThanhTien.HeaderText = "Thành tiền";
            dtgridCTPhieuNhap.Columns.Add(colThanhTien);
        }

        private void dtgridPhieuNhap_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //column index 0 là mặt hàng
            if (e.ColumnIndex == 0)
            {
                String mamh = dtgridCTPhieuNhap.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
                dtgridCTPhieuNhap.Rows[e.RowIndex].Cells[1].Value = hangHoaController.Get(mamh).getTenmh();
                dtgridCTPhieuNhap.Rows[e.RowIndex].Cells[2].Value = hangHoaController.Get(mamh).getDvt();

            }
            //column index 4 là đơn giá
            if (e.ColumnIndex == 4)
            {
                int sluong = int.Parse(dtgridCTPhieuNhap.Rows[e.RowIndex].Cells[3].Value.ToString().Trim());
                decimal dongia = int.Parse(dtgridCTPhieuNhap.Rows[e.RowIndex].Cells[4].Value.ToString().Trim());
                dtgridCTPhieuNhap.Rows[e.RowIndex].Cells[5].Value = sluong * dongia;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(tbSophieu.Text)
                && !string.IsNullOrEmpty(tbSohd.Text)
                && !string.IsNullOrEmpty(tbDvphHD.Text)
                && cbbMakho.SelectedIndex != -1
                )
            {
                Phieunhap phieuNhap = new Phieunhap(
                        tbSophieu.Text,
                        cbbMakho.Text,
                        dtpNgaypn.Value,
                        null,
                        tbSohd.Text,
                        dtpNgayhd.Value,
                        tbDvphHD.Text
                    );
                bool check = phieunhapController.insert(phieuNhap);
                bool checkCT = false;
                for (int i = 0; i < dtgridCTPhieuNhap.Rows.Count - 1; i++)
                {
                    if (dtgridCTPhieuNhap.Rows[i].Cells[0].Value != null
                        && dtgridCTPhieuNhap.Rows[i].Cells[3].Value != null
                        && dtgridCTPhieuNhap.Rows[i].Cells[4].Value != null)
                    {
                        chitietPN = new CTPhieunhap(
                            tbSophieu.Text,
                            dtgridCTPhieuNhap.Rows[i].Cells[0].Value.ToString(),
                            int.Parse(dtgridCTPhieuNhap.Rows[i].Cells[3].Value.ToString()),
                            decimal.Parse(dtgridCTPhieuNhap.Rows[i].Cells[4].Value.ToString())
                            );

                        checkCT = ctPhieuNhapController.insert(chitietPN);

                    }
                }



                if (check && checkCT)
                {
                    MessageBox.Show("Lưu thành công !");
                }
                else
                {
                    MessageBox.Show("lỗi không lưu được hóa đơn !");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
