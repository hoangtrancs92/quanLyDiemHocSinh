﻿using managerStudent.Helpers;
using managerStudent.Models;
using managerStudent.Services;
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
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace managerStudent
{
    public partial class DiemHocSinh : Form
    {
        string MaHS = "";
        string HoTenHS = "";
        string TenLop = "";
        int MaMonHoc = 0;
        private readonly HocSinhService _hocSinhService;
        private readonly EFDbContext _context;
        public DiemHocSinh(string MaHS, string HoTenHS, string TenLop)
        {
            this.MaHS = MaHS;
            this.HoTenHS = HoTenHS;
            this.TenLop = TenLop;
            InitializeComponent();
            // thiết lập form cha
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

            // Khởi tạo EFDbContext và HocSinhService
            _context = new EFDbContext();
            _hocSinhService = new HocSinhService(_context);
        }

        private void DiemHocSinh_Load(object sender, EventArgs e)
        {
            txtMaHS.Text = this.MaHS;
            txtTen.Text = this.HoTenHS;
            txtLop.Text = this.TenLop;
            loadTenMonHoc();
            ReloadData();
            using (var context = new EFDbContext())
            {
                var query = context.Diems
    .Include(d => d.MonHoc)    // Include related MonHoc entities
    .Include(d => d.HocSinh)   // Include related HocSinh entities
    .Where(d => d.MaHS == MaHS) // Filter by student MaHS
    .ToList();                  // Execute query and retrieve all matching Diem entities
                decimal sumDTB = 0;
                foreach (var diem in query.ToList())
                {
                    sumDTB += diem.DTB;
                }
                double diemTrungBinhTong = query.ToList().Count > 0 ? (double)sumDTB / query.ToList().Count : 0.0;
                diemTrungBinhTong = Math.Round(diemTrungBinhTong, 2);
                lbDiemTBTong.Text = diemTrungBinhTong.ToString();
                if (diemTrungBinhTong >= 8)
                {
                    lbXepLoaiTong.Text = "Giỏi";

                }
                else if (diemTrungBinhTong >= 6.5)
                {
                    lbXepLoaiTong.Text = "Khá";

                }
                else if (diemTrungBinhTong >= 5)
                {
                    lbXepLoaiTong.Text = "Trung bình";

                }
                else
                {
                    lbXepLoaiTong.Text = "Yếu";

                }
            }
        }

        private void dataGridViewMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridViewMonHoc.Rows[e.RowIndex];
                // Lấy giá trị của ô trong hàng được chọn
                int maMon = Convert.ToInt32(selectedRow.Cells["MaMon"].Value);
                this.MaMonHoc = maMon;
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

                    var diem = context.Diems
                 .Include(d => d.MonHoc)  // Nạp thông tin từ bảng MonHoc
                 .Include(d => d.HocSinh) // Nạp thông tin từ bảng HocSinh
                 .Where(d => d.MaHS == MaHS && d.MaMon == maMon)
                 .FirstOrDefault();

                    lbGiuaKi.Text = (Convert.ToInt32(monHocData?.TiLeGK * 100)).ToString() + "%";
                    lbCuoiKi.Text = (Convert.ToInt32(monHocData?.TiLeCuoiKi * 100)).ToString() + "%";
                    lbHK1.Text = (Convert.ToInt32(monHocData?.TiLeHK1 * 100)).ToString() + "%";
                    lbHK2.Text = (Convert.ToInt32(monHocData?.TiLeHK2 * 100)).ToString() + "%";
                    lbDiemTrungBinh.Text = diem.DTB.ToString();
                    lbXepLoai.Text = diem.XepLoai.ToString();
                }
            }
        }

        private void dataGridViewMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow selectedRow = dataGridViewMonHoc.Rows[e.RowIndex];
            // Lấy giá trị của ô trong hàng được chọn
            int maMon = Convert.ToInt32(selectedRow.Cells["MaMon"].Value);
            if (e.RowIndex >= 0)
            {


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
            if (dataGridViewMonHoc.Columns[e.ColumnIndex].Name == "ChinhSuaDiem")
            {
                FormChinhSuaDiem f = new FormChinhSuaDiem(MaHS.ToString(), maMon);
                f.FormClosed += Dialog_FormClosed;
                f.ShowDialog();
            }

            if (dataGridViewMonHoc.Columns[e.ColumnIndex].Name == "XoaDiemColumn")
            {
                using (var context = new EFDbContext())
                {
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa điểm này không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        // Người dùng chọn "Có"
                        var diemToDelete = context.Diems
                            .Where(d => d.MaMon == int.Parse(maMon.ToString()) && d.MaHS == MaHS)
                            .ToList();
                        // Lưu thay đổi vào cơ sở dữ liệu
                        // Xóa các bản ghi tìm được
                        context.Diems.RemoveRange(diemToDelete);
                        context.SaveChanges();
                        // Sau khi xóa, cập nhật lại dữ liệu trong DataGridView
                        int soLuongMonChuaCoDiem = context.MonHocs
                    .Count(mh => !context.Diems.Any(d => d.MaMon == mh.MaMon && d.MaHS == MaHS));
                        if (soLuongMonChuaCoDiem > 0)
                        {
                            btnThem.Enabled = true;
                        }
                        else
                        {
                            btnThem.Enabled = false;
                        }
                        ReloadData();
                    }
                    else
                    {
                        // Người dùng chọn "Không" hoặc đóng MessageBox
                        // Không làm gì cả hoặc xử lý theo ý đồ của bạn
                    }
                }
            }
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
                Console.WriteLine(MaHS);
                int soLuongMonChuaCoDiem = context.MonHocs
                    .Count(mh => !context.Diems.Any(d => d.MaMon == mh.MaMon && d.MaHS == MaHS));
                if (soLuongMonChuaCoDiem > 0)
                {
                    btnThem.Enabled = true;
                }
                else
                {
                    btnThem.Enabled = false;
                }
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

        private void btnThem_Click(object sender, EventArgs e)
        {

            ThemSuaDiem themHocSinh = new ThemSuaDiem(MaHS);
            themHocSinh.FormClosed += Dialog_FormClosed;
            themHocSinh.ShowDialog();
        }

        private void Dialog_FormClosed(object sender, EventArgs e)
        {
            using (var context = new EFDbContext())
            {
                int soLuongMonChuaCoDiem = context.MonHocs
                    .Count(mh => !context.Diems.Any(d => d.MaMon == mh.MaMon && d.MaHS == MaHS));
                if (soLuongMonChuaCoDiem > 0)
                {
                    btnThem.Enabled = true;
                }
                else
                {
                    btnThem.Enabled = false;
                }
            }

            using (var context = new EFDbContext())
            {
                var query = context.Diems
    .Include(d => d.MonHoc)    // Include related MonHoc entities
    .Include(d => d.HocSinh)   // Include related HocSinh entities
    .Where(d => d.MaHS == MaHS) // Filter by student MaHS
    .ToList();                  // Execute query and retrieve all matching Diem entities
                decimal sumDTB = 0;
                foreach (var diem in query.ToList())
                {
                    sumDTB += diem.DTB;
                }
                double diemTrungBinhTong = query.ToList().Count > 0 ? (double)sumDTB / query.ToList().Count : 0.0;
                diemTrungBinhTong = Math.Round(diemTrungBinhTong, 2);
                lbDiemTBTong.Text = diemTrungBinhTong.ToString();
                if (diemTrungBinhTong >= 8)
                {
                    lbXepLoaiTong.Text = "Giỏi";

                }
                else if (diemTrungBinhTong >= 6.5)
                {
                    lbXepLoaiTong.Text = "Khá";

                }
                else if (diemTrungBinhTong >= 5)
                {
                    lbXepLoaiTong.Text = "Trung bình";

                }
                else
                {
                    lbXepLoaiTong.Text = "Yếu";

                }
            }
            // Thực hiện logic tải lại dữ liệu trên form cha ở đây
            ReloadData();
        }

        private void ReloadData()
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
                                 diem.DTB,
                                 lop.NamHoc
                             });

                dataGridViewMonHoc.DataSource = query.ToList();
           
            }

            using (var context = new EFDbContext())
            {
                var diem = context.Diems
                 .Include(d => d.MonHoc)  // Nạp thông tin từ bảng MonHoc
                 .Include(d => d.HocSinh) // Nạp thông tin từ bảng HocSinh
                 .Where(d => d.MaHS == MaHS && d.MaMon == MaMonHoc)
                 .FirstOrDefault();

                lbDiemTrungBinh.Text = diem.DTB.ToString();
                lbXepLoai.Text = diem.XepLoai.ToString();
                double finalAverage = double.Parse(diem.DTB.ToString());
                if (finalAverage >= 8)
                {
                    lbXepLoai.Text = "Giỏi";
                    lbtextDTB.ForeColor = Color.Green;
                    lbtxtxeploai.ForeColor = Color.Green;
                    lbXepLoai.ForeColor = Color.Green;
                    lbDiemTrungBinh.ForeColor = Color.Green;
                }
                else if (finalAverage >= 6.5)
                {
                    lbXepLoai.Text = "Khá";
                    lbtextDTB.ForeColor = Color.Green;
                    lbtxtxeploai.ForeColor = Color.Green;
                    lbXepLoai.ForeColor = Color.Green;
                    lbDiemTrungBinh.ForeColor = Color.Green;
                }
                else if (finalAverage >= 5)
                {
                    lbXepLoai.Text = "Trung bình";
                    lbtextDTB.ForeColor = Color.Red;
                    lbtxtxeploai.ForeColor = Color.Red;
                    lbXepLoai.ForeColor = Color.Red;
                    lbDiemTrungBinh.ForeColor = Color.Red;
                }
                else
                {
                    lbXepLoai.Text = "Yếu";
                    lbtextDTB.ForeColor = Color.Red;
                    lbtxtxeploai.ForeColor = Color.Red;
                    lbXepLoai.ForeColor = Color.Red;
                    lbDiemTrungBinh.ForeColor = Color.Red;
                }
            }

            using (var context = new EFDbContext())
            {
                var query = context.Diems
    .Include(d => d.MonHoc)    // Include related MonHoc entities
    .Include(d => d.HocSinh)   // Include related HocSinh entities
    .Where(d => d.MaHS == MaHS) // Filter by student MaHS
    .ToList();                  // Execute query and retrieve all matching Diem entities
                decimal sumDTB = 0;
                foreach (var diem in query.ToList())
                {
                    sumDTB += diem.DTB;
                }
                double diemTrungBinhTong = query.ToList().Count > 0 ? (double)sumDTB / query.ToList().Count : 0.0;
                lbDiemTBTong.Text = diemTrungBinhTong.ToString();
                if (diemTrungBinhTong >= 8)
                {
                    lbXepLoaiTong.Text = "Giỏi";

                }
                else if (diemTrungBinhTong >= 6.5)
                {
                    lbXepLoaiTong.Text = "Khá";

                }
                else if (diemTrungBinhTong >= 5)
                {
                    lbXepLoaiTong.Text = "Trung bình";

                }
                else
                {
                    lbXepLoaiTong.Text = "Yếu";

                }
            }    
        }

        private void lbDiemTrungBinh_Click(object sender, EventArgs e)
        {

        }

        private void lbtextDTB_Click(object sender, EventArgs e)
        {

        }
    }
}
