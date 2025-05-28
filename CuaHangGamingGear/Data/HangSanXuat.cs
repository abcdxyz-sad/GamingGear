using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuaHangGamingGear.Data
{
    public class HangSanXuat
    {
        [Key]
        public string MaHSX { get; set; }
        public string TenHangSanXuat { get; set; }

        public virtual ObservableCollectionListSource<SanPham> SanPham { get; } = new();
    }
}
