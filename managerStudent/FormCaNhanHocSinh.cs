using managerStudent.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace managerStudent
{
    public partial class FormCaNhanHocSinh : Form
    {
        string MaHS = "";
        string HoTenHS = "";
        string TenLop = "";
        public FormCaNhanHocSinh(string MaHS, string HoTenHS)
        {
            Lop thongTinLop = loadThongTinHocSinh(MaHS);
            this.MaHS = MaHS;
            this.HoTenHS = HoTenHS;
            this.TenLop = thongTinLop.TenLop;
            InitializeComponent();
        }

        private void FormCaNhanHocSinh_Load(object sender, EventArgs e)
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
                                 lop.NamHoc,
                                 diem.DTB,
                                 diem.XepLoai
                             });

                dataGridViewMonHoc.DataSource = query.ToList();
                //// Thêm cột "Điểm trung bình" vào DataGridView
                //DataGridViewTextBoxColumn avgColumn = new DataGridViewTextBoxColumn();
                //avgColumn.HeaderText = "Điểm trung bình";
                //avgColumn.Name = "AverageScore";
                //dataGridViewMonHoc.Columns.Add(avgColumn);

                //// Tính toán và thiết lập giá trị cho cột "Điểm trung bình"
                //foreach (DataGridViewRow row in dataGridViewMonHoc.Rows)
                //{
                //    float averageScore = CalculateAverageScore(row);
                //    row.Cells["AverageScore"].Value = averageScore;
                //}

            }
        }

        private void dataGridViewMonHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
                                     lop.NamHoc,
                                     diem.DTB,
                                     diem.XepLoai,
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
                                 lop.NamHoc,
                                 diem.DTB,
                                 diem.XepLoai,
                             });

                dataGridViewMonHoc.DataSource = query.ToList();
            }
            //// Thêm cột "Điểm trung bình" vào DataGridView
            //DataGridViewTextBoxColumn avgColumn = new DataGridViewTextBoxColumn();
            //avgColumn.HeaderText = "Điểm trung bình";
            //avgColumn.Name = "AverageScore";
            //dataGridViewMonHoc.Columns.Add(avgColumn);

            //// Tính toán và thiết lập giá trị cho cột "Điểm trung bình"
            //foreach (DataGridViewRow row in dataGridViewMonHoc.Rows)
            //{
            //    float averageScore = CalculateAverageScore(row);
            //    row.Cells["AverageScore"].Value = averageScore;
            //}
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

        private Lop loadThongTinHocSinh(string MaHS)
        {
            using (var context = new EFDbContext())
            {
                // Giả sử bạn đã có MaHS

                // Truy vấn để lấy thông tin lớp dựa trên MaHS
                var lop = (from hs in context.HocSinhs
                           join l in context.Lops on hs.MaLop equals l.MaLop
                           where hs.MaHS == MaHS
                           select l).FirstOrDefault();
                return lop;
            }
        }

        private float CalculateAverageScore(DataGridViewRow row)
        {
            float diemGKHK1 = Convert.ToSingle(row.Cells["DiemGKHK1"].Value);
            float diemCKHK1 = Convert.ToSingle(row.Cells["DiemCKHK1"].Value);
            float diemGKHK2 = Convert.ToSingle(row.Cells["DiemGKHK2"].Value);
            float diemCKHK2 = Convert.ToSingle(row.Cells["DiemCKHK2"].Value);
            float heSoMon = 1; // Giả sử hệ số môn học là 1, bạn có thể thay đổi theo giá trị thực tế
            float tiLeGK = 0.3f; // Giả sử tỷ lệ điểm giữa kỳ là 30%
            float tiLeCK = 0.7f; // Giả sử tỷ lệ điểm cuối kỳ là 70%

            float dtbHK1 = (diemGKHK1 * tiLeGK + diemCKHK1 * tiLeCK);
            float dtbHK2 = (diemGKHK2 * tiLeGK + diemCKHK2 * tiLeCK);
            float averageScore = (dtbHK1 + dtbHK2) / 2;

            return averageScore;
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDangNhap home = new FormDangNhap();
            home.Show();
            this.Hide();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
