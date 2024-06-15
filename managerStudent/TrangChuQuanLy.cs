using managerStudent.Models;
using managerStudent.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace managerStudent
{
    public partial class TrangChuQuanLy : Form
    {
        private string tenKhoiTimKiem = "";
        private string tenLopTimKiem = "";
        private string tenHocSinhTimKiem = "";
        private readonly HocSinhService _hocSinhService;
        private readonly EFDbContext _context;
        public TrangChuQuanLy()
        {
            InitializeComponent();
            // Khởi tạo EFDbContext và HocSinhService
            _context = new EFDbContext();
            _hocSinhService = new HocSinhService(_context);
        }

        private void TrangChuQuanLy_Load(object sender, EventArgs e)
        {
            using (var context = new EFDbContext())
            {
                var query = from hocSinh in context.HocSinhs
                            join lop in context.Lops on hocSinh.MaLop equals lop.MaLop
                            select new
                            {
                                hocSinh.MaHS,
                                hocSinh.HoTenHS,
                                hocSinh.NgSinh,
                                hocSinh.GioiTinh,
                                hocSinh.DanToc,
                                hocSinh.NoiSinh,
                                lop.TenLop,
                                lop.NamHoc

                            };
                dataGridView1.DataSource = query.ToList();
            }

            LoadKhois();
            loadTatCaKhoi();
            loadTatCaLop();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            ThemHocSinh themHocSinh = new ThemHocSinh();
            themHocSinh.FormClosed += Dialog_FormClosed;
            themHocSinh.ShowDialog();
        }

        private void Dialog_FormClosed(object sender, EventArgs e)
        {
            // Thực hiện logic tải lại dữ liệu trên form cha ở đây
            ReloadData();
        }

        private void ReloadData()
        {
            using (var context = new EFDbContext())
            {
                var query = from hocSinh in context.HocSinhs
                            join lop in context.Lops on hocSinh.MaLop equals lop.MaLop
                            select new
                            {
                                hocSinh.MaHS,
                                hocSinh.HoTenHS,
                                hocSinh.NgSinh,
                                hocSinh.GioiTinh,
                                hocSinh.DanToc,
                                hocSinh.NoiSinh,
                                lop.TenLop,
                                lop.NamHoc

                            };
                dataGridView1.DataSource = query.ToList();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var MaHS = dataGridView1.Rows[e.RowIndex].Cells["MaHS"].Value;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "xemDiemColumn")
            {
                var TenLop = dataGridView1.Rows[e.RowIndex].Cells["TenLop"].Value;
                var HoTenHS = dataGridView1.Rows[e.RowIndex].Cells["HoTenHS"].Value;
                DiemHocSinh f = new DiemHocSinh(MaHS.ToString(), HoTenHS.ToString(), TenLop.ToString());
                f.ShowDialog();
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "chinhSuaColumn")
            {
                ThemHocSinh f = new ThemHocSinh(MaHS.ToString());
                f.FormClosed += Dialog_FormClosed;
                f.ShowDialog();
            }

            if (dataGridView1.Columns[e.ColumnIndex].Name == "XoaColumn")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa học sinh này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // Người dùng chọn "Có"
                    // Thực hiện xóa học sinh và các liên kết tại đây
                    _hocSinhService.XoaHocSinh(MaHS.ToString());

                    // Sau khi xóa, cập nhật lại dữ liệu trong DataGridView
                    ReloadData();
                }
                else
                {
                    // Người dùng chọn "Không" hoặc đóng MessageBox
                    // Không làm gì cả hoặc xử lý theo ý đồ của bạn
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectKhoi = comboBox1.SelectedItem as Khoi;
            // Set giá trị vào để tìm kiếm
            if (selectKhoi.MaKhoi != 0)
            {
                this.tenKhoiTimKiem = selectKhoi.TenKhoi;
            }
            else
            {
                this.tenKhoiTimKiem = null;
            }

            if (selectKhoi != null)
            {
                var maKhoi = selectKhoi.MaKhoi;
                using (var context = new EFDbContext())
                {
                    var classesByLops = context.Lops
                                               .Include(l => l.Khoi) // Include Khoi for navigation property
                                               .Where(l => l.MaKhoi == maKhoi)
                                               .ToList();
                    classesByLops.Insert(0, new Lop { MaLop = 0, TenLop = "Tất cả" });
                    cbbLop.DataSource = classesByLops;
                    cbbLop.DisplayMember = "TenLop";
                    cbbLop.ValueMember = "MaLop";
                }
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

        private void LoadLop()
        {
            using (var context = new EFDbContext())
            {
                var lop = context.Lops.ToList();
                cbbLop.DataSource = lop;
                cbbLop.DisplayMember = "TenLop";
                cbbLop.ValueMember = "MaLop";
            }
        }

        private void loadTatCaLop()
        {
            using (var context = new EFDbContext())
            {
                var lopAll = context.Lops.ToList();

                lopAll.Insert(0, new Lop { MaLop = 0, TenLop = "Tất cả" });
                cbbLop.DataSource = lopAll;
                cbbLop.DisplayMember = "TenLop";
                cbbLop.ValueMember = "MaLop";
            }
        }

        private void loadTatCaKhoi()
        {
            using (var context = new EFDbContext())
            {
                var monhocAll = context.Khois.ToList();

                monhocAll.Insert(0, new Khoi { MaKhoi = 0, TenKhoi = "Tất cả" });
                comboBox1.DataSource = monhocAll;
                comboBox1.DisplayMember = "TenKhoi";
                comboBox1.ValueMember = "MaKhoi";
            }
        }

        // button search
        private void button1_Click(object sender, EventArgs e)
        {
            string maHS = txtMaHS.Text;
            string tenHocSinhTimKiem = txtTen.Text;
            string tenLopTimKiem = this.tenLopTimKiem;
            string tenKhoiTimKiem = this.tenKhoiTimKiem;
            var ketQua = _hocSinhService.TimKiemHocSinhTheoTenLopVaKhoi(maHS, tenHocSinhTimKiem, tenLopTimKiem, tenKhoiTimKiem);
            if (ketQua.Count == 0)
            {
                MessageBox.Show("Dữ liệu tìm kiếm không tồn tại.");
            }
            else
            {
                dataGridView1.DataSource = ketQua.ToList();
            }
        }

        private void cbbLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectLop = cbbLop.SelectedItem as Lop;
            if (selectLop.MaLop != 0)
            {
                this.tenLopTimKiem = selectLop.TenLop;
            }
            else
            {
                this.tenLopTimKiem = null;
            }
        }

        private void newCategoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDangNhap home = new FormDangNhap();
            home.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TrangChuQuanLy home = new TrangChuQuanLy();
            home.Close();
        }
    }
}
