namespace WinFormsAppQLKHO.View
{
    partial class FormHangHoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dtgridHanghoa = new DataGridView();
            mamh = new DataGridViewTextBoxColumn();
            tenmh = new DataGridViewTextBoxColumn();
            DVT = new DataGridViewTextBoxColumn();
            btnSearch = new Button();
            tbSearch = new TextBox();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnInsert = new Button();
            tbDVT = new TextBox();
            tbTenmh = new TextBox();
            tbMamh = new TextBox();
            txtDVT = new Label();
            txtTenmh = new Label();
            txtMamh = new Label();
            txtQLK = new Label();
            ((System.ComponentModel.ISupportInitialize)dtgridHanghoa).BeginInit();
            SuspendLayout();
            // 
            // dtgridHanghoa
            // 
            dtgridHanghoa.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgridHanghoa.Columns.AddRange(new DataGridViewColumn[] { mamh, tenmh, DVT });
            dtgridHanghoa.Location = new Point(-6, 234);
            dtgridHanghoa.Name = "dtgridHanghoa";
            dtgridHanghoa.RowHeadersWidth = 51;
            dtgridHanghoa.RowTemplate.Height = 29;
            dtgridHanghoa.Size = new Size(813, 211);
            dtgridHanghoa.TabIndex = 26;
            dtgridHanghoa.CellClick += dtgridHanghoa_CellClick;
            // 
            // mamh
            // 
            mamh.HeaderText = "Mã mặt hàng";
            mamh.MinimumWidth = 6;
            mamh.Name = "mamh";
            mamh.Width = 125;
            // 
            // tenmh
            // 
            tenmh.HeaderText = "Tên Mặt hàng";
            tenmh.MinimumWidth = 6;
            tenmh.Name = "tenmh";
            tenmh.Width = 320;
            // 
            // DVT
            // 
            DVT.HeaderText = "Đơn vị tính";
            DVT.MinimumWidth = 6;
            DVT.Name = "DVT";
            DVT.Width = 320;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(651, 136);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 30);
            btnSearch.TabIndex = 25;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(589, 93);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Tìm kiếm ...";
            tbSearch.Size = new Size(193, 27);
            tbSearch.TabIndex = 24;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(395, 188);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 31);
            btnDelete.TabIndex = 23;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(395, 133);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 32);
            btnUpdate.TabIndex = 22;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(395, 76);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(113, 32);
            btnInsert.TabIndex = 21;
            btnInsert.Text = "Thêm";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // tbDVT
            // 
            tbDVT.Location = new Point(153, 190);
            tbDVT.Name = "tbDVT";
            tbDVT.Size = new Size(202, 27);
            tbDVT.TabIndex = 20;
            // 
            // tbTenmh
            // 
            tbTenmh.Location = new Point(153, 136);
            tbTenmh.Name = "tbTenmh";
            tbTenmh.Size = new Size(202, 27);
            tbTenmh.TabIndex = 19;
            // 
            // tbMamh
            // 
            tbMamh.Location = new Point(153, 81);
            tbMamh.Name = "tbMamh";
            tbMamh.Size = new Size(202, 27);
            tbMamh.TabIndex = 18;
            // 
            // txtDVT
            // 
            txtDVT.AutoSize = true;
            txtDVT.Location = new Point(54, 193);
            txtDVT.Name = "txtDVT";
            txtDVT.Size = new Size(81, 20);
            txtDVT.TabIndex = 17;
            txtDVT.Text = "Đơn vị tính";
            // 
            // txtTenmh
            // 
            txtTenmh.AutoSize = true;
            txtTenmh.Location = new Point(54, 139);
            txtTenmh.Name = "txtTenmh";
            txtTenmh.Size = new Size(99, 20);
            txtTenmh.TabIndex = 16;
            txtTenmh.Text = "Tên mặt hàng";
            // 
            // txtMamh
            // 
            txtMamh.AutoSize = true;
            txtMamh.Location = new Point(54, 84);
            txtMamh.Name = "txtMamh";
            txtMamh.Size = new Size(97, 20);
            txtMamh.TabIndex = 15;
            txtMamh.Text = "Mã mặt hàng";
            // 
            // txtQLK
            // 
            txtQLK.AutoSize = true;
            txtQLK.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtQLK.Location = new Point(249, 9);
            txtQLK.Name = "txtQLK";
            txtQLK.Size = new Size(299, 38);
            txtQLK.TabIndex = 14;
            txtQLK.Text = "QUẢN LÝ HÀNG HÓA";
            // 
            // FormHangHoa
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dtgridHanghoa);
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(tbDVT);
            Controls.Add(tbTenmh);
            Controls.Add(tbMamh);
            Controls.Add(txtDVT);
            Controls.Add(txtTenmh);
            Controls.Add(txtMamh);
            Controls.Add(txtQLK);
            Name = "FormHangHoa";
            Text = "FormHangHoa";
            Load += FormHangHoa_Load;
            ((System.ComponentModel.ISupportInitialize)dtgridHanghoa).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dtgridHanghoa;
        private DataGridViewTextBoxColumn mamh;
        private DataGridViewTextBoxColumn tenmh;
        private DataGridViewTextBoxColumn DVT;
        private Button btnSearch;
        private TextBox tbSearch;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnInsert;
        private TextBox tbDVT;
        private TextBox tbTenmh;
        private TextBox tbMamh;
        private Label txtDVT;
        private Label txtTenmh;
        private Label txtMamh;
        private Label txtQLK;
    }
}