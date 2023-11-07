namespace WinFormsAppQLKHO
{
    partial class FormKho
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtQLK = new Label();
            txtMakho = new Label();
            txtTenkho = new Label();
            txtDiachi = new Label();
            tbMakho = new TextBox();
            tbTenkho = new TextBox();
            tbDiachi = new TextBox();
            btnInsert = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            tbSearch = new TextBox();
            btnSearch = new Button();
            dtgridKho = new DataGridView();
            makho = new DataGridViewTextBoxColumn();
            tenkho = new DataGridViewTextBoxColumn();
            diachi = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgridKho).BeginInit();
            SuspendLayout();
            // 
            // txtQLK
            // 
            txtQLK.AutoSize = true;
            txtQLK.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            txtQLK.Location = new Point(309, 9);
            txtQLK.Name = "txtQLK";
            txtQLK.Size = new Size(206, 38);
            txtQLK.TabIndex = 0;
            txtQLK.Text = "QUẢN LÝ KHO";
            // 
            // txtMakho
            // 
            txtMakho.AutoSize = true;
            txtMakho.Location = new Point(60, 88);
            txtMakho.Name = "txtMakho";
            txtMakho.Size = new Size(58, 20);
            txtMakho.TabIndex = 1;
            txtMakho.Text = "Mã kho";
            // 
            // txtTenkho
            // 
            txtTenkho.AutoSize = true;
            txtTenkho.Location = new Point(60, 143);
            txtTenkho.Name = "txtTenkho";
            txtTenkho.Size = new Size(60, 20);
            txtTenkho.TabIndex = 2;
            txtTenkho.Text = "Tên kho";
            // 
            // txtDiachi
            // 
            txtDiachi.AutoSize = true;
            txtDiachi.Location = new Point(60, 197);
            txtDiachi.Name = "txtDiachi";
            txtDiachi.Size = new Size(55, 20);
            txtDiachi.TabIndex = 3;
            txtDiachi.Text = "Địa chỉ";
            // 
            // tbMakho
            // 
            tbMakho.Location = new Point(159, 85);
            tbMakho.Name = "tbMakho";
            tbMakho.Size = new Size(202, 27);
            tbMakho.TabIndex = 4;
            // 
            // tbTenkho
            // 
            tbTenkho.Location = new Point(159, 140);
            tbTenkho.Name = "tbTenkho";
            tbTenkho.Size = new Size(202, 27);
            tbTenkho.TabIndex = 5;
            // 
            // tbDiachi
            // 
            tbDiachi.Location = new Point(159, 194);
            tbDiachi.Name = "tbDiachi";
            tbDiachi.Size = new Size(202, 27);
            tbDiachi.TabIndex = 6;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(401, 80);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(113, 32);
            btnInsert.TabIndex = 8;
            btnInsert.Text = "Thêm";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += btnInsert_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(401, 137);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(113, 32);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(401, 192);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(113, 31);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Xóa";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(595, 97);
            tbSearch.Name = "tbSearch";
            tbSearch.PlaceholderText = "Tìm kiếm ...";
            tbSearch.Size = new Size(193, 27);
            tbSearch.TabIndex = 11;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(657, 140);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(90, 30);
            btnSearch.TabIndex = 12;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // dtgridKho
            // 
            dtgridKho.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgridKho.Columns.AddRange(new DataGridViewColumn[] { makho, tenkho, diachi });
            dtgridKho.Location = new Point(0, 238);
            dtgridKho.Name = "dtgridKho";
            dtgridKho.RowHeadersWidth = 51;
            dtgridKho.RowTemplate.Height = 29;
            dtgridKho.Size = new Size(813, 211);
            dtgridKho.TabIndex = 13;
            dtgridKho.CellClick += dtgridKho_CellClick;
            // 
            // makho
            // 
            makho.HeaderText = "Mã kho";
            makho.MinimumWidth = 6;
            makho.Name = "makho";
            makho.Width = 125;
            // 
            // tenkho
            // 
            tenkho.HeaderText = "Tên Kho";
            tenkho.MinimumWidth = 6;
            tenkho.Name = "tenkho";
            tenkho.Width = 320;
            // 
            // diachi
            // 
            diachi.HeaderText = "Địa chỉ";
            diachi.MinimumWidth = 6;
            diachi.Name = "diachi";
            diachi.Width = 320;
            // 
            // FormKho
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(814, 450);
            Controls.Add(dtgridKho);
            Controls.Add(btnSearch);
            Controls.Add(tbSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnInsert);
            Controls.Add(tbDiachi);
            Controls.Add(tbTenkho);
            Controls.Add(tbMakho);
            Controls.Add(txtDiachi);
            Controls.Add(txtTenkho);
            Controls.Add(txtMakho);
            Controls.Add(txtQLK);
            Name = "FormKho";
            Text = "FormKho";
            Load += FormKho_Load;
            ((System.ComponentModel.ISupportInitialize)dtgridKho).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtQLK;
        private Label txtMakho;
        private Label txtTenkho;
        private Label txtDiachi;
        private TextBox tbMakho;
        private TextBox tbTenkho;
        private TextBox tbDiachi;
        private Button btnInsert;
        private Button btnUpdate;
        private Button btnDelete;
        private TextBox tbSearch;
        private Button btnSearch;
        private DataGridView dtgridKho;
        private DataGridViewTextBoxColumn makho;
        private DataGridViewTextBoxColumn tenkho;
        private DataGridViewTextBoxColumn diachi;
    }
}