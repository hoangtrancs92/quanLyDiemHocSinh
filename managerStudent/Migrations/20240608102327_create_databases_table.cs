using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace managerStudent.Migrations
{
    /// <inheritdoc />
    public partial class create_databases_table : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Lops",
                columns: table => new
                {
                    MaLop = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLop = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NamHoc = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lops", x => x.MaLop);
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
                    TiLeHK2 = table.Column<float>(type: "real", nullable: false),
                    Khoi = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
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
                table: "Lops",
                columns: new[] { "MaLop", "NamHoc", "TenLop" },
                values: new object[,]
                {
                    { 1, "2023-2024", "10A" },
                    { 2, "2023-2024", "10B" },
                    { 3, "2024-2025", "11A" }
                });

            migrationBuilder.InsertData(
                table: "MonHocs",
                columns: new[] { "MaMon", "HeSoMon", "Khoi", "TenMH", "TiLeCuoiKi", "TiLeGK", "TiLeHK1", "TiLeHK2" },
                values: new object[,]
                {
                    { 1, 1f, "A", "Toan", 0.8f, 0.2f, 0.4f, 0.6f },
                    { 2, 1f, "A", "Van", 0.8f, 0.2f, 0.4f, 0.6f },
                    { 3, 1f, "A", "Anh", 0.8f, 0.2f, 0.4f, 0.6f }
                });

            migrationBuilder.InsertData(
                table: "HocSinhs",
                columns: new[] { "MaHS", "DanToc", "GioiTinh", "HoTenHS", "MaLop", "MatKhau", "NgSinh", "NoiSinh" },
                values: new object[,]
                {
                    { "MS001", "Kinh", "Nam", "Nguyen Van A", 1, "$2a$10$x.mfgx7HGEyWDD0uUWo8qe.h68cKhf9tJakhKO8YzGOspgyx4I4D.", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ha Noi" },
                    { "MS002", "Hoa", "Nu", "Tran Thi B", 2, "$2a$10$e68qs4Kmgz5q/hDHisbHGei.oSWp3HpSnc9epJOVhqTO9JqPs98Cq", new DateTime(2001, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hai Phong" },
                    { "MS003", "Kinh", "Nam", "Le Van C", 1, "$2a$10$/MgqXwAYQ5U/Hy1NlrHdGOMlSgWKPHzY6/Nec9omZW2eBf6LbOsY2", new DateTime(2002, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Da Nang" }
                });

            migrationBuilder.InsertData(
                table: "Diems",
                columns: new[] { "MaHS", "MaMon", "DTB", "DiemCKHK1", "DiemCKHK2", "DiemGKHK1", "DiemGKHK2", "XepLoai" },
                values: new object[,]
                {
                    { "MS001", 1, 8.0m, 8.0m, 9.0m, 7.5m, 8.5m, "Kha" },
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
        }
    }
}
