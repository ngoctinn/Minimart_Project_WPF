using System;
using System.Collections.Generic;

namespace Minimart_Project_WPF.Models
{
    public partial class ChiTietPhieuNhap
    {
        public string MaPhieuNhap { get; set; } = null!;
        public string MaSanPham { get; set; } = null!;
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal ThanhTien { get; set; }

        public virtual PhieuNhap MaPhieuNhapNavigation { get; set; } = null!;
        public virtual SanPham MaSanPhamNavigation { get; set; } = null!;
    }
}
