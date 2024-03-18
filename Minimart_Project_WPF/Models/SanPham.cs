using System;
using System.Collections.Generic;

namespace Minimart_Project_WPF.Models
{
    public partial class SanPham
    {
        public string MaSanPham { get; set; } = null!;
        public string MaLoaiSanPham { get; set; } = null!;
        public string TenSanPham { get; set; } = null!;
        public string DonViTinh { get; set; } = null!;
        public decimal GiaBan { get; set; }
        public int SoLuong { get; set; }
        public byte[] Anh { get; set; } = null!;
        public string TrangThai { get; set; } = null!;

        public virtual LoaiSanPham MaLoaiSanPhamNavigation { get; set; } = null!;
    }
}
