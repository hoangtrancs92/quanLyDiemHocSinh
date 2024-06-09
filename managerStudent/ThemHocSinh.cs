using managerStudent.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace managerStudent
{
    public partial class ThemHocSinh : Form
    {
        bool isDataValid = true;
        public ThemHocSinh()
        {
            InitializeComponent();

            // btnLuu
            btnLuu.BackColor = Color.FromArgb(45, 152, 218);
            btnLuu.ForeColor = Color.White;
            btnLuu.Font = new Font("Arial", 10, FontStyle.Bold);
            btnLuu.FlatAppearance.BorderSize = 0;

            btnLuu.MouseEnter += new EventHandler(btnLuu_MouseEnter);
            btnLuu.MouseLeave += new EventHandler(btnLuu_MouseLeave);
            btnLuu.MouseDown += new MouseEventHandler(btnLuu_MouseDown);
            btnLuu.MouseUp += new MouseEventHandler(btnLuu_MouseUp);
            btnLuu.Paint += new PaintEventHandler(btnLuu_Paint);

            // btnDong
            btnDong.BackColor = Color.FromArgb(231, 76, 60);
            btnDong.ForeColor = Color.White;
            btnDong.Font = new Font("Arial", 10, FontStyle.Bold);
            btnDong.FlatAppearance.BorderSize = 0;

            btnDong.MouseEnter += new EventHandler(btnDong_MouseEnter);
            btnDong.MouseLeave += new EventHandler(btnDong_MouseLeave);
            btnDong.MouseDown += new MouseEventHandler(btnDong_MouseDown);
            btnDong.MouseUp += new MouseEventHandler(btnDong_MouseUp);
            btnDong.Paint += new PaintEventHandler(btnDong_Paint);

            rdNam.Checked = true;

            LoadKhois();
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void ThemHocSinh_Load(object sender, EventArgs e)
        {

        }
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Ngăn chặn việc đóng form khi form được đóng từ bên ngoài
            e.Cancel = true;
            this.Hide();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (var context = new EFDbContext())
            {
                const string PASSWORD = "123456";
                var gioiTinh = rdNam.Checked ? "Nam" : "Nữ";
                var maxMaHS = context.HocSinhs
                     .OrderByDescending(h => h.MaHS)
                     .Select(h => h.MaHS)
                     .FirstOrDefault();
                var numberPart = int.Parse(maxMaHS.Substring(2));
                // Tăng giá trị số lên 1
                numberPart++;
                int numberLength = maxMaHS.Length - 2;
                // Định dạng lại MaHS
                var maHocSinhMoi = "MS" + numberPart.ToString(new string('0', numberLength)); ;
                var hocSinh = new HocSinh
                {
                    MaHS = maHocSinhMoi,
                    MatKhau = HocSinh.HashPassword(PASSWORD),
                    HoTenHS = txtTen.Text,
                    NgSinh = dtNamSinh.Value,
                    GioiTinh = gioiTinh,
                    NoiSinh = txtDiaChi.Text,
                    DanToc = txtDanToc.Text,
                    MaLop = (int)cbbLop.SelectedValue
                };
                int rowsAffected = 0;
                // Kiểm tra xem các trường dữ liệu đã được nhập đủ không
                if (string.IsNullOrWhiteSpace(txtTen.Text) ||
                    string.IsNullOrWhiteSpace(txtDiaChi.Text) ||
                    string.IsNullOrWhiteSpace(txtDanToc.Text))
                {
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin trước khi lưu.");
                    return; // Ngăn thực hiện hành động lưu nếu có trường dữ liệu không hợp lệ
                }

                context.HocSinhs.Add(hocSinh);
                rowsAffected = context.SaveChanges();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Lưu học sinh thành công!");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lưu học sinh không thành công. Vui lòng thử lại!");
                }
            }

        }

        private void btnLuu_MouseEnter(object sender, EventArgs e)
        {
            //btnLuu.BackColor = Color.FromArgb(75, 123, 236);
            btnLuu.BackColor = Color.White;
            btnLuu.ForeColor = Color.FromArgb(45, 152, 218);
        }

        private void btnLuu_MouseLeave(object sender, EventArgs e)
        {
            btnLuu.BackColor = Color.FromArgb(45, 152, 218);
            btnLuu.ForeColor = Color.White;
        }

        private void btnLuu_MouseDown(object sender, MouseEventArgs e)
        {
            btnLuu.BackColor = Color.RoyalBlue;
        }

        private void btnLuu_MouseUp(object sender, MouseEventArgs e)
        {
            btnLuu.BackColor = Color.FromArgb(45, 152, 218);
        }

        private void btnLuu_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            GraphicsPath path = new GraphicsPath();
            int radius = 20; // Bán kính góc
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            btn.Region = new Region(path);

            // Hiệu ứng bóng đổ
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(1, 1, btn.Width - 4, btn.Height - 4);
        }

        private void btnDong_MouseEnter(object sender, EventArgs e)
        {
            //btnDong.BackColor = Color.FromArgb(75, 123, 236);
            btnDong.BackColor = Color.White;
            btnDong.ForeColor = Color.FromArgb(231, 76, 60);
        }

        private void btnDong_MouseLeave(object sender, EventArgs e)
        {
            btnDong.BackColor = Color.FromArgb(231, 76, 60);
            btnDong.ForeColor = Color.White;
        }

        private void btnDong_MouseDown(object sender, MouseEventArgs e)
        {
            btnDong.BackColor = Color.FromArgb(231, 76, 60);
        }

        private void btnDong_MouseUp(object sender, MouseEventArgs e)
        {
            btnDong.BackColor = Color.FromArgb(45, 152, 218);
        }

        private void btnDong_Paint(object sender, PaintEventArgs e)
        {
            Button btn = sender as Button;
            GraphicsPath path = new GraphicsPath();
            int radius = 20; // Bán kính góc
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(btn.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(btn.Width - radius, btn.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, btn.Height - radius, radius, radius, 90, 90);
            path.CloseAllFigures();
            btn.Region = new Region(path);

            // Hiệu ứng bóng đổ
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle rect = new Rectangle(1, 1, btn.Width - 4, btn.Height - 4);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectKhoi = comboBox1.SelectedItem as Khoi;
            var maKhoi = selectKhoi.MaKhoi;
            using (var context = new EFDbContext())
            {
                var classesByKhoi = context.Lops
                                           .Include(l => l.Khoi) // Include Khoi for navigation property
                                           .Where(l => l.MaKhoi == maKhoi)
                                           .ToList();

                cbbLop.DataSource = classesByKhoi;
                cbbLop.DisplayMember = "TenLop";
                cbbLop.ValueMember = "MaLop";
            }
        }

        private void LoadKhois()
        {
            using (var context = new EFDbContext())
            {
                var khoi = context.Khois.ToList();
                comboBox1.DataSource = khoi;
                comboBox1.DisplayMember = "TenKhoi";
                comboBox1.ValueMember = "MaKhoi";
            }
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTen.Text))
            {
                toolTip1.Show("Vui lòng nhập tên học sinh", txtTen);
                isDataValid = false;
            }
        }

        private void txtDanToc_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDanToc.Text))
            {
                toolTip1.Show("Vui lòng nhập dân tộc", txtDanToc);
                isDataValid = false;
            }
        }
    }
}
