namespace managerStudent
{
    partial class TrangChuQuanLy
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
            dataGridView1 = new DataGridView();
            MaHS = new DataGridViewTextBoxColumn();
            HoTenHS = new DataGridViewTextBoxColumn();
            NgSinh = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            DanToc = new DataGridViewTextBoxColumn();
            NoiSinh = new DataGridViewTextBoxColumn();
            TenLop = new DataGridViewTextBoxColumn();
            NamHoc = new DataGridViewTextBoxColumn();
            chinhSuaColumn = new DataGridViewButtonColumn();
            xemDiemColumn = new DataGridViewButtonColumn();
            XoaColumn = new DataGridViewButtonColumn();
            menuStrip1 = new MenuStrip();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            manageCategoryToolStripMenuItem = new ToolStripMenuItem();
            newCategoryToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            manageProductToolStripMenuItem = new ToolStripMenuItem();
            newProductToolStripMenuItem = new ToolStripMenuItem();
            khối8ToolStripMenuItem = new ToolStripMenuItem();
            khối9ToolStripMenuItem = new ToolStripMenuItem();
            btnThemMoi = new Button();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaHS, HoTenHS, NgSinh, GioiTinh, DanToc, NoiSinh, TenLop, NamHoc, chinhSuaColumn, xemDiemColumn, XoaColumn });
            dataGridView1.Location = new Point(35, 197);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1685, 376);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MaHS
            // 
            MaHS.DataPropertyName = "MaHS";
            MaHS.HeaderText = "Mã Học Sinh";
            MaHS.MinimumWidth = 8;
            MaHS.Name = "MaHS";
            MaHS.Width = 150;
            // 
            // HoTenHS
            // 
            HoTenHS.DataPropertyName = "HoTenHS";
            HoTenHS.HeaderText = "Họ Tên";
            HoTenHS.MinimumWidth = 8;
            HoTenHS.Name = "HoTenHS";
            HoTenHS.Width = 150;
            // 
            // NgSinh
            // 
            NgSinh.DataPropertyName = "NgSinh";
            NgSinh.HeaderText = "Ngày Sinh";
            NgSinh.MinimumWidth = 8;
            NgSinh.Name = "NgSinh";
            NgSinh.Width = 150;
            // 
            // GioiTinh
            // 
            GioiTinh.DataPropertyName = "GioiTinh";
            GioiTinh.HeaderText = "Giới Tính";
            GioiTinh.MinimumWidth = 8;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.Width = 150;
            // 
            // DanToc
            // 
            DanToc.DataPropertyName = "DanToc";
            DanToc.HeaderText = "Dân tộc";
            DanToc.MinimumWidth = 8;
            DanToc.Name = "DanToc";
            DanToc.Resizable = DataGridViewTriState.True;
            DanToc.Width = 150;
            // 
            // NoiSinh
            // 
            NoiSinh.DataPropertyName = "NoiSinh";
            NoiSinh.HeaderText = "Nơi Sinh";
            NoiSinh.MinimumWidth = 8;
            NoiSinh.Name = "NoiSinh";
            NoiSinh.Width = 150;
            // 
            // TenLop
            // 
            TenLop.DataPropertyName = "TenLop";
            TenLop.HeaderText = "Lớp";
            TenLop.MinimumWidth = 8;
            TenLop.Name = "TenLop";
            TenLop.Width = 150;
            // 
            // NamHoc
            // 
            NamHoc.DataPropertyName = "NamHoc";
            NamHoc.HeaderText = "Năm học";
            NamHoc.MinimumWidth = 8;
            NamHoc.Name = "NamHoc";
            NamHoc.Width = 150;
            // 
            // chinhSuaColumn
            // 
            chinhSuaColumn.HeaderText = "Chỉnh sửa";
            chinhSuaColumn.MinimumWidth = 8;
            chinhSuaColumn.Name = "chinhSuaColumn";
            chinhSuaColumn.Resizable = DataGridViewTriState.True;
            chinhSuaColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            chinhSuaColumn.ToolTipText = "Sửa";
            chinhSuaColumn.UseColumnTextForButtonValue = true;
            chinhSuaColumn.Width = 150;
            // 
            // xemDiemColumn
            // 
            xemDiemColumn.HeaderText = "Xem điểm";
            xemDiemColumn.MinimumWidth = 8;
            xemDiemColumn.Name = "xemDiemColumn";
            xemDiemColumn.Resizable = DataGridViewTriState.True;
            xemDiemColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            xemDiemColumn.Width = 150;
            // 
            // XoaColumn
            // 
            XoaColumn.HeaderText = "Xóa";
            XoaColumn.MinimumWidth = 8;
            XoaColumn.Name = "XoaColumn";
            XoaColumn.Resizable = DataGridViewTriState.True;
            XoaColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            XoaColumn.ToolTipText = "Xoá";
            XoaColumn.UseColumnTextForButtonValue = true;
            XoaColumn.Width = 150;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { categoryToolStripMenuItem, productToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1732, 33);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageCategoryToolStripMenuItem, newCategoryToolStripMenuItem });
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(69, 29);
            categoryToolStripMenuItem.Text = "Tổng";
            // 
            // manageCategoryToolStripMenuItem
            // 
            manageCategoryToolStripMenuItem.Name = "manageCategoryToolStripMenuItem";
            manageCategoryToolStripMenuItem.Size = new Size(267, 34);
            manageCategoryToolStripMenuItem.Text = "Danh sách học sinh";
            // 
            // newCategoryToolStripMenuItem
            // 
            newCategoryToolStripMenuItem.Name = "newCategoryToolStripMenuItem";
            newCategoryToolStripMenuItem.Size = new Size(267, 34);
            newCategoryToolStripMenuItem.Text = "Thoát";
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageProductToolStripMenuItem, newProductToolStripMenuItem, khối8ToolStripMenuItem, khối9ToolStripMenuItem });
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(63, 29);
            productToolStripMenuItem.Text = "Khối";
            // 
            // manageProductToolStripMenuItem
            // 
            manageProductToolStripMenuItem.Name = "manageProductToolStripMenuItem";
            manageProductToolStripMenuItem.Size = new Size(164, 34);
            manageProductToolStripMenuItem.Text = "Khối 6";
            // 
            // newProductToolStripMenuItem
            // 
            newProductToolStripMenuItem.Name = "newProductToolStripMenuItem";
            newProductToolStripMenuItem.Size = new Size(164, 34);
            newProductToolStripMenuItem.Text = "Khối 7";
            // 
            // khối8ToolStripMenuItem
            // 
            khối8ToolStripMenuItem.Name = "khối8ToolStripMenuItem";
            khối8ToolStripMenuItem.Size = new Size(164, 34);
            khối8ToolStripMenuItem.Text = "Khối 8";
            // 
            // khối9ToolStripMenuItem
            // 
            khối9ToolStripMenuItem.Name = "khối9ToolStripMenuItem";
            khối9ToolStripMenuItem.Size = new Size(164, 34);
            khối9ToolStripMenuItem.Text = "Khối 9";
            // 
            // btnThemMoi
            // 
            btnThemMoi.Location = new Point(26, 113);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(148, 51);
            btnThemMoi.TabIndex = 6;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = true;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(232, 131);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(360, 33);
            comboBox1.TabIndex = 7;
            // 
            // TrangChuQuanLy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1732, 661);
            Controls.Add(comboBox1);
            Controls.Add(btnThemMoi);
            Controls.Add(menuStrip1);
            Controls.Add(dataGridView1);
            Name = "TrangChuQuanLy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrangChuQuanLy";
            Load += TrangChuQuanLy_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem manageCategoryToolStripMenuItem;
        private ToolStripMenuItem newCategoryToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem manageProductToolStripMenuItem;
        private ToolStripMenuItem newProductToolStripMenuItem;
        private ToolStripMenuItem khối8ToolStripMenuItem;
        private ToolStripMenuItem khối9ToolStripMenuItem;
        private Button btnThemMoi;
        private ComboBox comboBox1;
        private DataGridViewTextBoxColumn MaHS;
        private DataGridViewTextBoxColumn HoTenHS;
        private DataGridViewTextBoxColumn NgSinh;
        private DataGridViewTextBoxColumn GioiTinh;
        private DataGridViewTextBoxColumn DanToc;
        private DataGridViewTextBoxColumn NoiSinh;
        private DataGridViewTextBoxColumn TenLop;
        private DataGridViewTextBoxColumn NamHoc;
        private DataGridViewButtonColumn chinhSuaColumn;
        private DataGridViewButtonColumn xemDiemColumn;
        private DataGridViewButtonColumn XoaColumn;
    }
}