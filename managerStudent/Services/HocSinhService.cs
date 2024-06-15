using managerStudent.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace managerStudent.Services
{
    internal class HocSinhService
    {
        private readonly EFDbContext _context;

        public HocSinhService(EFDbContext context)
        {
            _context = context;
        }

        public List<object> TimKiemHocSinhTheoTenLopVaKhoi(string MaHS, string tenHocSinh = null, string tenLop = null, string tenKhoi = null)
        {
            var query = _context.HocSinhs.AsQueryable();

            if (!string.IsNullOrWhiteSpace(MaHS))
            {
                query = query.Where(hs => EF.Functions.Like(hs.MaHS, $"%{MaHS}%"));
            }

            if (!string.IsNullOrWhiteSpace(tenHocSinh))
            {
                query = query.Where(hs => EF.Functions.Like(hs.HoTenHS, $"%{tenHocSinh}%"));
            }

            if (!string.IsNullOrWhiteSpace(tenLop))
            {
                query = query.Include(hs => hs.Lop)
                             .Where(hs => hs.Lop.TenLop.Contains(tenLop));
            }

            if (!string.IsNullOrWhiteSpace(tenKhoi))
            {
                query = query.Include(hs => hs.Lop)
                             .ThenInclude(l => l.Khoi)
                             .Where(hs => hs.Lop.Khoi.TenKhoi.Contains(tenKhoi));
            }

            var ketQua = query.Select(hs => new
            {
                hs.MaHS,
                hs.HoTenHS,
                hs.NgSinh,
                hs.GioiTinh,
                hs.DanToc,
                hs.NoiSinh,
                hs.Lop.TenLop,
                hs.Lop.NamHoc
            }).ToList<object>();

            return ketQua;
        }

        public HocSinh GetHocSinhById(string maHS)
        {
            var hocSinh = _context.HocSinhs
                                .Include(hs => hs.Lop) // Đảm bảo rằng thêm Include nếu cần thiết
                                .FirstOrDefault(hs => hs.MaHS == maHS);

            return hocSinh;
        }

        public Khoi GetKhoiByMaHS(string maHS)
        {
            // Lấy thông tin học sinh và khối
            var hocSinh = _context.HocSinhs
                                   .Include(hs => hs.Lop)
                                       .ThenInclude(l => l.Khoi)
                                   .FirstOrDefault(hs => hs.MaHS == maHS);

            if (hocSinh != null)
            {
                return hocSinh.Lop?.Khoi;
            }

            return null;
        }

        public Lop GetLopByMaHS(string maHS)
        {
            // Lấy thông tin học sinh và lớp
            var hocSinh = _context.HocSinhs
                                   .Include(hs => hs.Lop)
                                   .FirstOrDefault(hs => hs.MaHS == maHS);

            if (hocSinh != null)
            {
                return hocSinh.Lop;
            }

            return null;
        }

        public void UpdateHocSinh(HocSinh hocSinh)
        {
            _context.Entry(hocSinh).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void XoaHocSinh(string maHS)
        {
            // Tìm học sinh cần xóa
            var hocSinh = _context.HocSinhs
                                  .Include(hs => hs.Diems)  // Đảm bảo rằng có include liên kết đến bảng Diem
                                  .FirstOrDefault(hs => hs.MaHS == maHS);

            if (hocSinh != null)
            {
                // Xóa các điểm của học sinh
                XoaTatCaiemHocSinh(maHS);

                // Xóa học sinh và lưu thay đổi
                _context.HocSinhs.Remove(hocSinh);
                _context.SaveChanges();
            }
        }

        public void XoaTatCaiemHocSinh(string maHS)
        {
            // Tìm tất cả các bản ghi điểm của học sinh
            var diems = _context.Diems.Where(d => d.MaHS == maHS).ToList();

            // Xóa từng bản ghi điểm
            foreach (var diem in diems)
            {
                _context.Diems.Remove(diem);
            }

            // Lưu thay đổi vào cơ sở dữ liệu
            _context.SaveChanges();

        }
    }
}

