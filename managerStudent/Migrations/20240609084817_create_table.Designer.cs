﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using managerStudent;

#nullable disable

namespace managerStudent.Migrations
{
    [DbContext(typeof(EFDbContext))]
    [Migration("20240609084817_create_table")]
    partial class create_table
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            MaHS = "MS001",
                            MaMon = 2,
                            DTB = 8.0m,
                            DiemCKHK1 = 8.0m,
                            DiemCKHK2 = 9.0m,
                            DiemGKHK1 = 7.5m,
                            DiemGKHK2 = 8.5m,
                            XepLoai = "Kha"
                        },
                        new
                        {
                            MaHS = "MS001",
                            MaMon = 3,
                            DTB = 8.0m,
                            DiemCKHK1 = 8.0m,
                            DiemCKHK2 = 9.0m,
                            DiemGKHK1 = 7.5m,
                            DiemGKHK2 = 8.5m,
                            XepLoai = "Kha"
                        },
                        new
                        {
                            MaHS = "MS001",
                            MaMon = 4,
                            DTB = 8.0m,
                            DiemCKHK1 = 8.0m,
                            DiemCKHK2 = 9.0m,
                            DiemGKHK1 = 7.5m,
                            DiemGKHK2 = 8.5m,
                            XepLoai = "Kha"
                        },
                        new
                        {
                            MaHS = "MS001",
                            MaMon = 5,
                            DTB = 8.0m,
                            DiemCKHK1 = 8.0m,
                            DiemCKHK2 = 9.0m,
                            DiemGKHK1 = 7.5m,
                            DiemGKHK2 = 8.5m,
                            XepLoai = "Kha"
                        },
                        new
                        {
                            MaHS = "MS001",
                            MaMon = 6,
                            DTB = 8.0m,
                            DiemCKHK1 = 8.0m,
                            DiemCKHK2 = 9.0m,
                            DiemGKHK1 = 7.5m,
                            DiemGKHK2 = 8.5m,
                            XepLoai = "Kha"
                        },
                        new
                        {
                            MaHS = "MS001",
                            MaMon = 7,
                            DTB = 8.0m,
                            DiemCKHK1 = 8.0m,
                            DiemCKHK2 = 9.0m,
                            DiemGKHK1 = 7.5m,
                            DiemGKHK2 = 8.5m,
                            XepLoai = "Kha"
                        },
                        new
                        {
                            MaHS = "MS001",
                            MaMon = 8,
                            DTB = 8.0m,
                            DiemCKHK1 = 8.0m,
                            DiemCKHK2 = 9.0m,
                            DiemGKHK1 = 7.5m,
                            DiemGKHK2 = 8.5m,
                            XepLoai = "Kha"
                        },
                        new
                        {
                            MaHS = "MS001",
                            MaMon = 9,
                            DTB = 8.0m,
                            DiemCKHK1 = 8.0m,
                            DiemCKHK2 = 9.0m,
                            DiemGKHK1 = 7.5m,
                            DiemGKHK2 = 8.5m,
                            XepLoai = "Kha"
                        },
                        new
                        {
                            MaHS = "MS001",
                            MaMon = 10,
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
                            MatKhau = "$2a$10$zgjnuumY1DA5B6mmTM5H1.WN7lrsqfZNy1hlC4mvgD19Kr6t9tVQ.",
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
                            MatKhau = "$2a$10$eO98NeGRRG23DRtsQzWR4O0YdFJ1QRsk928jR8E1LZut5NXAgrdGq",
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
                            MatKhau = "$2a$10$P2vnPllZHLMeqlbcnj00A.3UjXtoE9cubw1kR67IJtpo/OX74nDR2",
                            NgSinh = new DateTime(2002, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            NoiSinh = "Da Nang"
                        });
                });

            modelBuilder.Entity("managerStudent.Models.Khoi", b =>
                {
                    b.Property<int>("MaKhoi")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaKhoi"));

                    b.Property<string>("TenKhoi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaKhoi");

                    b.ToTable("Khois");

                    b.HasData(
                        new
                        {
                            MaKhoi = 1,
                            TenKhoi = "Khối 6"
                        },
                        new
                        {
                            MaKhoi = 2,
                            TenKhoi = "Khối 7"
                        },
                        new
                        {
                            MaKhoi = 3,
                            TenKhoi = "Khối 8"
                        },
                        new
                        {
                            MaKhoi = 4,
                            TenKhoi = "Khối 9"
                        });
                });

            modelBuilder.Entity("managerStudent.Models.Lop", b =>
                {
                    b.Property<int>("MaLop")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaLop"));

                    b.Property<int>("MaKhoi")
                        .HasColumnType("int");

                    b.Property<string>("NamHoc")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("TenLop")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("MaLop");

                    b.HasIndex("MaKhoi");

                    b.ToTable("Lops");

                    b.HasData(
                        new
                        {
                            MaLop = 1,
                            MaKhoi = 1,
                            NamHoc = "2023-2024",
                            TenLop = "6A/1"
                        },
                        new
                        {
                            MaLop = 2,
                            MaKhoi = 1,
                            NamHoc = "2023-2024",
                            TenLop = "6A/2"
                        },
                        new
                        {
                            MaLop = 3,
                            MaKhoi = 1,
                            NamHoc = "2023-2024",
                            TenLop = "6B/3"
                        },
                        new
                        {
                            MaLop = 4,
                            MaKhoi = 1,
                            NamHoc = "2023-2024",
                            TenLop = "6B/4"
                        },
                        new
                        {
                            MaLop = 5,
                            MaKhoi = 2,
                            NamHoc = "2023-2024",
                            TenLop = "7A/1"
                        },
                        new
                        {
                            MaLop = 6,
                            MaKhoi = 2,
                            NamHoc = "2023-2024",
                            TenLop = "7A/2"
                        },
                        new
                        {
                            MaLop = 7,
                            MaKhoi = 2,
                            NamHoc = "2023-2024",
                            TenLop = "7B/3"
                        },
                        new
                        {
                            MaLop = 8,
                            MaKhoi = 2,
                            NamHoc = "2023-2024",
                            TenLop = "7B/4"
                        },
                        new
                        {
                            MaLop = 9,
                            MaKhoi = 3,
                            NamHoc = "2023-2024",
                            TenLop = "8A/1"
                        },
                        new
                        {
                            MaLop = 10,
                            MaKhoi = 3,
                            NamHoc = "2023-2024",
                            TenLop = "8A/2"
                        },
                        new
                        {
                            MaLop = 11,
                            MaKhoi = 3,
                            NamHoc = "2023-2024",
                            TenLop = "8B/3"
                        },
                        new
                        {
                            MaLop = 12,
                            MaKhoi = 3,
                            NamHoc = "2023-2024",
                            TenLop = "8B/4"
                        },
                        new
                        {
                            MaLop = 13,
                            MaKhoi = 4,
                            NamHoc = "2023-2024",
                            TenLop = "9A/1"
                        },
                        new
                        {
                            MaLop = 14,
                            MaKhoi = 4,
                            NamHoc = "2023-2024",
                            TenLop = "9A/2"
                        },
                        new
                        {
                            MaLop = 15,
                            MaKhoi = 4,
                            NamHoc = "2023-2024",
                            TenLop = "9B/3"
                        },
                        new
                        {
                            MaLop = 16,
                            MaKhoi = 4,
                            NamHoc = "2023-2024",
                            TenLop = "9B/4"
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
                            TenMH = "Toán",
                            TiLeCuoiKi = 0.8f,
                            TiLeGK = 0.2f,
                            TiLeHK1 = 0.4f,
                            TiLeHK2 = 0.6f
                        },
                        new
                        {
                            MaMon = 2,
                            HeSoMon = 1f,
                            TenMH = "Văn",
                            TiLeCuoiKi = 0.8f,
                            TiLeGK = 0.2f,
                            TiLeHK1 = 0.4f,
                            TiLeHK2 = 0.6f
                        },
                        new
                        {
                            MaMon = 3,
                            HeSoMon = 1f,
                            TenMH = "Anh",
                            TiLeCuoiKi = 0.8f,
                            TiLeGK = 0.2f,
                            TiLeHK1 = 0.4f,
                            TiLeHK2 = 0.6f
                        },
                        new
                        {
                            MaMon = 4,
                            HeSoMon = 1f,
                            TenMH = "Lịch sử",
                            TiLeCuoiKi = 0.8f,
                            TiLeGK = 0.2f,
                            TiLeHK1 = 0.4f,
                            TiLeHK2 = 0.6f
                        },
                        new
                        {
                            MaMon = 5,
                            HeSoMon = 1f,
                            TenMH = "Địa lý",
                            TiLeCuoiKi = 0.8f,
                            TiLeGK = 0.2f,
                            TiLeHK1 = 0.4f,
                            TiLeHK2 = 0.6f
                        },
                        new
                        {
                            MaMon = 6,
                            HeSoMon = 1f,
                            TenMH = "Hóa học",
                            TiLeCuoiKi = 0.8f,
                            TiLeGK = 0.2f,
                            TiLeHK1 = 0.4f,
                            TiLeHK2 = 0.6f
                        },
                        new
                        {
                            MaMon = 7,
                            HeSoMon = 1f,
                            TenMH = "Sinh học",
                            TiLeCuoiKi = 0.8f,
                            TiLeGK = 0.2f,
                            TiLeHK1 = 0.4f,
                            TiLeHK2 = 0.6f
                        },
                        new
                        {
                            MaMon = 8,
                            HeSoMon = 1f,
                            TenMH = "Công nghệ",
                            TiLeCuoiKi = 0.8f,
                            TiLeGK = 0.2f,
                            TiLeHK1 = 0.4f,
                            TiLeHK2 = 0.6f
                        },
                        new
                        {
                            MaMon = 9,
                            HeSoMon = 1f,
                            TenMH = "Vật lý",
                            TiLeCuoiKi = 0.8f,
                            TiLeGK = 0.2f,
                            TiLeHK1 = 0.4f,
                            TiLeHK2 = 0.6f
                        },
                        new
                        {
                            MaMon = 10,
                            HeSoMon = 1f,
                            TenMH = "Giáo dục công dân",
                            TiLeCuoiKi = 0.8f,
                            TiLeGK = 0.2f,
                            TiLeHK1 = 0.4f,
                            TiLeHK2 = 0.6f
                        },
                        new
                        {
                            MaMon = 11,
                            HeSoMon = 1f,
                            TenMH = "Công dân",
                            TiLeCuoiKi = 0.8f,
                            TiLeGK = 0.2f,
                            TiLeHK1 = 0.4f,
                            TiLeHK2 = 0.6f
                        },
                        new
                        {
                            MaMon = 12,
                            HeSoMon = 1f,
                            TenMH = "Thể dục",
                            TiLeCuoiKi = 0.8f,
                            TiLeGK = 0.2f,
                            TiLeHK1 = 0.4f,
                            TiLeHK2 = 0.6f
                        },
                        new
                        {
                            MaMon = 13,
                            HeSoMon = 1f,
                            TenMH = "Âm nhạc",
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

                    b.HasData(
                        new
                        {
                            QuanTriID = 1,
                            MatKhau = "$2a$10$ZrE7rrnLoFg2zTEswr4FfOaaFh63jPSOnO3lqBrH2vos17dEoUXYy",
                            TenDangNhap = "admin"
                        });
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

            modelBuilder.Entity("managerStudent.Models.Lop", b =>
                {
                    b.HasOne("managerStudent.Models.Khoi", "Khoi")
                        .WithMany("Lops")
                        .HasForeignKey("MaKhoi")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Khoi");
                });

            modelBuilder.Entity("managerStudent.Models.HocSinh", b =>
                {
                    b.Navigation("Diems");
                });

            modelBuilder.Entity("managerStudent.Models.Khoi", b =>
                {
                    b.Navigation("Lops");
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
