using System;
using System.Collections.Generic;

namespace Minimart_Project_WPF.Models
{
    public partial class PhieuNhap
    {
        public string MaPhieuNhap { get; set; } = null!;
        public string MaNhaCungCap { get; set; } = null!;
        public string MaNguoiTao { get; set; } = null!;
        public string? MaNguoiDuyet { get; set; }
        public string? MaNguoiNhap { get; set; }
        public DateTime ThoiGianTao { get; set; }
        public DateTime? ThoiGianDuyet { get; set; }
        public DateTime? ThoiGianNhap { get; set; }
        public decimal TongTien { get; set; }
        public string TrangThai { get; set; } = null!;

        public virtual NguoiDung? MaNguoiDuyetNavigation { get; set; }
        public virtual NguoiDung? MaNguoiNhapNavigation { get; set; }
        public virtual NguoiDung MaNguoiTaoNavigation { get; set; } = null!;
        public virtual NhaCungCap MaNhaCungCapNavigation { get; set; } = null!;
    }
}
