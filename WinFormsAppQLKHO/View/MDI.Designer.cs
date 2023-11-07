namespace WinFormsAppQLKHO.View
{
    partial class MDI
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
            menuStrip1 = new MenuStrip();
            trangChủToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            thêmToolStripMenuItem = new ToolStripMenuItem();
            phiếuNhậpToolStripMenuItem = new ToolStripMenuItem();
            hàngHóaToolStripMenuItem = new ToolStripMenuItem();
            viewToolStripMenuItem = new ToolStripMenuItem();
            dSKhoToolStripMenuItem = new ToolStripMenuItem();
            dSHàngHóaToolStripMenuItem = new ToolStripMenuItem();
            dSPhiếuNhậpToolStripMenuItem = new ToolStripMenuItem();
            addToolStripMenuItem = new ToolStripMenuItem();
            khoToolStripMenuItem = new ToolStripMenuItem();
            hàngHóaToolStripMenuItem1 = new ToolStripMenuItem();
            phiếuNhậpToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { trangChủToolStripMenuItem, editToolStripMenuItem, viewToolStripMenuItem, addToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            trangChủToolStripMenuItem.Size = new Size(87, 24);
            trangChủToolStripMenuItem.Text = "Trang chủ";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thêmToolStripMenuItem, phiếuNhậpToolStripMenuItem, hàngHóaToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // thêmToolStripMenuItem
            // 
            thêmToolStripMenuItem.Name = "thêmToolStripMenuItem";
            thêmToolStripMenuItem.Size = new Size(165, 26);
            thêmToolStripMenuItem.Text = "Kho";
            // 
            // phiếuNhậpToolStripMenuItem
            // 
            phiếuNhậpToolStripMenuItem.Name = "phiếuNhậpToolStripMenuItem";
            phiếuNhậpToolStripMenuItem.Size = new Size(165, 26);
            phiếuNhậpToolStripMenuItem.Text = "Phiếu nhập";
            // 
            // hàngHóaToolStripMenuItem
            // 
            hàngHóaToolStripMenuItem.Name = "hàngHóaToolStripMenuItem";
            hàngHóaToolStripMenuItem.Size = new Size(165, 26);
            hàngHóaToolStripMenuItem.Text = "Hàng hóa";
            // 
            // viewToolStripMenuItem
            // 
            viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { dSKhoToolStripMenuItem, dSHàngHóaToolStripMenuItem, dSPhiếuNhậpToolStripMenuItem });
            viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            viewToolStripMenuItem.Size = new Size(55, 24);
            viewToolStripMenuItem.Text = "View";
            // 
            // dSKhoToolStripMenuItem
            // 
            dSKhoToolStripMenuItem.Name = "dSKhoToolStripMenuItem";
            dSKhoToolStripMenuItem.Size = new Size(188, 26);
            dSKhoToolStripMenuItem.Text = "DS Kho";
            dSKhoToolStripMenuItem.Click += dSKhoToolStripMenuItem_Click;
            // 
            // dSHàngHóaToolStripMenuItem
            // 
            dSHàngHóaToolStripMenuItem.Name = "dSHàngHóaToolStripMenuItem";
            dSHàngHóaToolStripMenuItem.Size = new Size(188, 26);
            dSHàngHóaToolStripMenuItem.Text = "DS Hàng Hóa";
            // 
            // dSPhiếuNhậpToolStripMenuItem
            // 
            dSPhiếuNhậpToolStripMenuItem.Name = "dSPhiếuNhậpToolStripMenuItem";
            dSPhiếuNhậpToolStripMenuItem.Size = new Size(188, 26);
            dSPhiếuNhậpToolStripMenuItem.Text = "DS Phiếu nhập";
            // 
            // addToolStripMenuItem
            // 
            addToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { khoToolStripMenuItem, hàngHóaToolStripMenuItem1, phiếuNhậpToolStripMenuItem1 });
            addToolStripMenuItem.Name = "addToolStripMenuItem";
            addToolStripMenuItem.Size = new Size(51, 24);
            addToolStripMenuItem.Text = "Add";
            // 
            // khoToolStripMenuItem
            // 
            khoToolStripMenuItem.Name = "khoToolStripMenuItem";
            khoToolStripMenuItem.Size = new Size(224, 26);
            khoToolStripMenuItem.Text = "Kho";
            // 
            // hàngHóaToolStripMenuItem1
            // 
            hàngHóaToolStripMenuItem1.Name = "hàngHóaToolStripMenuItem1";
            hàngHóaToolStripMenuItem1.Size = new Size(224, 26);
            hàngHóaToolStripMenuItem1.Text = "Hàng hóa";
            hàngHóaToolStripMenuItem1.Click += hàngHóaToolStripMenuItem1_Click;
            // 
            // phiếuNhậpToolStripMenuItem1
            // 
            phiếuNhậpToolStripMenuItem1.Name = "phiếuNhậpToolStripMenuItem1";
            phiếuNhậpToolStripMenuItem1.Size = new Size(224, 26);
            phiếuNhậpToolStripMenuItem1.Text = "Phiếu nhập";
            phiếuNhậpToolStripMenuItem1.Click += phiếuNhậpToolStripMenuItem1_Click;
            // 
            // MDI
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MDI";
            Text = "MDI";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem trangChủToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem thêmToolStripMenuItem;
        private ToolStripMenuItem viewToolStripMenuItem;
        private ToolStripMenuItem dSKhoToolStripMenuItem;
        private ToolStripMenuItem dSHàngHóaToolStripMenuItem;
        private ToolStripMenuItem phiếuNhậpToolStripMenuItem;
        private ToolStripMenuItem hàngHóaToolStripMenuItem;
        private ToolStripMenuItem dSPhiếuNhậpToolStripMenuItem;
        private ToolStripMenuItem addToolStripMenuItem;
        private ToolStripMenuItem khoToolStripMenuItem;
        private ToolStripMenuItem hàngHóaToolStripMenuItem1;
        private ToolStripMenuItem phiếuNhậpToolStripMenuItem1;
    }
}