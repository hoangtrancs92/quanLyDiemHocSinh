namespace managerStudent
{
    partial class FormDangNhap
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
            label1 = new Label();
            textBox1 = new TextBox();
            txtPassword = new TextBox();
            label2 = new Label();
            label3 = new Label();
            txtDangNhap = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Black", 13F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(243, 36);
            label1.Name = "label1";
            label1.Size = new Size(278, 38);
            label1.TabIndex = 0;
            label1.Text = "Quản lý học sinh";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(211, 105);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(310, 38);
            textBox1.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(211, 172);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(310, 34);
            txtPassword.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(49, 108);
            label2.Name = "label2";
            label2.Size = new Size(148, 38);
            label2.TabIndex = 3;
            label2.Text = "Tên đăng nhập";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 175);
            label3.Name = "label3";
            label3.Size = new Size(86, 25);
            label3.TabIndex = 4;
            label3.Text = "Mật khẩu";
            // 
            // txtDangNhap
            // 
            txtDangNhap.BackColor = Color.MintCream;
            txtDangNhap.Cursor = Cursors.Hand;
            txtDangNhap.Location = new Point(271, 235);
            txtDangNhap.Name = "txtDangNhap";
            txtDangNhap.Size = new Size(145, 45);
            txtDangNhap.TabIndex = 5;
            txtDangNhap.Text = "Đăng nhập";
            txtDangNhap.UseVisualStyleBackColor = false;
            txtDangNhap.Click += txtDangNhap_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormDangNhap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(692, 325);
            Controls.Add(pictureBox1);
            Controls.Add(txtDangNhap);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtPassword);
            Controls.Add(textBox1);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "FormDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cổng thông tin VAA";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox txtPassword;
        private Label label2;
        private Label label3;
        private Button txtDangNhap;
        private PictureBox pictureBox1;
    }
}
