using managerStudent.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace managerStudent
{
    internal class EFDbContext : DbContext
    {
        public DbSet<HocSinh> HocSinhs { get; set; }
        public DbSet<MonHoc> MonHocs { get; set; }
        public DbSet<Lop> Lops { get; set; }
        public DbSet<Diem> Diems { get; set; }
        public DbSet<QuanTri> QuanTris { get; set; }
        public DbSet<Khoi> Khois { get; set; }
        public void ConfigureServices(IServiceCollection services)
            => services.AddDbContext<EFDbContext>();
        protected override void OnConfiguring(DbContextOptionsBuilder
       optionsBuilder)
        => optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["db"].ConnectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            SeedData(modelBuilder);
            modelBuilder.Entity<Diem>()
                        .HasKey(d => new { d.MaHS, d.MaMon });

            // Cấu hình quan hệ một-nhiều giữa HocSinh và Diem
            modelBuilder.Entity<HocSinh>()
                .HasMany(hs => hs.Diems)
                .WithOne(d => d.HocSinh)
                .HasForeignKey(d => d.MaHS);

            // Cấu hình quan hệ một-nhiều giữa MonHoc và Diem
            modelBuilder.Entity<MonHoc>()
                .HasMany(mh => mh.Diems)
                .WithOne(d => d.MonHoc)
                .HasForeignKey(d => d.MaMon);

            // Khóa ngoại tham chiếu đến bảng Lop
            modelBuilder.Entity<HocSinh>()
                .HasOne(hs => hs.Lop)
                .WithMany(l => l.HocSinhs)
                .HasForeignKey(hs => hs.MaLop);

            modelBuilder.Entity<Lop>()
                .HasOne(l => l.Khoi)
                .WithMany(k => k.Lops)
                .HasForeignKey(l => l.MaKhoi); // Sử dụng tên khác cho khóa ngoại   
        }

        private void SeedData(ModelBuilder modelBuilder)
        {
            // Seed data for Diem
            modelBuilder.Entity<Khoi>().HasData(
                new Khoi { MaKhoi = 1, TenKhoi = "Khối 6" },
                new Khoi { MaKhoi = 2, TenKhoi = "Khối 7" },
                new Khoi { MaKhoi = 3, TenKhoi = "Khối 8" },
                new Khoi { MaKhoi = 4, TenKhoi = "Khối 9" }
                // Add more Diem records...
            );

            // Seed data for HocSinh
            modelBuilder.Entity<HocSinh>().HasData(
                new HocSinh { MaHS = "MS001", MatKhau= HocSinh.HashPassword("123456"), HoTenHS = "Nguyen Van A", NgSinh = new DateTime(2000, 1, 1), GioiTinh = "Nam", NoiSinh = "Ha Noi", DanToc = "Kinh", MaLop = 1 },
                new HocSinh { MaHS = "MS002", MatKhau = HocSinh.HashPassword("123456"), HoTenHS = "Tran Thi B", NgSinh = new DateTime(2001, 2, 2), GioiTinh = "Nu", NoiSinh = "Hai Phong", DanToc = "Hoa", MaLop = 2 },
                new HocSinh { MaHS = "MS003", MatKhau = HocSinh.HashPassword("123456"), HoTenHS = "Le Van C", NgSinh = new DateTime(2002, 3, 3), GioiTinh = "Nam", NoiSinh = "Da Nang", DanToc = "Kinh", MaLop = 1 }
            );

            // Seed data for MonHoc
            modelBuilder.Entity<MonHoc>().HasData(
                new MonHoc { MaMon = 1, TenMH = "Toán", HeSoMon = 1.0f, TiLeGK = 0.2f, TiLeCuoiKi = 0.8f, TiLeHK1 = 0.4f, TiLeHK2 = 0.6f },
                new MonHoc { MaMon = 2, TenMH = "Văn", HeSoMon = 1.0f, TiLeGK = 0.2f, TiLeCuoiKi = 0.8f, TiLeHK1 = 0.4f, TiLeHK2 = 0.6f },
                new MonHoc { MaMon = 3, TenMH = "Anh", HeSoMon = 1.0f, TiLeGK = 0.2f, TiLeCuoiKi = 0.8f, TiLeHK1 = 0.4f, TiLeHK2 = 0.6f },
                new MonHoc { MaMon = 4, TenMH = "Lịch sử", HeSoMon = 1.0f, TiLeGK = 0.2f, TiLeCuoiKi = 0.8f, TiLeHK1 = 0.4f, TiLeHK2 = 0.6f },
                new MonHoc { MaMon = 5, TenMH = "Địa lý", HeSoMon = 1.0f, TiLeGK = 0.2f, TiLeCuoiKi = 0.8f, TiLeHK1 = 0.4f, TiLeHK2 = 0.6f },
                new MonHoc { MaMon = 6, TenMH = "Hóa học", HeSoMon = 1.0f, TiLeGK = 0.2f, TiLeCuoiKi = 0.8f, TiLeHK1 = 0.4f, TiLeHK2 = 0.6f },
                new MonHoc { MaMon = 7, TenMH = "Sinh học", HeSoMon = 1.0f, TiLeGK = 0.2f, TiLeCuoiKi = 0.8f, TiLeHK1 = 0.4f, TiLeHK2 = 0.6f },
                new MonHoc { MaMon = 8, TenMH = "Công nghệ", HeSoMon = 1.0f, TiLeGK = 0.2f, TiLeCuoiKi = 0.8f, TiLeHK1 = 0.4f, TiLeHK2 = 0.6f },
                new MonHoc { MaMon = 9, TenMH = "Vật lý", HeSoMon = 1.0f, TiLeGK = 0.2f, TiLeCuoiKi = 0.8f, TiLeHK1 = 0.4f, TiLeHK2 = 0.6f },
                new MonHoc { MaMon = 10, TenMH = "Giáo dục công dân", HeSoMon = 1.0f, TiLeGK = 0.2f, TiLeCuoiKi = 0.8f, TiLeHK1 = 0.4f, TiLeHK2 = 0.6f },
                new MonHoc { MaMon = 11, TenMH = "Công dân", HeSoMon = 1.0f, TiLeGK = 0.2f, TiLeCuoiKi = 0.8f, TiLeHK1 = 0.4f, TiLeHK2 = 0.6f },
                new MonHoc { MaMon = 12, TenMH = "Thể dục", HeSoMon = 1.0f, TiLeGK = 0.2f, TiLeCuoiKi = 0.8f, TiLeHK1 = 0.4f, TiLeHK2 = 0.6f },
                new MonHoc { MaMon = 13, TenMH = "Âm nhạc", HeSoMon = 1.0f, TiLeGK = 0.2f, TiLeCuoiKi = 0.8f, TiLeHK1 = 0.4f, TiLeHK2 = 0.6f }
            );

            // Seed data for Lop
            modelBuilder.Entity<Lop>().HasData(
                new Lop { MaLop = 1, TenLop = "6A/1", NamHoc = "2023-2024", MaKhoi= 1 },
                new Lop { MaLop = 2, TenLop = "6A/2", NamHoc = "2023-2024", MaKhoi= 1 },
                new Lop { MaLop = 3, TenLop = "6B/3", NamHoc = "2023-2024", MaKhoi= 1 },
                new Lop { MaLop = 4, TenLop = "6B/4", NamHoc = "2023-2024", MaKhoi= 1 },
                new Lop { MaLop = 5, TenLop = "7A/1", NamHoc = "2023-2024", MaKhoi = 2 },
                new Lop { MaLop = 6, TenLop = "7A/2", NamHoc = "2023-2024", MaKhoi = 2 },
                new Lop { MaLop = 7, TenLop = "7B/3", NamHoc = "2023-2024", MaKhoi = 2 },
                new Lop { MaLop = 8, TenLop = "7B/4", NamHoc = "2023-2024", MaKhoi = 2 },
               new Lop { MaLop = 9, TenLop = "8A/1", NamHoc = "2023-2024", MaKhoi = 3 },
                new Lop { MaLop = 10, TenLop = "8A/2", NamHoc = "2023-2024", MaKhoi = 3 },
                new Lop { MaLop = 11, TenLop = "8B/3", NamHoc = "2023-2024", MaKhoi = 3 },
                new Lop { MaLop = 12, TenLop = "8B/4", NamHoc = "2023-2024", MaKhoi = 3 },
                new Lop { MaLop = 13, TenLop = "9A/1", NamHoc = "2023-2024", MaKhoi = 4 },
                new Lop { MaLop = 14, TenLop = "9A/2", NamHoc = "2023-2024", MaKhoi = 4 },
                new Lop { MaLop = 15, TenLop = "9B/3", NamHoc = "2023-2024", MaKhoi = 4 },
                new Lop { MaLop = 16, TenLop = "9B/4", NamHoc = "2023-2024", MaKhoi = 4 }
            );

            // Seed data for Diem
            modelBuilder.Entity<Diem>().HasData(
                new Diem { MaHS = "MS001", MaMon = 1, DiemGKHK1 = 7.5m, DiemCKHK1 = 8.0m, DiemGKHK2 = 8.5m, DiemCKHK2 = 9.0m, DTB = 8.0m, XepLoai = "Kha" },
                new Diem { MaHS = "MS001", MaMon = 2, DiemGKHK1 = 7.5m, DiemCKHK1 = 8.0m, DiemGKHK2 = 8.5m, DiemCKHK2 = 9.0m, DTB = 8.0m, XepLoai = "Kha" },
                new Diem { MaHS = "MS001", MaMon = 3, DiemGKHK1 = 7.5m, DiemCKHK1 = 8.0m, DiemGKHK2 = 8.5m, DiemCKHK2 = 9.0m, DTB = 8.0m, XepLoai = "Kha" },
                new Diem { MaHS = "MS001", MaMon = 4, DiemGKHK1 = 7.5m, DiemCKHK1 = 8.0m, DiemGKHK2 = 8.5m, DiemCKHK2 = 9.0m, DTB = 8.0m, XepLoai = "Kha" },
                new Diem { MaHS = "MS001", MaMon = 5, DiemGKHK1 = 7.5m, DiemCKHK1 = 8.0m, DiemGKHK2 = 8.5m, DiemCKHK2 = 9.0m, DTB = 8.0m, XepLoai = "Kha" },
                new Diem { MaHS = "MS001", MaMon = 6, DiemGKHK1 = 7.5m, DiemCKHK1 = 8.0m, DiemGKHK2 = 8.5m, DiemCKHK2 = 9.0m, DTB = 8.0m, XepLoai = "Kha" },
                new Diem { MaHS = "MS001", MaMon = 7, DiemGKHK1 = 7.5m, DiemCKHK1 = 8.0m, DiemGKHK2 = 8.5m, DiemCKHK2 = 9.0m, DTB = 8.0m, XepLoai = "Kha" },
                new Diem { MaHS = "MS001", MaMon = 8, DiemGKHK1 = 7.5m, DiemCKHK1 = 8.0m, DiemGKHK2 = 8.5m, DiemCKHK2 = 9.0m, DTB = 8.0m, XepLoai = "Kha" },
                new Diem { MaHS = "MS001", MaMon = 9, DiemGKHK1 = 7.5m, DiemCKHK1 = 8.0m, DiemGKHK2 = 8.5m, DiemCKHK2 = 9.0m, DTB = 8.0m, XepLoai = "Kha" },
                new Diem { MaHS = "MS001", MaMon = 10, DiemGKHK1 = 7.5m, DiemCKHK1 = 8.0m, DiemGKHK2 = 8.5m, DiemCKHK2 = 9.0m, DTB = 8.0m, XepLoai = "Kha" },
                new Diem { MaHS = "MS002", MaMon = 1, DiemGKHK1 = 8.0m, DiemCKHK1 = 8.5m, DiemGKHK2 = 9.0m, DiemCKHK2 = 9.5m, DTB = 8.5m, XepLoai = "Gioi" },
                new Diem { MaHS = "MS003", MaMon = 1, DiemGKHK1 = 6.5m, DiemCKHK1 = 7.0m, DiemGKHK2 = 7.5m, DiemCKHK2 = 8.0m, DTB = 7.0m, XepLoai = "Trung Binh" }
                // Add more Diem records...
            );

            modelBuilder.Entity<QuanTri>().HasData(
                new QuanTri { QuanTriID = 1, MatKhau = QuanTri.HashPassword("123456"), TenDangNhap="admin" }
            );
        }
    }
}
