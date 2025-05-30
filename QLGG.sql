USE [QLGG]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 5/30/2025 11:35:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HangSanXuat]    Script Date: 5/30/2025 11:35:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangSanXuat](
	[MaHSX] [nvarchar](450) NOT NULL,
	[TenHangSanXuat] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_HangSanXuat] PRIMARY KEY CLUSTERED 
(
	[MaHSX] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 5/30/2025 11:35:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [nvarchar](450) NOT NULL,
	[MaKH] [nvarchar](450) NOT NULL,
	[Manv] [nvarchar](450) NOT NULL,
	[NgayLap] [datetime2](7) NOT NULL,
	[GhiChuHoaDon] [nvarchar](max) NULL,
 CONSTRAINT [PK_HoaDon] PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HoaDon_ChiTiet]    Script Date: 5/30/2025 11:35:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon_ChiTiet](
	[MaHD_CT] [nvarchar](450) NOT NULL,
	[HoaDonID] [nvarchar](450) NOT NULL,
	[SanPhamID] [nvarchar](450) NOT NULL,
	[SoLuongBan] [int] NOT NULL,
	[DonGiaBan] [int] NOT NULL,
 CONSTRAINT [PK_HoaDon_ChiTiet] PRIMARY KEY CLUSTERED 
(
	[MaHD_CT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 5/30/2025 11:35:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[MaKH] [nvarchar](450) NOT NULL,
	[HoVaTen] [nvarchar](max) NOT NULL,
	[DienThoai] [nvarchar](max) NULL,
	[DiaChi] [nvarchar](max) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoaiSanPham]    Script Date: 5/30/2025 11:35:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoaiSanPham](
	[LoaiSanPhamID] [nvarchar](450) NOT NULL,
	[TenLoai] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_LoaiSanPham] PRIMARY KEY CLUSTERED 
(
	[LoaiSanPhamID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 5/30/2025 11:35:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[Manv] [nvarchar](450) NOT NULL,
	[HoVaTen] [nvarchar](max) NOT NULL,
	[DienThoai] [nvarchar](max) NULL,
	[DiaChi] [nvarchar](max) NULL,
	[TenDangNhap] [nvarchar](max) NOT NULL,
	[MatKhau] [nvarchar](max) NOT NULL,
	[QuyenHan] [int] NOT NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[Manv] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 5/30/2025 11:35:35 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[SanPhamID] [nvarchar](450) NOT NULL,
	[HangSanXuatID] [nvarchar](450) NOT NULL,
	[LoaiSanPhamID] [nvarchar](450) NOT NULL,
	[TenSanPham] [nvarchar](max) NOT NULL,
	[DonGia] [int] NOT NULL,
	[SoLuong] [int] NOT NULL,
	[HinhAnh] [nvarchar](max) NULL,
	[MoTa] [nvarchar](max) NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[SanPhamID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250405080219_CreateDatabase', N'9.0.3')
GO
INSERT [dbo].[HangSanXuat] ([MaHSX], [TenHangSanXuat]) VALUES (N'AOG5678', N'Asus')
INSERT [dbo].[HangSanXuat] ([MaHSX], [TenHangSanXuat]) VALUES (N'COR9101', N'Corsair')
INSERT [dbo].[HangSanXuat] ([MaHSX], [TenHangSanXuat]) VALUES (N'LOG1234', N'Logitech')
INSERT [dbo].[HangSanXuat] ([MaHSX], [TenHangSanXuat]) VALUES (N'MJR7093', N'HyperX')
INSERT [dbo].[HangSanXuat] ([MaHSX], [TenHangSanXuat]) VALUES (N'RAZ1234', N'Razer')
INSERT [dbo].[HangSanXuat] ([MaHSX], [TenHangSanXuat]) VALUES (N'UPP9473', N'Samsung')
GO
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [Manv], [NgayLap], [GhiChuHoaDon]) VALUES (N'HD1653', N'KH8394', N'NV7890', CAST(N'2025-05-28T10:10:50.0643069' AS DateTime2), N'')
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [Manv], [NgayLap], [GhiChuHoaDon]) VALUES (N'HD4051', N'KH5456', N'NV7890', CAST(N'2025-05-28T10:26:04.4982409' AS DateTime2), N'ádasd')
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [Manv], [NgayLap], [GhiChuHoaDon]) VALUES (N'HD6639', N'KH6989', N'NV7890', CAST(N'2025-05-28T09:59:52.4115002' AS DateTime2), N'12')
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [Manv], [NgayLap], [GhiChuHoaDon]) VALUES (N'HD7189', N'KH5456', N'NV3456', CAST(N'2025-05-28T10:12:49.8108832' AS DateTime2), N'')
GO
INSERT [dbo].[HoaDon_ChiTiet] ([MaHD_CT], [HoaDonID], [SanPhamID], [SoLuongBan], [DonGiaBan]) VALUES (N'1207', N'HD6639', N'SP5226', 1, 3650000)
INSERT [dbo].[HoaDon_ChiTiet] ([MaHD_CT], [HoaDonID], [SanPhamID], [SoLuongBan], [DonGiaBan]) VALUES (N'2597', N'HD6639', N'SP1965', 1, 2290000)
INSERT [dbo].[HoaDon_ChiTiet] ([MaHD_CT], [HoaDonID], [SanPhamID], [SoLuongBan], [DonGiaBan]) VALUES (N'2762', N'HD1653', N'SP5667', 1, 350000)
INSERT [dbo].[HoaDon_ChiTiet] ([MaHD_CT], [HoaDonID], [SanPhamID], [SoLuongBan], [DonGiaBan]) VALUES (N'2797', N'HD7189', N'SP6499', 1, 490000)
INSERT [dbo].[HoaDon_ChiTiet] ([MaHD_CT], [HoaDonID], [SanPhamID], [SoLuongBan], [DonGiaBan]) VALUES (N'3092', N'HD4051', N'SP5226', 1, 3650000)
INSERT [dbo].[HoaDon_ChiTiet] ([MaHD_CT], [HoaDonID], [SanPhamID], [SoLuongBan], [DonGiaBan]) VALUES (N'3145', N'HD7189', N'SP5226', 1, 3650000)
INSERT [dbo].[HoaDon_ChiTiet] ([MaHD_CT], [HoaDonID], [SanPhamID], [SoLuongBan], [DonGiaBan]) VALUES (N'3819', N'HD4051', N'SP5667', 1, 350000)
INSERT [dbo].[HoaDon_ChiTiet] ([MaHD_CT], [HoaDonID], [SanPhamID], [SoLuongBan], [DonGiaBan]) VALUES (N'4057', N'HD6639', N'SP6499', 1, 490000)
INSERT [dbo].[HoaDon_ChiTiet] ([MaHD_CT], [HoaDonID], [SanPhamID], [SoLuongBan], [DonGiaBan]) VALUES (N'4565', N'HD1653', N'SP9794', 1, 1290000)
INSERT [dbo].[HoaDon_ChiTiet] ([MaHD_CT], [HoaDonID], [SanPhamID], [SoLuongBan], [DonGiaBan]) VALUES (N'5122', N'HD6639', N'SP2649', 1, 2750000)
INSERT [dbo].[HoaDon_ChiTiet] ([MaHD_CT], [HoaDonID], [SanPhamID], [SoLuongBan], [DonGiaBan]) VALUES (N'5783', N'HD1653', N'SP5653', 1, 4390000)
INSERT [dbo].[HoaDon_ChiTiet] ([MaHD_CT], [HoaDonID], [SanPhamID], [SoLuongBan], [DonGiaBan]) VALUES (N'7278', N'HD7189', N'SP1965', 1, 2290000)
INSERT [dbo].[HoaDon_ChiTiet] ([MaHD_CT], [HoaDonID], [SanPhamID], [SoLuongBan], [DonGiaBan]) VALUES (N'7760', N'HD4051', N'SP9794', 1, 1290000)
INSERT [dbo].[HoaDon_ChiTiet] ([MaHD_CT], [HoaDonID], [SanPhamID], [SoLuongBan], [DonGiaBan]) VALUES (N'8120', N'HD1653', N'SP9798', 1, 2590000)
INSERT [dbo].[HoaDon_ChiTiet] ([MaHD_CT], [HoaDonID], [SanPhamID], [SoLuongBan], [DonGiaBan]) VALUES (N'9607', N'HD7189', N'SP2649', 1, 2750000)
GO
INSERT [dbo].[KhachHang] ([MaKH], [HoVaTen], [DienThoai], [DiaChi]) VALUES (N'KH5456', N'Trần Văn Bùi', N'0903113113', N'Thăng Long')
INSERT [dbo].[KhachHang] ([MaKH], [HoVaTen], [DienThoai], [DiaChi]) VALUES (N'KH6989', N'Bùi Hữu Nghĩa', N'0912989009', N'Hải Phòng')
INSERT [dbo].[KhachHang] ([MaKH], [HoVaTen], [DienThoai], [DiaChi]) VALUES (N'KH8393', N'Trần Thị B', N'0912345678', N'TP. HCM')
INSERT [dbo].[KhachHang] ([MaKH], [HoVaTen], [DienThoai], [DiaChi]) VALUES (N'KH8394', N'Lê Văn C', N'0908765432', N'Đà Nẵng')
INSERT [dbo].[KhachHang] ([MaKH], [HoVaTen], [DienThoai], [DiaChi]) VALUES (N'KH8395', N'Phạm Thị D', N'0987654321', N'Hải Phòng')
INSERT [dbo].[KhachHang] ([MaKH], [HoVaTen], [DienThoai], [DiaChi]) VALUES (N'KH8396', N'Hoàng Văn E', N'0971122334', N'Cần Thơ')
INSERT [dbo].[KhachHang] ([MaKH], [HoVaTen], [DienThoai], [DiaChi]) VALUES (N'KH8397', N'Bùi Thị F', N'0933445566', N'Bình Dương')
GO
INSERT [dbo].[LoaiSanPham] ([LoaiSanPhamID], [TenLoai]) VALUES (N'AWQ0987', N'Bàn phím')
INSERT [dbo].[LoaiSanPham] ([LoaiSanPhamID], [TenLoai]) VALUES (N'CHM5678', N'Chuột Gaming')
INSERT [dbo].[LoaiSanPham] ([LoaiSanPhamID], [TenLoai]) VALUES (N'LOT2345', N'Lót chuột')
INSERT [dbo].[LoaiSanPham] ([LoaiSanPhamID], [TenLoai]) VALUES (N'TAI9101', N'Tai nghe')
INSERT [dbo].[LoaiSanPham] ([LoaiSanPhamID], [TenLoai]) VALUES (N'ZUA9788', N'Sạc cáp')
GO
INSERT [dbo].[NhanVien] ([Manv], [HoVaTen], [DienThoai], [DiaChi], [TenDangNhap], [MatKhau], [QuyenHan]) VALUES (N'NV3456', N'Nguyễn Văn B', N'0987654321', N'Hà Nội', N'nvb', N'$2a$11$XVA.r9l5jP7EIddkhZdqXe7BDlJEM1ERTajL.Gaz4Gn4zWAeMjNrW', 1)
INSERT [dbo].[NhanVien] ([Manv], [HoVaTen], [DienThoai], [DiaChi], [TenDangNhap], [MatKhau], [QuyenHan]) VALUES (N'NV7890', N'Trần Thị C', N'0912345678', N'Hồ Chí Minh', N'ttc', N'$2a$11$.vfJ3wqbvGkY/NTSDyAz5OxjAOHdOxi1ijWcS0BqpnTovR7P.FJ1K', 0)
INSERT [dbo].[NhanVien] ([Manv], [HoVaTen], [DienThoai], [DiaChi], [TenDangNhap], [MatKhau], [QuyenHan]) VALUES (N'NV9031', N'Trần Văn Thiến', N'0912354556', N'Bình Dương', N'nhon', N'$2a$11$ooaFTzd1FBr5oGMYH4ovoeq4bevlxTy.pFmhETF8YW27LncO.yASu', 1)
GO
INSERT [dbo].[SanPham] ([SanPhamID], [HangSanXuatID], [LoaiSanPhamID], [TenSanPham], [DonGia], [SoLuong], [HinhAnh], [MoTa]) VALUES (N'SP1965', N'RAZ1234', N'CHM5678', N'DeathAdder V3 Hyperspeed', 2290000, 98, N'v3hyperspeed.jpg', N'')
INSERT [dbo].[SanPham] ([SanPhamID], [HangSanXuatID], [LoaiSanPhamID], [TenSanPham], [DonGia], [SoLuong], [HinhAnh], [MoTa]) VALUES (N'SP2171', N'MJR7093', N'TAI9101', N'Cloud Flight Wireless', 1990000, 100, N'cloudfight.jpg', N'')
INSERT [dbo].[SanPham] ([SanPhamID], [HangSanXuatID], [LoaiSanPhamID], [TenSanPham], [DonGia], [SoLuong], [HinhAnh], [MoTa]) VALUES (N'SP2649', N'RAZ1234', N'TAI9101', N'Barracuda X 2022', 2750000, 98, N'baracudax.jpg', N'')
INSERT [dbo].[SanPham] ([SanPhamID], [HangSanXuatID], [LoaiSanPhamID], [TenSanPham], [DonGia], [SoLuong], [HinhAnh], [MoTa]) VALUES (N'SP5226', N'RAZ1234', N'AWQ0987', N'Blackwidow V4 75%', 3650000, 97, N'blackwidowv4.jpg', N'')
INSERT [dbo].[SanPham] ([SanPhamID], [HangSanXuatID], [LoaiSanPhamID], [TenSanPham], [DonGia], [SoLuong], [HinhAnh], [MoTa]) VALUES (N'SP5653', N'AOG5678', N'AWQ0987', N'ROG Falchion RX Low Profile', 4390000, 99, N'h732.png', N'')
INSERT [dbo].[SanPham] ([SanPhamID], [HangSanXuatID], [LoaiSanPhamID], [TenSanPham], [DonGia], [SoLuong], [HinhAnh], [MoTa]) VALUES (N'SP5667', N'AOG5678', N'LOT2345', N'TUF Gaming P1', 350000, 98, N'tuf-gaming.jpg', N'')
INSERT [dbo].[SanPham] ([SanPhamID], [HangSanXuatID], [LoaiSanPhamID], [TenSanPham], [DonGia], [SoLuong], [HinhAnh], [MoTa]) VALUES (N'SP6499', N'RAZ1234', N'LOT2345', N'Gigantus v2 - Medium', 490000, 98, N'gigamtus.jpg', N'')
INSERT [dbo].[SanPham] ([SanPhamID], [HangSanXuatID], [LoaiSanPhamID], [TenSanPham], [DonGia], [SoLuong], [HinhAnh], [MoTa]) VALUES (N'SP9238', N'AOG5678', N'CHM5678', N'ROG SPATHA X', 3880000, 100, N'chuot-rog-spatha-x-wl-1-1.jpg', N'')
INSERT [dbo].[SanPham] ([SanPhamID], [HangSanXuatID], [LoaiSanPhamID], [TenSanPham], [DonGia], [SoLuong], [HinhAnh], [MoTa]) VALUES (N'SP9794', N'COR9101', N'TAI9101', N'HS35 Surround v2 Carbon', 1290000, 98, N'hs35.jpg', N'')
INSERT [dbo].[SanPham] ([SanPhamID], [HangSanXuatID], [LoaiSanPhamID], [TenSanPham], [DonGia], [SoLuong], [HinhAnh], [MoTa]) VALUES (N'SP9798', N'AOG5678', N'CHM5678', N'Rog Keris Wireless Aimpoint White', 2590000, 99, N'rogkeris.jpg', N'')
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_KhachHang_MaKH] FOREIGN KEY([MaKH])
REFERENCES [dbo].[KhachHang] ([MaKH])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_KhachHang_MaKH]
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_NhanVien_Manv] FOREIGN KEY([Manv])
REFERENCES [dbo].[NhanVien] ([Manv])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HoaDon] CHECK CONSTRAINT [FK_HoaDon_NhanVien_Manv]
GO
ALTER TABLE [dbo].[HoaDon_ChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_ChiTiet_HoaDon_HoaDonID] FOREIGN KEY([HoaDonID])
REFERENCES [dbo].[HoaDon] ([MaHD])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HoaDon_ChiTiet] CHECK CONSTRAINT [FK_HoaDon_ChiTiet_HoaDon_HoaDonID]
GO
ALTER TABLE [dbo].[HoaDon_ChiTiet]  WITH CHECK ADD  CONSTRAINT [FK_HoaDon_ChiTiet_SanPham_SanPhamID] FOREIGN KEY([SanPhamID])
REFERENCES [dbo].[SanPham] ([SanPhamID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HoaDon_ChiTiet] CHECK CONSTRAINT [FK_HoaDon_ChiTiet_SanPham_SanPhamID]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_HangSanXuat_HangSanXuatID] FOREIGN KEY([HangSanXuatID])
REFERENCES [dbo].[HangSanXuat] ([MaHSX])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_HangSanXuat_HangSanXuatID]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [FK_SanPham_LoaiSanPham_LoaiSanPhamID] FOREIGN KEY([LoaiSanPhamID])
REFERENCES [dbo].[LoaiSanPham] ([LoaiSanPhamID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [FK_SanPham_LoaiSanPham_LoaiSanPhamID]
GO
