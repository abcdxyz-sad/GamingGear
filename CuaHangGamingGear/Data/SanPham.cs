﻿using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CuaHangGamingGear.Data
{
    public class SanPham
    {
        [Key]
        public string SanPhamID { get; set; }
        [ForeignKey("HangSanXuat")]
        public string HangSanXuatID { get; set; }
        [ForeignKey("LoaiSanPham")]
        public string LoaiSanPhamID { get; set; }
        public string TenSanPham { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public string? HinhAnh { get; set; }
        public string? MoTa { get; set; }

        public virtual ObservableCollectionListSource<HoaDon_ChiTiet> HoaDon_ChiTiet { get; } = new();
        public virtual LoaiSanPham LoaiSanPham { get; set; } = null!;
        public virtual HangSanXuat HangSanXuat { get; set; } = null!;
    }

    [NotMapped]
    public class DanhSachSanPham
    {
        [Key]
        public string SanPhamID { get; set; }
        [ForeignKey("HangSanXuat")]
        public string HangSanXuatID { get; set; }
        public string TenHangSanXuat { get; set; }  // Thêm 
        [ForeignKey("LoaiSanPham")]
        public string LoaiSanPhamID { get; set; }
        public string TenLoai { get; set; }         // Thêm 
        public string TenSanPham { get; set; }
        public int DonGia { get; set; }
        public int SoLuong { get; set; }
        public string? HinhAnh { get; set; }
        public string? MoTa { get; set; }
    }
}
