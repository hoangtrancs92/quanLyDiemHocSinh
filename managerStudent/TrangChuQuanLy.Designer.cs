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
            newCategoryToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            btnThemMoi = new Button();
            comboBox1 = new ComboBox();
            txtTen = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            cbbLop = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            txtMaHS = new TextBox();
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
            dataGridView1.Location = new Point(35, 228);
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { categoryToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1732, 33);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newCategoryToolStripMenuItem, thoátToolStripMenuItem });
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(69, 29);
            categoryToolStripMenuItem.Text = "Tổng";
            // 
            // newCategoryToolStripMenuItem
            // 
            newCategoryToolStripMenuItem.Name = "newCategoryToolStripMenuItem";
            newCategoryToolStripMenuItem.Size = new Size(270, 34);
            newCategoryToolStripMenuItem.Text = "Đăng xuất";
            newCategoryToolStripMenuItem.Click += newCategoryToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(270, 34);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // btnThemMoi
            // 
            btnThemMoi.Location = new Point(35, 131);
            btnThemMoi.Name = "btnThemMoi";
            btnThemMoi.Size = new Size(139, 33);
            btnThemMoi.TabIndex = 6;
            btnThemMoi.Text = "Thêm mới";
            btnThemMoi.UseVisualStyleBackColor = true;
            btnThemMoi.Click += btnThemMoi_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1182, 174);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(125, 33);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(1182, 114);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(387, 31);
            txtTen.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(1596, 174);
            button1.Name = "button1";
            button1.Size = new Size(124, 34);
            button1.TabIndex = 9;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1049, 117);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 10;
            label1.Text = "Tên học sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(1049, 179);
            label2.Name = "label2";
            label2.Size = new Size(47, 25);
            label2.TabIndex = 11;
            label2.Text = "Khối";
            // 
            // cbbLop
            // 
            cbbLop.FormattingEnabled = true;
            cbbLop.Location = new Point(1444, 174);
            cbbLop.Name = "cbbLop";
            cbbLop.Size = new Size(125, 33);
            cbbLop.TabIndex = 12;
            cbbLop.SelectedIndexChanged += cbbLop_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(1375, 182);
            label3.Name = "label3";
            label3.Size = new Size(42, 25);
            label3.TabIndex = 13;
            label3.Text = "Lớp";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1049, 65);
            label4.Name = "label4";
            label4.Size = new Size(108, 25);
            label4.TabIndex = 14;
            label4.Text = "Mã học sinh";
            // 
            // txtMaHS
            // 
            txtMaHS.Location = new Point(1182, 65);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(387, 31);
            txtMaHS.TabIndex = 15;
            // 
            // TrangChuQuanLy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1732, 661);
            Controls.Add(txtMaHS);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cbbLop);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(txtTen);
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
        private ToolStripMenuItem newCategoryToolStripMenuItem;
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
        private TextBox txtTen;
        private Button button1;
        private Label label1;
        private Label label2;
        private ComboBox cbbLop;
        private Label label3;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private Label label4;
        private TextBox txtMaHS;
    }
}