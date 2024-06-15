using managerStudent.Helpers;
using System.Net.WebSockets;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace managerStudent
{
    public partial class FormDangNhap : Form
    {
        private readonly EFDbContext _context;

        public FormDangNhap()
        {
            InitializeComponent();

            this.SuspendLayout();

            // txtDangNhap
            txtDangNhap.BackColor = Color.FromArgb(45, 152, 218);
            txtDangNhap.ForeColor = Color.White ;
            txtDangNhap.Font = new Font("Arial", 10, FontStyle.Bold);
            txtDangNhap.FlatAppearance.BorderSize = 0;

            txtDangNhap.MouseEnter += new EventHandler(txtDangNhap_MouseEnter);
            txtDangNhap.MouseLeave += new EventHandler(txtDangNhap_MouseLeave);
            txtDangNhap.MouseDown += new MouseEventHandler(txtDangNhap_MouseDown);
            txtDangNhap.MouseUp += new MouseEventHandler(txtDangNhap_MouseUp);
            txtDangNhap.Paint += new PaintEventHandler(txtDangNhap_Paint);

            // MainForm
            this.Controls.Add(txtDangNhap);
            this.ResumeLayout(false);

            txtPassword.PasswordChar = '*';
        }

        private void txtDangNhap_Click(object sender, EventArgs e)
        {
            using (var context = new EFDbContext())
            {
                var danhSachHocSinh = context.QuanTris.ToList();
                HashBCrypt hashBCrypt = new HashBCrypt();
                var admin = context.QuanTris.Where(
                    qt => qt.TenDangNhap == txtTenDangNhap.Text
                ).Select(qt => new
                {
                    qt.TenDangNhap,
                    qt.QuanTriID,
                    qt.MatKhau
                }).FirstOrDefault();
                if(admin == null)
                {
                    var hocSinh = context.HocSinhs.ToList();
                    var taiKhoanHocSinh = context.HocSinhs.Where(
                        hs => hs.MaHS == txtTenDangNhap.Text
                    ).Select(hs => new
                    {
                        hs.MaHS,
                        hs.MatKhau,
                        hs.HoTenHS
                    }).FirstOrDefault();

                    if(taiKhoanHocSinh != null && HashBCrypt.VerifyPassword(txtPassword.Text, taiKhoanHocSinh.MatKhau) == true)
                    {
                        MessageBox.Show("Đăng nhập thành công.");
                        FormCaNhanHocSinh home = new FormCaNhanHocSinh(taiKhoanHocSinh.MaHS, taiKhoanHocSinh.HoTenHS);
                        home.Show();
                        this.Hide();
                    } else
                    {
                        MessageBox.Show("Sai thông tin đăng nhập.");
                        txtPassword.Text = "";
                    }
                }

                if (admin != null)
                {
                    if(HashBCrypt.VerifyPassword(txtPassword.Text, admin.MatKhau) == false)
                    {
                        MessageBox.Show("Sai thông tin đăng nhập.");
                        txtPassword.Text = "";
                    } 
                    else
                    {
                        MessageBox.Show("Đăng nhập thành công.");
                        TrangChuQuanLy home = new TrangChuQuanLy();
                        home.Show();
                        this.Hide();
                    }

                }
            }
        }

        private void txtDangNhap_MouseEnter(object sender, EventArgs e)
        {
            //txtDangNhap.BackColor = Color.FromArgb(75, 123, 236);
            txtDangNhap.BackColor = Color.White;
            txtDangNhap.ForeColor = Color.FromArgb(45, 152, 218);
        }

        private void txtDangNhap_MouseLeave(object sender, EventArgs e)
        {
            txtDangNhap.BackColor = Color.FromArgb(45, 152, 218);
            txtDangNhap.ForeColor = Color.White;
        }

        private void txtDangNhap_MouseDown(object sender, MouseEventArgs e)
        {
            txtDangNhap.BackColor = Color.RoyalBlue;
        }

        private void txtDangNhap_MouseUp(object sender, MouseEventArgs e)
        {
            txtDangNhap.BackColor = Color.FromArgb(45, 152, 218);
        }

        private void txtDangNhap_Paint(object sender, PaintEventArgs e)
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
    }
}
