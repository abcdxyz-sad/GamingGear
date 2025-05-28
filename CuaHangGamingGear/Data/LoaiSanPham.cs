using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangGamingGear.Data
{
    public class LoaiSanPham
    {
        [Key]
        public string LoaiSanPhamID { get; set; }
        public string TenLoai { get; set; }

        public virtual ObservableCollectionListSource<SanPham> SanPham { get; } = new();
    }
}
