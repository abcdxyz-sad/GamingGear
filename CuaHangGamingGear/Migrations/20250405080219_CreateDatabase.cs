using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CuaHangGamingGear.Migrations
{
    /// <inheritdoc />
    public partial class CreateDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HangSanXuat",
                columns: table => new
                {
                    MaHSX = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenHangSanXuat = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HangSanXuat", x => x.MaHSX);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    MaKH = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HoVaTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.MaKH);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSanPham",
                columns: table => new
                {
                    LoaiSanPhamID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenLoai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSanPham", x => x.LoaiSanPhamID);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    Manv = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HoVaTen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TenDangNhap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MatKhau = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuyenHan = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.Manv);
                });

            migrationBuilder.CreateTable(
                name: "SanPham",
                columns: table => new
                {
                    SanPhamID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HangSanXuatID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoaiSanPhamID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenSanPham = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DonGia = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    HinhAnh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPham", x => x.SanPhamID);
                    table.ForeignKey(
                        name: "FK_SanPham_HangSanXuat_HangSanXuatID",
                        column: x => x.HangSanXuatID,
                        principalTable: "HangSanXuat",
                        principalColumn: "MaHSX",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SanPham_LoaiSanPham_LoaiSanPhamID",
                        column: x => x.LoaiSanPhamID,
                        principalTable: "LoaiSanPham",
                        principalColumn: "LoaiSanPhamID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    MaHD = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaKH = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Manv = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NgayLap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GhiChuHoaDon = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.MaHD);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_MaKH",
                        column: x => x.MaKH,
                        principalTable: "KhachHang",
                        principalColumn: "MaKH",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_Manv",
                        column: x => x.Manv,
                        principalTable: "NhanVien",
                        principalColumn: "Manv",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon_ChiTiet",
                columns: table => new
                {
                    MaHD_CT = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HoaDonID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SanPhamID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SoLuongBan = table.Column<int>(type: "int", nullable: false),
                    DonGiaBan = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon_ChiTiet", x => x.MaHD_CT);
                    table.ForeignKey(
                        name: "FK_HoaDon_ChiTiet_HoaDon_HoaDonID",
                        column: x => x.HoaDonID,
                        principalTable: "HoaDon",
                        principalColumn: "MaHD",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_ChiTiet_SanPham_SanPhamID",
                        column: x => x.SanPhamID,
                        principalTable: "SanPham",
                        principalColumn: "SanPhamID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaKH",
                table: "HoaDon",
                column: "MaKH");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_Manv",
                table: "HoaDon",
                column: "Manv");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_ChiTiet_HoaDonID",
                table: "HoaDon_ChiTiet",
                column: "HoaDonID");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_ChiTiet_SanPhamID",
                table: "HoaDon_ChiTiet",
                column: "SanPhamID");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_HangSanXuatID",
                table: "SanPham",
                column: "HangSanXuatID");

            migrationBuilder.CreateIndex(
                name: "IX_SanPham_LoaiSanPhamID",
                table: "SanPham",
                column: "LoaiSanPhamID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HoaDon_ChiTiet");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "SanPham");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "HangSanXuat");

            migrationBuilder.DropTable(
                name: "LoaiSanPham");
        }
    }
}
