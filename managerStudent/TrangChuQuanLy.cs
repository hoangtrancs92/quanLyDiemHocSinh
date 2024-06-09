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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace managerStudent
{
    public partial class TrangChuQuanLy : Form
    {
        public TrangChuQuanLy()
        {
            InitializeComponent();
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
            if (dataGridView1.Columns[e.ColumnIndex].Name == "xemDiemColumn")
            {
                var MaHS = dataGridView1.Rows[e.RowIndex].Cells["MaHS"].Value;
                var TenLop = dataGridView1.Rows[e.RowIndex].Cells["TenLop"].Value;
                var HoTenHS = dataGridView1.Rows[e.RowIndex].Cells["HoTenHS"].Value;
                DiemHocSinh f = new DiemHocSinh(MaHS.ToString(), HoTenHS.ToString(), TenLop.ToString());
                f.ShowDialog();
            }
        }
    }
}
