using managerStudent.Helpers;
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
    public partial class DiemHocSinh : Form
    {
        string MaHS = "";
        string HoTenHS = "";
        string TenLop = "";
        public DiemHocSinh(string MaHS, string HoTenHS, string TenLop)
        {
            this.MaHS = MaHS;
            this.HoTenHS = HoTenHS;
            this.TenLop = TenLop;
            InitializeComponent();

            // btnThem
            btnThem.BackColor = Color.FromArgb(45, 152, 218);
            btnThem.ForeColor = Color.White;
            btnThem.Font = new Font("Arial", 10, FontStyle.Bold);
            btnThem.FlatAppearance.BorderSize = 0;

            btnThem.MouseEnter += new EventHandler(btnThem_MouseEnter);
            btnThem.MouseLeave += new EventHandler(btnThem_MouseLeave);
            btnThem.MouseDown += new MouseEventHandler(btnThem_MouseDown);
            btnThem.MouseUp += new MouseEventHandler(btnThem_MouseUp);
            btnThem.Paint += new PaintEventHandler(btnThem_Paint);
        }

        private void DiemHocSinh_Load(object sender, EventArgs e)
        {
            txtMaHS.Text = this.MaHS;
            txtTen.Text = this.HoTenHS;
            txtLop.Text = this.TenLop;
            loadTenMonHoc();

            using (var context = new EFDbContext())
            {
                var query = (from diem in context.Diems
                             join monHoc in context.MonHocs on diem.MaMon equals monHoc.MaMon
                             join hocSinh in context.HocSinhs on diem.MaHS equals hocSinh.MaHS
                             join lop in context.Lops on hocSinh.MaLop equals lop.MaLop
                             where diem.MaHS == this.MaHS
                             select new
                             {
                                 monHoc.MaMon,
                                 monHoc.TenMH,
                                 diem.DiemGKHK1,
                                 diem.DiemCKHK1,
                                 diem.DiemGKHK2,
                                 diem.DiemCKHK2,
                                 lop.NamHoc
                             });

                dataGridViewMonHoc.DataSource = query.ToList();

            }
        }

        private void dataGridViewMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewMonHoc.Rows[e.RowIndex];
                // Lấy giá trị của ô trong hàng được chọn
                int maMon = Convert.ToInt32(selectedRow.Cells["MaMon"].Value);

                // Xử lý dữ liệu
                using (var context = new EFDbContext())
                {
                    var monHocData = context.MonHocs.Where(
                        mh => mh.MaMon == maMon
                    ).Select(mh => new
                    {
                        mh.TiLeGK,
                        mh.TiLeCuoiKi,
                        mh.TiLeHK1,
                        mh.TiLeHK2,
                    }).FirstOrDefault();

                    lbGiuaKi.Text = (Convert.ToInt32(monHocData?.TiLeGK * 100)).ToString() + "%";
                    lbCuoiKi.Text = (Convert.ToInt32(monHocData?.TiLeCuoiKi * 100)).ToString() + "%";
                    lbHK1.Text = (Convert.ToInt32(monHocData?.TiLeHK1 * 100)).ToString() + "%";
                    lbHK2.Text = (Convert.ToInt32(monHocData?.TiLeHK2 * 100)).ToString() + "%";
                }
            }
        }

        private void dataGridViewMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MonHoc selectedMonHoc = (MonHoc)comboBox1.SelectedItem;
            if (selectedMonHoc.MaMon == 0 && selectedMonHoc.TenMH == "Tất cả")
            {
                using (var context = new EFDbContext())
                {
                    var query = (from diem in context.Diems
                                 join monHoc in context.MonHocs on diem.MaMon equals monHoc.MaMon
                                 join hocSinh in context.HocSinhs on diem.MaHS equals hocSinh.MaHS
                                 join lop in context.Lops on hocSinh.MaLop equals lop.MaLop
                                 where diem.MaHS == this.MaHS
                                 select new
                                 {
                                     monHoc.MaMon,
                                     monHoc.TenMH,
                                     diem.DiemGKHK1,
                                     diem.DiemCKHK1,
                                     diem.DiemGKHK2,
                                     diem.DiemCKHK2,
                                     lop.NamHoc
                                 });
                    dataGridViewMonHoc.DataSource = query.ToList();
                    return;
                }

            }
            var tenMH = selectedMonHoc?.TenMH;
            using (var context = new EFDbContext())
            {
                var query = (from diem in context.Diems
                             join monHoc in context.MonHocs on diem.MaMon equals monHoc.MaMon
                             join hocSinh in context.HocSinhs on diem.MaHS equals hocSinh.MaHS
                             join lop in context.Lops on hocSinh.MaLop equals lop.MaLop
                             where monHoc.TenMH == tenMH
                             where diem.MaHS == this.MaHS
                             select new
                             {
                                 monHoc.MaMon,
                                 monHoc.TenMH,
                                 diem.DiemGKHK1,
                                 diem.DiemCKHK1,
                                 diem.DiemGKHK2,
                                 diem.DiemCKHK2,
                                 lop.NamHoc
                             });

                dataGridViewMonHoc.DataSource = query.ToList();
            }
        }

        private void loadTenMonHoc()
        {
            using (var context = new EFDbContext())
            {
                var monhocAll = context.MonHocs.ToList();

                monhocAll.Insert(0, new MonHoc { MaMon = 0, TenMH = "Tất cả" });
                comboBox1.DataSource = monhocAll;
                comboBox1.DisplayMember = "TenMH";
                comboBox1.ValueMember = "MaMon";
            }
        }
        private void btnThem_MouseEnter(object sender, EventArgs e)
        {
            //btnThem.BackColor = Color.FromArgb(75, 123, 236);
            btnThem.BackColor = Color.White;
            btnThem.ForeColor = Color.FromArgb(45, 152, 218);
        }

        private void btnThem_MouseLeave(object sender, EventArgs e)
        {
            btnThem.BackColor = Color.FromArgb(45, 152, 218);
            btnThem.ForeColor = Color.White;
        }

        private void btnThem_MouseDown(object sender, MouseEventArgs e)
        {
            btnThem.BackColor = Color.RoyalBlue;
        }

        private void btnThem_MouseUp(object sender, MouseEventArgs e)
        {
            btnThem.BackColor = Color.FromArgb(45, 152, 218);
        }
        private void btnThem_Paint(object sender, PaintEventArgs e)
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
