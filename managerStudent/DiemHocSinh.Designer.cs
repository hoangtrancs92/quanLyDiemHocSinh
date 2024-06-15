namespace managerStudent
{
    partial class DiemHocSinh
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
            dataGridViewMonHoc = new DataGridView();
            MaMon = new DataGridViewTextBoxColumn();
            TenMH = new DataGridViewTextBoxColumn();
            DiemGKHK1 = new DataGridViewTextBoxColumn();
            DiemCKHK1 = new DataGridViewTextBoxColumn();
            DiemGKHK2 = new DataGridViewTextBoxColumn();
            DiemCKHK2 = new DataGridViewTextBoxColumn();
            NamHoc = new DataGridViewTextBoxColumn();
            ChinhSuaDiem = new DataGridViewButtonColumn();
            XoaDiemColumn = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            txtMaHS = new Label();
            txtTen = new Label();
            txtLop = new Label();
            label4 = new Label();
            label5 = new Label();
            label7 = new Label();
            label9 = new Label();
            label10 = new Label();
            label6 = new Label();
            lbGiuaKi = new Label();
            lbHK2 = new Label();
            lbHK1 = new Label();
            lbCuoiKi = new Label();
            btnThem = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMonHoc).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewMonHoc
            // 
            dataGridViewMonHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMonHoc.Columns.AddRange(new DataGridViewColumn[] { MaMon, TenMH, DiemGKHK1, DiemCKHK1, DiemGKHK2, DiemCKHK2, NamHoc, ChinhSuaDiem, XoaDiemColumn });
            dataGridViewMonHoc.Location = new Point(50, 150);
            dataGridViewMonHoc.Name = "dataGridViewMonHoc";
            dataGridViewMonHoc.RowHeadersWidth = 62;
            dataGridViewMonHoc.Size = new Size(1416, 374);
            dataGridViewMonHoc.TabIndex = 0;
            dataGridViewMonHoc.CellClick += dataGridViewMonHoc_CellClick;
            dataGridViewMonHoc.CellContentClick += dataGridViewMonHoc_CellContentClick;
            // 
            // MaMon
            // 
            MaMon.DataPropertyName = "MaMon";
            MaMon.HeaderText = "Mã Môn";
            MaMon.MinimumWidth = 8;
            MaMon.Name = "MaMon";
            MaMon.Width = 150;
            // 
            // TenMH
            // 
            TenMH.DataPropertyName = "TenMH";
            TenMH.HeaderText = "Tên Môn học";
            TenMH.MinimumWidth = 8;
            TenMH.Name = "TenMH";
            TenMH.Width = 150;
            // 
            // DiemGKHK1
            // 
            DiemGKHK1.DataPropertyName = "DiemGKHK1";
            DiemGKHK1.HeaderText = "Giữa kì 1";
            DiemGKHK1.MinimumWidth = 8;
            DiemGKHK1.Name = "DiemGKHK1";
            DiemGKHK1.Width = 150;
            // 
            // DiemCKHK1
            // 
            DiemCKHK1.DataPropertyName = "DiemCKHK1";
            DiemCKHK1.HeaderText = "Cuối kì 1";
            DiemCKHK1.MinimumWidth = 8;
            DiemCKHK1.Name = "DiemCKHK1";
            DiemCKHK1.Width = 150;
            // 
            // DiemGKHK2
            // 
            DiemGKHK2.DataPropertyName = "DiemGKHK2";
            DiemGKHK2.HeaderText = "Giữa kì 2";
            DiemGKHK2.MinimumWidth = 8;
            DiemGKHK2.Name = "DiemGKHK2";
            DiemGKHK2.Width = 150;
            // 
            // DiemCKHK2
            // 
            DiemCKHK2.DataPropertyName = "DiemCKHK2";
            DiemCKHK2.HeaderText = "Cuối kì 2";
            DiemCKHK2.MinimumWidth = 8;
            DiemCKHK2.Name = "DiemCKHK2";
            DiemCKHK2.Width = 150;
            // 
            // NamHoc
            // 
            NamHoc.DataPropertyName = "NamHoc";
            NamHoc.HeaderText = "Năm Học";
            NamHoc.MinimumWidth = 8;
            NamHoc.Name = "NamHoc";
            NamHoc.Width = 150;
            // 
            // ChinhSuaDiem
            // 
            ChinhSuaDiem.HeaderText = "Chỉnh sửa";
            ChinhSuaDiem.MinimumWidth = 8;
            ChinhSuaDiem.Name = "ChinhSuaDiem";
            ChinhSuaDiem.Resizable = DataGridViewTriState.True;
            ChinhSuaDiem.SortMode = DataGridViewColumnSortMode.Automatic;
            ChinhSuaDiem.Width = 150;
            // 
            // XoaDiemColumn
            // 
            XoaDiemColumn.HeaderText = "Xóa điểm";
            XoaDiemColumn.MinimumWidth = 8;
            XoaDiemColumn.Name = "XoaDiemColumn";
            XoaDiemColumn.Resizable = DataGridViewTriState.True;
            XoaDiemColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            XoaDiemColumn.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 69);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 1;
            label1.Text = "Tên: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 27);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 2;
            label2.Text = "Mã học sinh: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1216, 98);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 31);
            textBox1.TabIndex = 3;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(830, 98);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(270, 33);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 104);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 5;
            label3.Text = "Lớp: ";
            // 
            // txtMaHS
            // 
            txtMaHS.AutoSize = true;
            txtMaHS.Location = new Point(181, 29);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(59, 25);
            txtMaHS.TabIndex = 6;
            txtMaHS.Text = "label4";
            // 
            // txtTen
            // 
            txtTen.AutoSize = true;
            txtTen.Location = new Point(103, 69);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(59, 25);
            txtTen.TabIndex = 7;
            txtTen.Text = "label4";
            // 
            // txtLop
            // 
            txtLop.AutoSize = true;
            txtLop.Location = new Point(103, 107);
            txtLop.Name = "txtLop";
            txtLop.Size = new Size(59, 25);
            txtLop.TabIndex = 8;
            txtLop.Text = "label4";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1126, 101);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 10;
            label4.Text = "Tìm kiếm";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Highlight;
            label5.Location = new Point(50, 557);
            label5.Name = "label5";
            label5.Size = new Size(65, 36);
            label5.TabIndex = 11;
            label5.Text = "Tỉ lệ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(50, 608);
            label7.Name = "label7";
            label7.Size = new Size(79, 30);
            label7.TabIndex = 13;
            label7.Text = "Giữa kì";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.Location = new Point(52, 656);
            label9.Name = "label9";
            label9.Size = new Size(79, 30);
            label9.TabIndex = 14;
            label9.Text = "Cuối kì";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(52, 708);
            label10.Name = "label10";
            label10.Size = new Size(92, 30);
            label10.TabIndex = 15;
            label10.Text = "Học kì 1";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(52, 764);
            label6.Name = "label6";
            label6.Size = new Size(92, 30);
            label6.TabIndex = 16;
            label6.Text = "Học kì 2";
            // 
            // lbGiuaKi
            // 
            lbGiuaKi.AutoSize = true;
            lbGiuaKi.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbGiuaKi.ForeColor = Color.ForestGreen;
            lbGiuaKi.Location = new Point(181, 608);
            lbGiuaKi.Name = "lbGiuaKi";
            lbGiuaKi.Size = new Size(0, 30);
            lbGiuaKi.TabIndex = 17;
            // 
            // lbHK2
            // 
            lbHK2.AutoSize = true;
            lbHK2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHK2.ForeColor = Color.Crimson;
            lbHK2.Location = new Point(181, 764);
            lbHK2.Name = "lbHK2";
            lbHK2.Size = new Size(0, 30);
            lbHK2.TabIndex = 18;
            // 
            // lbHK1
            // 
            lbHK1.AutoSize = true;
            lbHK1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHK1.ForeColor = Color.Crimson;
            lbHK1.Location = new Point(181, 708);
            lbHK1.Name = "lbHK1";
            lbHK1.Size = new Size(0, 30);
            lbHK1.TabIndex = 19;
            // 
            // lbCuoiKi
            // 
            lbCuoiKi.AutoSize = true;
            lbCuoiKi.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCuoiKi.ForeColor = Color.ForestGreen;
            lbCuoiKi.Location = new Point(181, 656);
            lbCuoiKi.Name = "lbCuoiKi";
            lbCuoiKi.Size = new Size(0, 30);
            lbCuoiKi.TabIndex = 20;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(682, 99);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 21;
            btnThem.Text = "Thêm mới";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // DiemHocSinh
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1509, 908);
            Controls.Add(btnThem);
            Controls.Add(lbCuoiKi);
            Controls.Add(lbHK1);
            Controls.Add(lbHK2);
            Controls.Add(lbGiuaKi);
            Controls.Add(label6);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(txtLop);
            Controls.Add(txtTen);
            Controls.Add(txtMaHS);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewMonHoc);
            MaximizeBox = false;
            Name = "DiemHocSinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DiemHocSinh";
            Load += DiemHocSinh_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMonHoc).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewMonHoc;
        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label3;
        private Label txtMaHS;
        private Label txtTen;
        private Label txtLop;
        private Label label4;
        private DataGridViewButtonColumn ThemDiemColumn;
        private DataGridViewButtonColumn ChiTiet;
        private Label label5;
        private Label label7;
        private Label label9;
        private Label label10;
        private Label label6;
        private Label lbGiuaKi;
        private Label lbHK2;
        private Label lbHK1;
        private Label lbCuoiKi;
        private DataGridViewTextBoxColumn MaMon;
        private DataGridViewTextBoxColumn TenMH;
        private DataGridViewTextBoxColumn DiemGKHK1;
        private DataGridViewTextBoxColumn DiemCKHK1;
        private DataGridViewTextBoxColumn DiemGKHK2;
        private DataGridViewTextBoxColumn DiemCKHK2;
        private DataGridViewTextBoxColumn NamHoc;
        private DataGridViewButtonColumn ChinhSuaDiem;
        private DataGridViewButtonColumn XoaDiemColumn;
        private Button btnThem;
    }
}