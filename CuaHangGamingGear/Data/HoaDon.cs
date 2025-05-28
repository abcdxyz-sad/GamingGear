using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangGamingGear.Data
{
    public class HoaDon
    {
        [Key]
        public string MaHD { get; set; }
        [ForeignKey("KhachHang")]
        public string MaKH { get; set; }
        [ForeignKey("NhanVien")]
        public string Manv { get; set; }
        public DateTime NgayLap { get; set; }
        public string? GhiChuHoaDon { get; set; }

        public virtual ObservableCollectionListSource<HoaDon_ChiTiet> HoaDon_ChiTiet { get; } = new();
        public virtual KhachHang KhachHang { get; set; } = null!;
        public virtual NhanVien NhanVien { get; set; } = null!;
    }

    [NotMapped]
    public class DanhSachHoaDon
    {
        [Key]
        public string MaHD { get; set; }
        [ForeignKey("NhanVien")]
        public string Manv { get; set; }
        public string HoVaTenNhanVien { get; set; } // Thêm 
        [ForeignKey("KhachHang")]
        public string MaKH { get; set; }
        public string HoVaTenKhachHang { get; set; } // Thêm 
        public DateTime NgayLap { get; set; }
        public string? GhiChuHoaDon { get; set; }
        public string? XemChiTiet { get; set; }  // Thêm 
        public double? TongTienHoaDon { get; set; } // Thêm 
    }
}
