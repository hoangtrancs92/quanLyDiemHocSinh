using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace managerStudent.Migrations
{
    /// <inheritdoc />
    public partial class create_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Khois",
                columns: table => new
                {
                    MaKhoi = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKhoi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Khois", x => x.MaKhoi);
                });

            migrationBuilder.CreateTable(
                name: "MonHocs",
                columns: table => new
                {
                    MaMon = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenMH = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HeSoMon = table.Column<float>(type: "real", nullable: false),
                    TiLeGK = table.Column<float>(type: "real", nullable: false),
                    TiLeCuoiKi = table.Column<float>(type: "real", nullable: false),
                    TiLeHK1 = table.Column<float>(type: "real", nullable: false),
                    TiLeHK2 = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonHocs", x => x.MaMon);
                });

            migrationBuilder.CreateTable(
                name: "QuanTris",
                columns: table => new
                {
                    QuanTriID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenDangNhap = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuanTris", x => x.QuanTriID);
                });

            migrationBuilder.CreateTable(
                name: "Lops",
                columns: table => new
                {
                    MaLop = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaKhoi = table.Column<int>(type: "int", nullable: false),
                    TenLop = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NamHoc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lops", x => x.MaLop);
                    table.ForeignKey(
                        name: "FK_Lops_Khois_MaKhoi",
                        column: x => x.MaKhoi,
                        principalTable: "Khois",
                        principalColumn: "MaKhoi",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HocSinhs",
                columns: table => new
                {
                    MaHS = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    HoTenHS = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NgSinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NoiSinh = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DanToc = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaLop = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocSinhs", x => x.MaHS);
                    table.ForeignKey(
                        name: "FK_HocSinhs_Lops_MaLop",
                        column: x => x.MaLop,
                        principalTable: "Lops",
                        principalColumn: "MaLop",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Diems",
                columns: table => new
                {
                    MaHS = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    MaMon = table.Column<int>(type: "int", nullable: false),
                    DiemGKHK1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiemCKHK1 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiemGKHK2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DiemCKHK2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DTB = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    XepLoai = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diems", x => new { x.MaHS, x.MaMon });
                    table.ForeignKey(
                        name: "FK_Diems_HocSinhs_MaHS",
                        column: x => x.MaHS,
                        principalTable: "HocSinhs",
                        principalColumn: "MaHS",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Diems_MonHocs_MaMon",
                        column: x => x.MaMon,
                        principalTable: "MonHocs",
                        principalColumn: "MaMon",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Khois",
                columns: new[] { "MaKhoi", "TenKhoi" },
                values: new object[,]
                {
                    { 1, "Khối 6" },
                    { 2, "Khối 7" },
                    { 3, "Khối 8" },
                    { 4, "Khối 9" }
                });

            migrationBuilder.InsertData(
                table: "MonHocs",
                columns: new[] { "MaMon", "HeSoMon", "TenMH", "TiLeCuoiKi", "TiLeGK", "TiLeHK1", "TiLeHK2" },
                values: new object[,]
                {
                    { 1, 1f, "Toán", 0.8f, 0.2f, 0.4f, 0.6f },
                    { 2, 1f, "Văn", 0.8f, 0.2f, 0.4f, 0.6f },
                    { 3, 1f, "Anh", 0.8f, 0.2f, 0.4f, 0.6f },
                    { 4, 1f, "Lịch sử", 0.8f, 0.2f, 0.4f, 0.6f },
                    { 5, 1f, "Địa lý", 0.8f, 0.2f, 0.4f, 0.6f },
                    { 6, 1f, "Hóa học", 0.8f, 0.2f, 0.4f, 0.6f },
                    { 7, 1f, "Sinh học", 0.8f, 0.2f, 0.4f, 0.6f },
                    { 8, 1f, "Công nghệ", 0.8f, 0.2f, 0.4f, 0.6f },
                    { 9, 1f, "Vật lý", 0.8f, 0.2f, 0.4f, 0.6f },
                    { 10, 1f, "Giáo dục công dân", 0.8f, 0.2f, 0.4f, 0.6f },
                    { 11, 1f, "Công dân", 0.8f, 0.2f, 0.4f, 0.6f },
                    { 12, 1f, "Thể dục", 0.8f, 0.2f, 0.4f, 0.6f },
                    { 13, 1f, "Âm nhạc", 0.8f, 0.2f, 0.4f, 0.6f }
                });

            migrationBuilder.InsertData(
                table: "QuanTris",
                columns: new[] { "QuanTriID", "MatKhau", "TenDangNhap" },
                values: new object[] { 1, "$2a$10$ZrE7rrnLoFg2zTEswr4FfOaaFh63jPSOnO3lqBrH2vos17dEoUXYy", "admin" });

            migrationBuilder.InsertData(
                table: "Lops",
                columns: new[] { "MaLop", "MaKhoi", "NamHoc", "TenLop" },
                values: new object[,]
                {
                    { 1, 1, "2023-2024", "6A/1" },
                    { 2, 1, "2023-2024", "6A/2" },
                    { 3, 1, "2023-2024", "6B/3" },
                    { 4, 1, "2023-2024", "6B/4" },
                    { 5, 2, "2023-2024", "7A/1" },
                    { 6, 2, "2023-2024", "7A/2" },
                    { 7, 2, "2023-2024", "7B/3" },
                    { 8, 2, "2023-2024", "7B/4" },
                    { 9, 3, "2023-2024", "8A/1" },
                    { 10, 3, "2023-2024", "8A/2" },
                    { 11, 3, "2023-2024", "8B/3" },
                    { 12, 3, "2023-2024", "8B/4" },
                    { 13, 4, "2023-2024", "9A/1" },
                    { 14, 4, "2023-2024", "9A/2" },
                    { 15, 4, "2023-2024", "9B/3" },
                    { 16, 4, "2023-2024", "9B/4" }
                });

            migrationBuilder.InsertData(
                table: "HocSinhs",
                columns: new[] { "MaHS", "DanToc", "GioiTinh", "HoTenHS", "MaLop", "MatKhau", "NgSinh", "NoiSinh" },
                values: new object[,]
                {
                    { "MS001", "Kinh", "Nam", "Nguyen Van A", 1, "$2a$10$zgjnuumY1DA5B6mmTM5H1.WN7lrsqfZNy1hlC4mvgD19Kr6t9tVQ.", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ha Noi" },
                    { "MS002", "Hoa", "Nu", "Tran Thi B", 2, "$2a$10$eO98NeGRRG23DRtsQzWR4O0YdFJ1QRsk928jR8E1LZut5NXAgrdGq", new DateTime(2001, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hai Phong" },
                    { "MS003", "Kinh", "Nam", "Le Van C", 1, "$2a$10$P2vnPllZHLMeqlbcnj00A.3UjXtoE9cubw1kR67IJtpo/OX74nDR2", new DateTime(2002, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Da Nang" }
                });

            migrationBuilder.InsertData(
                table: "Diems",
                columns: new[] { "MaHS", "MaMon", "DTB", "DiemCKHK1", "DiemCKHK2", "DiemGKHK1", "DiemGKHK2", "XepLoai" },
                values: new object[,]
                {
                    { "MS001", 1, 8.0m, 8.0m, 9.0m, 7.5m, 8.5m, "Kha" },
                    { "MS001", 2, 8.0m, 8.0m, 9.0m, 7.5m, 8.5m, "Kha" },
                    { "MS001", 3, 8.0m, 8.0m, 9.0m, 7.5m, 8.5m, "Kha" },
                    { "MS001", 4, 8.0m, 8.0m, 9.0m, 7.5m, 8.5m, "Kha" },
                    { "MS001", 5, 8.0m, 8.0m, 9.0m, 7.5m, 8.5m, "Kha" },
                    { "MS001", 6, 8.0m, 8.0m, 9.0m, 7.5m, 8.5m, "Kha" },
                    { "MS001", 7, 8.0m, 8.0m, 9.0m, 7.5m, 8.5m, "Kha" },
                    { "MS001", 8, 8.0m, 8.0m, 9.0m, 7.5m, 8.5m, "Kha" },
                    { "MS001", 9, 8.0m, 8.0m, 9.0m, 7.5m, 8.5m, "Kha" },
                    { "MS001", 10, 8.0m, 8.0m, 9.0m, 7.5m, 8.5m, "Kha" },
                    { "MS002", 1, 8.5m, 8.5m, 9.5m, 8.0m, 9.0m, "Gioi" },
                    { "MS003", 1, 7.0m, 7.0m, 8.0m, 6.5m, 7.5m, "Trung Binh" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Diems_MaMon",
                table: "Diems",
                column: "MaMon");

            migrationBuilder.CreateIndex(
                name: "IX_HocSinhs_MaLop",
                table: "HocSinhs",
                column: "MaLop");

            migrationBuilder.CreateIndex(
                name: "IX_Lops_MaKhoi",
                table: "Lops",
                column: "MaKhoi");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Diems");

            migrationBuilder.DropTable(
                name: "QuanTris");

            migrationBuilder.DropTable(
                name: "HocSinhs");

            migrationBuilder.DropTable(
                name: "MonHocs");

            migrationBuilder.DropTable(
                name: "Lops");

            migrationBuilder.DropTable(
                name: "Khois");
        }
    }
}
