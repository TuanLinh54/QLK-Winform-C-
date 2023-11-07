using WinFormsAppQLKHO;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Reflection.Metadata;
using System.Windows.Forms;
using WinFormsAppQLKHO.Model;
using WinFormsAppQLKHO.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsAppQLKHO
{
    public partial class FormKho : Form
    {
        khoController khoController;
        List<kho> dskho;
        kho currentKho;

        public FormKho()
        {
            InitializeComponent();
            khoController = new khoController();
            dskho = new List<kho>();
            currentKho = new kho();

            dtgridKho.ColumnCount = 3;
            dtgridKho.Columns[0].Name = "Mã kho";
            dtgridKho.Columns[1].Name = "Tên kho";
            dtgridKho.Columns[2].Name = "Địa chỉ";
        }

        private void FormKho_Load(object sender, EventArgs e)
        {
            if(dskho.Count > 0)
            {
                dskho.Clear();
            }

            dskho = khoController.load();
            dtgridKho.Rows.Clear();
            foreach (kho kho in dskho)
            {
                String[] row = { kho.getMakho(), kho.getTenkho(), kho.getDiachi() };
                dtgridKho.Rows.Add(row);
            }
        }

        private void listItem_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            currentKho = new kho(tbMakho.Text, tbTenkho.Text, tbDiachi.Text);
            khoController.delete(currentKho);
            FormKho_Load(sender, e);

            tbMakho.Clear();
            tbTenkho.Clear();
            tbDiachi.Clear();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            currentKho = new kho(tbMakho.Text, tbTenkho.Text, tbDiachi.Text);
            if (khoController.isExist(tbMakho.Text))
            {
                bool updatedSuccess = khoController.update(currentKho);
                if (updatedSuccess)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    tbMakho.Clear();
                    tbTenkho.Clear();
                    tbDiachi.Clear();
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

            FormKho_Load(sender, e);

            
        }



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string makhoSearch = tbSearch.Text;
            if (!string.IsNullOrEmpty(makhoSearch))
            {
                    dtgridKho.Rows.Clear();
                    kho Kho = khoController.Get(makhoSearch);
                    String[] row = { Kho.getMakho(), Kho.getTenkho(), Kho.getDiachi() };
                    dtgridKho.Rows.Add(row);
            }
            else
            {
                FormKho_Load(sender, e);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            currentKho = new kho(tbMakho.Text, tbTenkho.Text, tbDiachi.Text);
            if (!khoController.isExist(tbMakho.Text))
            {
                bool updatedSuccess = khoController.insert(currentKho);
                if (updatedSuccess)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    tbMakho.Clear();
                    tbTenkho.Clear();
                    tbDiachi.Clear();
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
            FormKho_Load(sender, e);

        }



        private void dtgridKho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgridKho.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dtgridKho.SelectedRows)
                {
                    string maKho = row.Cells[0].Value.ToString();
                    string tenKho = row.Cells[1].Value.ToString();
                    string diaChi = row.Cells[2].Value.ToString();

                    tbMakho.Text = maKho;
                    tbTenkho.Text = tenKho;
                    tbDiachi.Text = diaChi;

                }
                
            }
            
        }


    }


}

