namespace WinFormsAppQLKHO.View
{
    partial class FormPhieuNhap
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbSophieu = new TextBox();
            tbSohd = new TextBox();
            label4 = new Label();
            cbbMakho = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tbDvphHD = new TextBox();
            dtgridCTPhieuNhap = new DataGridView();
            btnSave = new Button();
            btnClose = new Button();
            label8 = new Label();
            dtpNgaypn = new DateTimePicker();
            dtpNgayhd = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dtgridCTPhieuNhap).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(356, 9);
            label1.Name = "label1";
            label1.Size = new Size(255, 38);
            label1.TabIndex = 0;
            label1.Text = "PHIẾU NHẬP KHO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 62);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Số phiếu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 95);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Số HĐ";
            // 
            // tbSophieu
            // 
            tbSophieu.Location = new Point(92, 59);
            tbSophieu.Name = "tbSophieu";
            tbSophieu.Size = new Size(149, 27);
            tbSophieu.TabIndex = 3;
            // 
            // tbSohd
            // 
            tbSohd.Location = new Point(92, 92);
            tbSohd.Name = "tbSohd";
            tbSohd.Size = new Size(149, 27);
            tbSohd.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 128);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 5;
            label4.Text = "Mã kho";
            // 
            // cbbMakho
            // 
            cbbMakho.FormattingEnabled = true;
            cbbMakho.Location = new Point(92, 125);
            cbbMakho.Name = "cbbMakho";
            cbbMakho.Size = new Size(149, 28);
            cbbMakho.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(266, 61);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 7;
            label5.Text = "Ngày";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(266, 94);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 8;
            label6.Text = "Ngày HĐ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(543, 95);
            label7.Name = "label7";
            label7.Size = new Size(125, 20);
            label7.TabIndex = 9;
            label7.Text = "ĐV phát hành HĐ";
            // 
            // tbDvphHD
            // 
            tbDvphHD.Location = new Point(674, 92);
            tbDvphHD.Name = "tbDvphHD";
            tbDvphHD.Size = new Size(210, 27);
            tbDvphHD.TabIndex = 12;
            // 
            // dtgridCTPhieuNhap
            // 
            dtgridCTPhieuNhap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgridCTPhieuNhap.Location = new Point(0, 215);
            dtgridCTPhieuNhap.Name = "dtgridCTPhieuNhap";
            dtgridCTPhieuNhap.RowHeadersWidth = 51;
            dtgridCTPhieuNhap.RowTemplate.Height = 29;
            dtgridCTPhieuNhap.Size = new Size(905, 222);
            dtgridCTPhieuNhap.TabIndex = 13;
            dtgridCTPhieuNhap.CellEndEdit += dtgridPhieuNhap_CellEndEdit;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(646, 448);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 33);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(752, 448);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(87, 33);
            btnClose.TabIndex = 15;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 192);
            label8.Name = "label8";
            label8.Size = new Size(144, 20);
            label8.TabIndex = 16;
            label8.Text = "Danh sách mặt hàng";
            // 
            // dtpNgaypn
            // 
            dtpNgaypn.Location = new Point(347, 57);
            dtpNgaypn.Name = "dtpNgaypn";
            dtpNgaypn.Size = new Size(182, 27);
            dtpNgaypn.TabIndex = 17;
            // 
            // dtpNgayhd
            // 
            dtpNgayhd.Location = new Point(347, 90);
            dtpNgayhd.Name = "dtpNgayhd";
            dtpNgayhd.Size = new Size(182, 27);
            dtpNgayhd.TabIndex = 18;
            // 
            // FormPhieuNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 491);
            Controls.Add(dtpNgayhd);
            Controls.Add(dtpNgaypn);
            Controls.Add(label8);
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(dtgridCTPhieuNhap);
            Controls.Add(tbDvphHD);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cbbMakho);
            Controls.Add(label4);
            Controls.Add(tbSohd);
            Controls.Add(tbSophieu);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormPhieuNhap";
            Text = "FormPhieuNhap";
            Load += FormPhieuNhap_Load;
            ((System.ComponentModel.ISupportInitialize)dtgridCTPhieuNhap).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbSophieu;
        private TextBox tbSohd;
        private Label label4;
        private ComboBox cbbMakho;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tbDvphHD;
        private DataGridView dtgridCTPhieuNhap;
        private Button btnSave;
        private Button btnClose;
        private Label label8;
        private DateTimePicker dtpNgaypn;
        private DateTimePicker dtpNgayhd;
    }
}