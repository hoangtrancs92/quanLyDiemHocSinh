﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using managerStudent;

#nullable disable

namespace managerStudent.Migrations
{
    [DbContext(typeof(EFDbContext))]
    partial class EFDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("managerStudent.Models.Diem", b =>
                {
                    b.Property<string>("MaHS")
                        .HasColumnType("nvarchar(20)")
                        .HasColumnOrder(0);

                    b.Property<int>("MaMon")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.Property<decimal>("DTB")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DiemCKHK1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DiemCKHK2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DiemGKHK1")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("DiemGKHK2")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("XepLoai")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MaHS", "MaMon");

                    b.HasIndex("MaMon");

                    b.ToTable("Diems");

                    b.HasData(
                        new
                        {
                            MaHS = "MS001",
                            MaMon = 1,
                            DTB = 8.0m,
                            DiemCKHK1 = 8.0m,
                            DiemCKHK2 = 9.0m,
                            DiemGKHK1 = 7.5m,
                            DiemGKHK2 = 8.5m,
                            XepLoai = "Kha"
                        },
                        new
                        {
                            MaHS = "MS002",
                            MaMon = 1,
                            DTB = 8.5m,
                            DiemCKHK1 = 8.5m,
                            DiemCKHK2 = 9.5m,
                            DiemGKHK1 = 8.0m,
                            DiemGKHK2 = 9.0m,
                            XepLoai = "Gioi"
                        },
                        new
                        {
                            MaHS = "MS003",
                            MaMon = 1,
                            DTB = 7.0m,
                            DiemCKHK1 = 7.0m,
                            DiemCKHK2 = 8.0m,
                            DiemGKHK1 = 6.5m,
                            DiemGKHK2 = 7.5m,
                            XepLoai = "Trung Binh"
                        });
                });

            modelBuilder.Entity("managerStudent.Models.HocSinh", b =>
                {
                    b.Property<string>("MaHS")
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("DanToc")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("HoTenHS")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("MaLop")
                        .HasColumnType("int");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime>("NgSinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("NoiSinh")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("MaHS");

                    b.HasIndex("MaLop");

                    b.ToTable("HocSinhs");

                    b.HasData(
                        new
                        {
                            MaHS = "MS001",
                            DanToc = "Kinh",
                            GioiTinh = "Nam",
                            HoTenHS = "Nguyen Van A",
                            MaLop = 1,
                            MatKhau = "$2a$10$x.mfgx7HGEyWDD0uUWo8qe.h68cKhf9tJakhKO8YzGOspgyx4I4D.",
                            NgSinh = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NoiSinh = "Ha Noi"
                        },
                        new
                        {
                            MaHS = "MS002",
                            DanToc = "Hoa",
                            GioiTinh = "Nu",
                            HoTenHS = "Tran Thi B",
                            MaLop = 2,
                            MatKhau = "$2a$10$e68qs4Kmgz5q/hDHisbHGei.oSWp3HpSnc9epJOVhqTO9JqPs98Cq",
                            NgSinh = new DateTime(2001, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NoiSinh = "Hai Phong"
                        },
                        new
                        {
                            MaHS = "MS003",
                            DanToc = "Kinh",
                            GioiTinh = "Nam",
                            HoTenHS = "Le Van C",
                            MaLop = 1,
                            MatKhau = "$2a$10$/MgqXwAYQ5U/Hy1NlrHdGOMlSgWKPHzY6/Nec9omZW2eBf6LbOsY2",
                            NgSinh = new DateTime(2002, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NoiSinh = "Da Nang"
                        });
                });

            modelBuilder.Entity("managerStudent.Models.Lop", b =>
                {
                    b.Property<int>("MaLop")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaLop"));

                    b.Property<string>("NamHoc")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenLop")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MaLop");

                    b.ToTable("Lops");

                    b.HasData(
                        new
                        {
                            MaLop = 1,
                            NamHoc = "2023-2024",
                            TenLop = "10A"
                        },
                        new
                        {
                            MaLop = 2,
                            NamHoc = "2023-2024",
                            TenLop = "10B"
                        },
                        new
                        {
                            MaLop = 3,
                            NamHoc = "2024-2025",
                            TenLop = "11A"
                        });
                });

            modelBuilder.Entity("managerStudent.Models.MonHoc", b =>
                {
                    b.Property<int>("MaMon")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaMon"));

                    b.Property<float>("HeSoMon")
                        .HasColumnType("real");

                    b.Property<string>("Khoi")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenMH")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<float>("TiLeCuoiKi")
                        .HasColumnType("real");

                    b.Property<float>("TiLeGK")
                        .HasColumnType("real");

                    b.Property<float>("TiLeHK1")
                        .HasColumnType("real");

                    b.Property<float>("TiLeHK2")
                        .HasColumnType("real");

                    b.HasKey("MaMon");

                    b.ToTable("MonHocs");

                    b.HasData(
                        new
                        {
                            MaMon = 1,
                            HeSoMon = 1f,
                            Khoi = "A",
                            TenMH = "Toan",
                            TiLeCuoiKi = 0.8f,
                            TiLeGK = 0.2f,
                            TiLeHK1 = 0.4f,
                            TiLeHK2 = 0.6f
                        },
                        new
                        {
                            MaMon = 2,
                            HeSoMon = 1f,
                            Khoi = "A",
                            TenMH = "Van",
                            TiLeCuoiKi = 0.8f,
                            TiLeGK = 0.2f,
                            TiLeHK1 = 0.4f,
                            TiLeHK2 = 0.6f
                        },
                        new
                        {
                            MaMon = 3,
                            HeSoMon = 1f,
                            Khoi = "A",
                            TenMH = "Anh",
                            TiLeCuoiKi = 0.8f,
                            TiLeGK = 0.2f,
                            TiLeHK1 = 0.4f,
                            TiLeHK2 = 0.6f
                        });
                });

            modelBuilder.Entity("managerStudent.Models.QuanTri", b =>
                {
                    b.Property<int>("QuanTriID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("QuanTriID"));

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenDangNhap")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("QuanTriID");

                    b.ToTable("QuanTris");
                });

            modelBuilder.Entity("managerStudent.Models.Diem", b =>
                {
                    b.HasOne("managerStudent.Models.HocSinh", "HocSinh")
                        .WithMany("Diems")
                        .HasForeignKey("MaHS")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("managerStudent.Models.MonHoc", "MonHoc")
                        .WithMany("Diems")
                        .HasForeignKey("MaMon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HocSinh");

                    b.Navigation("MonHoc");
                });

            modelBuilder.Entity("managerStudent.Models.HocSinh", b =>
                {
                    b.HasOne("managerStudent.Models.Lop", "Lop")
                        .WithMany("HocSinhs")
                        .HasForeignKey("MaLop")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lop");
                });

            modelBuilder.Entity("managerStudent.Models.HocSinh", b =>
                {
                    b.Navigation("Diems");
                });

            modelBuilder.Entity("managerStudent.Models.Lop", b =>
                {
                    b.Navigation("HocSinhs");
                });

            modelBuilder.Entity("managerStudent.Models.MonHoc", b =>
                {
                    b.Navigation("Diems");
                });
#pragma warning restore 612, 618
        }
    }
}
