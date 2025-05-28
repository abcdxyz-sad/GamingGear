using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangGamingGear.Data
{
    public class KhachHang
    {
        [Key]
        public string MaKH { get; set; }
        public string HoVaTen { get; set; }
        public string? DienThoai { get; set; }
        public string? DiaChi { get; set; }

        public virtual ObservableCollectionListSource<HoaDon> HoaDon { get; } = new();
    }
}
