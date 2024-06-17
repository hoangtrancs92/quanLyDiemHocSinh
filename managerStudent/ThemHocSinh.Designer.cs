namespace managerStudent
{
    partial class ThemHocSinh
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
            components = new System.ComponentModel.Container();
            btnDong = new Button();
            btnLuu = new Button();
            dtNamSinh = new DateTimePicker();
            txtDiaChi = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtTen = new TextBox();
            label1 = new Label();
            rdNam = new RadioButton();
            rdNu = new RadioButton();
            comboBox1 = new ComboBox();
            cbbLop = new ComboBox();
            label5 = new Label();
            txtDanToc = new TextBox();
            label6 = new Label();
            label7 = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // btnDong
            // 
            btnDong.Cursor = Cursors.Hand;
            btnDong.Location = new Point(587, 416);
            btnDong.Name = "btnDong";
            btnDong.Size = new Size(256, 47);
            btnDong.TabIndex = 22;
            btnDong.Text = "Đóng";
            btnDong.UseVisualStyleBackColor = true;
            btnDong.Click += btClose_Click;
            // 
            // btnLuu
            // 
            btnLuu.Cursor = Cursors.Hand;
            btnLuu.Location = new Point(240, 416);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(269, 47);
            btnLuu.TabIndex = 20;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // dtNamSinh
            // 
            dtNamSinh.CustomFormat = "dd/MM/yyyy";
            dtNamSinh.Format = DateTimePickerFormat.Custom;
            dtNamSinh.Location = new Point(197, 180);
            dtNamSinh.Name = "dtNamSinh";
            dtNamSinh.Size = new Size(279, 31);
            dtNamSinh.TabIndex = 19;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(197, 360);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(818, 31);
            txtDiaChi.TabIndex = 14;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(44, 180);
            label4.Name = "label4";
            label4.Size = new Size(87, 25);
            label4.TabIndex = 17;
            label4.Text = "Năm sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 249);
            label3.Name = "label3";
            label3.Size = new Size(47, 25);
            label3.TabIndex = 15;
            label3.Text = "Khối";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(44, 363);
            label2.Name = "label2";
            label2.Size = new Size(65, 25);
            label2.TabIndex = 13;
            label2.Text = "Địa chỉ";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(197, 80);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(511, 31);
            txtTen.TabIndex = 9;
            txtTen.TextChanged += txtTen_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(44, 83);
            label1.Name = "label1";
            label1.Size = new Size(109, 25);
            label1.TabIndex = 10;
            label1.Text = "Tên học sinh";
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Location = new Point(743, 80);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(75, 29);
            rdNam.TabIndex = 23;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new Point(890, 79);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(61, 29);
            rdNu.TabIndex = 24;
            rdNu.TabStop = true;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(197, 241);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 25;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // cbbLop
            // 
            cbbLop.FormattingEnabled = true;
            cbbLop.Location = new Point(197, 300);
            cbbLop.Name = "cbbLop";
            cbbLop.Size = new Size(182, 33);
            cbbLop.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(44, 304);
            label5.Name = "label5";
            label5.Size = new Size(42, 25);
            label5.TabIndex = 26;
            label5.Text = "Lớp";
            // 
            // txtDanToc
            // 
            txtDanToc.Location = new Point(197, 130);
            txtDanToc.Name = "txtDanToc";
            txtDanToc.Size = new Size(150, 31);
            txtDanToc.TabIndex = 28;
            txtDanToc.Validating += txtDanToc_Validating;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 136);
            label6.Name = "label6";
            label6.Size = new Size(74, 25);
            label6.TabIndex = 29;
            label6.Text = "Dân tộc";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkCyan;
            label7.Location = new Point(392, 18);
            label7.Name = "label7";
            label7.Size = new Size(321, 45);
            label7.TabIndex = 30;
            label7.Text = "Thêm/Sửa học sinh";
            // 
            // ThemHocSinh
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 475);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(txtDanToc);
            Controls.Add(cbbLop);
            Controls.Add(label5);
            Controls.Add(comboBox1);
            Controls.Add(rdNu);
            Controls.Add(rdNam);
            Controls.Add(btnDong);
            Controls.Add(btnLuu);
            Controls.Add(dtNamSinh);
            Controls.Add(txtDiaChi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtTen);
            Controls.Add(label1);
            Name = "ThemHocSinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ThemHocSinh";
            Load += ThemHocSinh_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDong;
        private Button btnLuu;
        private DateTimePicker dtNamSinh;
        private TextBox txtDiaChi;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtTen;
        private Label label1;
        private RadioButton rdNam;
        private RadioButton rdNu;
        private ComboBox comboBox1;
        private ComboBox cbbLop;
        private Label label5;
        private TextBox txtDanToc;
        private Label label6;
        private Label label7;
        private ToolTip toolTip1;
    }
}