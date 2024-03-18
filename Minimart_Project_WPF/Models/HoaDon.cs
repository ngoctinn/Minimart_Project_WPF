using System;
using System.Collections.Generic;

namespace Minimart_Project_WPF.Models
{
    public partial class HoaDon
    {
        public string MaHoaDon { get; set; } = null!;
        public string MaNguoiTao { get; set; } = null!;
        public string? MaKhachHang { get; set; }
        public string? MaKhuyenMai { get; set; }
        public string? TenKhuyenMai { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public decimal ThanhTien { get; set; }
        public decimal GiamGia { get; set; }
        public decimal TongTien { get; set; }
        public decimal TienNhan { get; set; }
        public decimal TienThua { get; set; }

        public virtual KhachHang? MaKhachHangNavigation { get; set; }
        public virtual KhuyenMai? MaKhuyenMaiNavigation { get; set; }
        public virtual NguoiDung MaNguoiTaoNavigation { get; set; } = null!;
    }
}
