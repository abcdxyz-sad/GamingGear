using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangGamingGear.Data
{
    public class HoaDon_ChiTiet
    {
        [Key]
        public string MaHD_CT { get; set; }
        [ForeignKey("HoaDon")]
        public string HoaDonID { get; set; }
        [ForeignKey("SanPham")]
        public string SanPhamID { get; set; }
        public int SoLuongBan { get; set; }
        public int DonGiaBan { get; set; }

        public virtual HoaDon HoaDon { get; set; } = null!;
        public virtual SanPham SanPham { get; set; } = null!;
    }

    [NotMapped]
    public class DanhSachHoaDon_ChiTiet
    {
        [Key]
        public string MaHD_CT { get; set; }
        [ForeignKey("HoaDon")]
        public string HoaDonID { get; set; }
        [ForeignKey("SanPham")]
        public string SanPhamID { get; set; }
        public string TenSanPham { get; set; } // Thêm 
        public int SoLuongBan { get; set; }
        public int DonGiaBan { get; set; }
        public int ThanhTien { get; set; } // Thêm 
    }
}
