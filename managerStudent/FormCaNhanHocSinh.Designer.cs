namespace managerStudent
{
    partial class FormCaNhanHocSinh
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
            label4 = new Label();
            txtLop = new Label();
            txtTen = new Label();
            txtMaHS = new Label();
            label3 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            dataGridViewMonHoc = new DataGridView();
            MaMon = new DataGridViewTextBoxColumn();
            TenMH = new DataGridViewTextBoxColumn();
            DiemGKHK1 = new DataGridViewTextBoxColumn();
            DiemCKHK1 = new DataGridViewTextBoxColumn();
            DiemGKHK2 = new DataGridViewTextBoxColumn();
            DiemCKHK2 = new DataGridViewTextBoxColumn();
            NamHoc = new DataGridViewTextBoxColumn();
            DTB = new DataGridViewTextBoxColumn();
            XepLoai = new DataGridViewTextBoxColumn();
            lbCuoiKi = new Label();
            lbHK1 = new Label();
            lbHK2 = new Label();
            lbGiuaKi = new Label();
            label8 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            menuStrip1 = new MenuStrip();
            tooToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            thoátToolStripMenuItem = new ToolStripMenuItem();
            lbXepLoaiTong = new Label();
            lbDiemTBTong = new Label();
            label7 = new Label();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMonHoc).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(939, 121);
            label4.Name = "label4";
            label4.Size = new Size(84, 25);
            label4.TabIndex = 31;
            label4.Text = "Năm học";
            // 
            // txtLop
            // 
            txtLop.AutoSize = true;
            txtLop.Location = new Point(65, 123);
            txtLop.Name = "txtLop";
            txtLop.Size = new Size(59, 25);
            txtLop.TabIndex = 30;
            txtLop.Text = "label4";
            // 
            // txtTen
            // 
            txtTen.AutoSize = true;
            txtTen.Location = new Point(65, 85);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(59, 25);
            txtTen.TabIndex = 29;
            txtTen.Text = "label4";
            // 
            // txtMaHS
            // 
            txtMaHS.AutoSize = true;
            txtMaHS.Location = new Point(143, 45);
            txtMaHS.Name = "txtMaHS";
            txtMaHS.Size = new Size(59, 25);
            txtMaHS.TabIndex = 28;
            txtMaHS.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 120);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 27;
            label3.Text = "Lớp: ";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1065, 58);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(219, 33);
            comboBox1.TabIndex = 26;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(1065, 118);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(86, 31);
            textBox1.TabIndex = 25;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 43);
            label2.Name = "label2";
            label2.Size = new Size(117, 25);
            label2.TabIndex = 24;
            label2.Text = "Mã học sinh: ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 85);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 23;
            label1.Text = "Tên: ";
            // 
            // dataGridViewMonHoc
            // 
            dataGridViewMonHoc.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMonHoc.Columns.AddRange(new DataGridViewColumn[] { MaMon, TenMH, DiemGKHK1, DiemCKHK1, DiemGKHK2, DiemCKHK2, NamHoc, DTB, XepLoai });
            dataGridViewMonHoc.Location = new Point(12, 166);
            dataGridViewMonHoc.Name = "dataGridViewMonHoc";
            dataGridViewMonHoc.RowHeadersWidth = 62;
            dataGridViewMonHoc.Size = new Size(1414, 374);
            dataGridViewMonHoc.TabIndex = 22;
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
            // DTB
            // 
            DTB.DataPropertyName = "DTB";
            DTB.HeaderText = "DTB";
            DTB.MinimumWidth = 8;
            DTB.Name = "DTB";
            DTB.Width = 150;
            // 
            // XepLoai
            // 
            XepLoai.DataPropertyName = "XepLoai";
            XepLoai.HeaderText = "Xếp loại";
            XepLoai.MinimumWidth = 8;
            XepLoai.Name = "XepLoai";
            XepLoai.Width = 150;
            // 
            // lbCuoiKi
            // 
            lbCuoiKi.AutoSize = true;
            lbCuoiKi.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbCuoiKi.ForeColor = Color.ForestGreen;
            lbCuoiKi.Location = new Point(141, 679);
            lbCuoiKi.Name = "lbCuoiKi";
            lbCuoiKi.Size = new Size(0, 30);
            lbCuoiKi.TabIndex = 45;
            // 
            // lbHK1
            // 
            lbHK1.AutoSize = true;
            lbHK1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHK1.ForeColor = Color.Crimson;
            lbHK1.Location = new Point(141, 731);
            lbHK1.Name = "lbHK1";
            lbHK1.Size = new Size(0, 30);
            lbHK1.TabIndex = 44;
            // 
            // lbHK2
            // 
            lbHK2.AutoSize = true;
            lbHK2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHK2.ForeColor = Color.Crimson;
            lbHK2.Location = new Point(141, 787);
            lbHK2.Name = "lbHK2";
            lbHK2.Size = new Size(0, 30);
            lbHK2.TabIndex = 43;
            // 
            // lbGiuaKi
            // 
            lbGiuaKi.AutoSize = true;
            lbGiuaKi.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbGiuaKi.ForeColor = Color.ForestGreen;
            lbGiuaKi.Location = new Point(141, 631);
            lbGiuaKi.Name = "lbGiuaKi";
            lbGiuaKi.Size = new Size(0, 30);
            lbGiuaKi.TabIndex = 42;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(12, 787);
            label8.Name = "label8";
            label8.Size = new Size(92, 30);
            label8.TabIndex = 41;
            label8.Text = "Học kì 2";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(12, 731);
            label11.Name = "label11";
            label11.Size = new Size(92, 30);
            label11.TabIndex = 40;
            label11.Text = "Học kì 1";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(12, 679);
            label12.Name = "label12";
            label12.Size = new Size(79, 30);
            label12.TabIndex = 39;
            label12.Text = "Cuối kì";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label13.Location = new Point(10, 631);
            label13.Name = "label13";
            label13.Size = new Size(79, 30);
            label13.TabIndex = 38;
            label13.Text = "Giữa kì";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 13F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label14.ForeColor = SystemColors.Highlight;
            label14.Location = new Point(10, 580);
            label14.Name = "label14";
            label14.Size = new Size(65, 36);
            label14.TabIndex = 37;
            label14.Text = "Tỉ lệ";
            // 
            // button1
            // 
            button1.Location = new Point(1314, 118);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 46;
            button1.Text = "Tìm kiếm";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1198, 118);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(86, 31);
            textBox2.TabIndex = 47;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(939, 61);
            label5.Name = "label5";
            label5.Size = new Size(83, 25);
            label5.TabIndex = 48;
            label5.Text = "Môn học";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(1167, 121);
            label6.Name = "label6";
            label6.Size = new Size(19, 25);
            label6.TabIndex = 49;
            label6.Text = "-";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { tooToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1440, 33);
            menuStrip1.TabIndex = 50;
            menuStrip1.Text = "menuStrip1";
            // 
            // tooToolStripMenuItem
            // 
            tooToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { đăngXuấtToolStripMenuItem, thoátToolStripMenuItem });
            tooToolStripMenuItem.Name = "tooToolStripMenuItem";
            tooToolStripMenuItem.Size = new Size(110, 29);
            tooToolStripMenuItem.Text = "Tổng quát";
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(195, 34);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // thoátToolStripMenuItem
            // 
            thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            thoátToolStripMenuItem.Size = new Size(195, 34);
            thoátToolStripMenuItem.Text = "Thoát";
            thoátToolStripMenuItem.Click += thoátToolStripMenuItem_Click;
            // 
            // lbXepLoaiTong
            // 
            lbXepLoaiTong.AutoSize = true;
            lbXepLoaiTong.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            lbXepLoaiTong.Location = new Point(607, 732);
            lbXepLoaiTong.Name = "lbXepLoaiTong";
            lbXepLoaiTong.Size = new Size(56, 25);
            lbXepLoaiTong.TabIndex = 58;
            lbXepLoaiTong.Text = "label";
            // 
            // lbDiemTBTong
            // 
            lbDiemTBTong.AutoSize = true;
            lbDiemTBTong.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold);
            lbDiemTBTong.Location = new Point(607, 678);
            lbDiemTBTong.Name = "lbDiemTBTong";
            lbDiemTBTong.Size = new Size(56, 25);
            lbDiemTBTong.TabIndex = 57;
            lbDiemTBTong.Text = "label";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(361, 732);
            label7.Name = "label7";
            label7.Size = new Size(132, 25);
            label7.TabIndex = 56;
            label7.Text = "Xep loại tổng";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(358, 679);
            label9.Name = "label9";
            label9.Size = new Size(206, 25);
            label9.TabIndex = 55;
            label9.Text = "Điểm trung bình tổng";
            // 
            // FormCaNhanHocSinh
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1440, 889);
            Controls.Add(lbXepLoaiTong);
            Controls.Add(lbDiemTBTong);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(lbCuoiKi);
            Controls.Add(lbHK1);
            Controls.Add(lbHK2);
            Controls.Add(lbGiuaKi);
            Controls.Add(label8);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label14);
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
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormCaNhanHocSinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCaNhanHocSinh";
            Load += FormCaNhanHocSinh_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewMonHoc).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label txtLop;
        private Label txtTen;
        private Label txtMaHS;
        private Label label3;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private DataGridView dataGridViewMonHoc;
        private Label lbCuoiKi;
        private Label lbHK1;
        private Label lbHK2;
        private Label lbGiuaKi;
        private Label label8;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private DataGridViewTextBoxColumn MaMon;
        private DataGridViewTextBoxColumn TenMH;
        private DataGridViewTextBoxColumn DiemGKHK1;
        private DataGridViewTextBoxColumn DiemCKHK1;
        private DataGridViewTextBoxColumn DiemGKHK2;
        private DataGridViewTextBoxColumn DiemCKHK2;
        private DataGridViewTextBoxColumn NamHoc;
        private DataGridViewTextBoxColumn DTB;
        private DataGridViewTextBoxColumn XepLoai;
        private Button button1;
        private TextBox textBox2;
        private Label label5;
        private Label label6;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem tooToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem thoátToolStripMenuItem;
        private Label lbXepLoaiTong;
        private Label lbDiemTBTong;
        private Label label7;
        private Label label9;
    }
}