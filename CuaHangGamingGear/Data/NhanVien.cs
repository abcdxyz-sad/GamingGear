using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangGamingGear.Data
{
    public class NhanVien
    {
        [Key]
        public string Manv { get; set; }
        public string HoVaTen { get; set; }
        public string? DienThoai { get; set; }
        public string? DiaChi { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public int QuyenHan { get; set; }

        public virtual ObservableCollectionListSource<HoaDon> HoaDon { get; } = new();
    }
}
