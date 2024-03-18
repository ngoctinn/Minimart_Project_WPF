using System;
using System.Collections.Generic;

namespace Minimart_Project_WPF.Models
{
    public partial class NguoiDung
    {
        public NguoiDung()
        {
            HoaDons = new HashSet<HoaDon>();
            PhieuNhapMaNguoiDuyetNavigations = new HashSet<PhieuNhap>();
            PhieuNhapMaNguoiNhapNavigations = new HashSet<PhieuNhap>();
            PhieuNhapMaNguoiTaoNavigations = new HashSet<PhieuNhap>();
        }

        public string MaNguoiDung { get; set; } = null!;
        public string MaPhanQuyen { get; set; } = null!;
        public string TenDangNhap { get; set; } = null!;
        public string MatKhau { get; set; } = null!;
        public string HoTen { get; set; } = null!;
        public string? GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? SoDienThoai { get; set; }
        public string? Email { get; set; }
        public string? DiaChi { get; set; }
        public string TrangThai { get; set; } = null!;

        public virtual PhanQuyen MaPhanQuyenNavigation { get; set; } = null!;
        public virtual ICollection<HoaDon> HoaDons { get; set; }
        public virtual ICollection<PhieuNhap> PhieuNhapMaNguoiDuyetNavigations { get; set; }
        public virtual ICollection<PhieuNhap> PhieuNhapMaNguoiNhapNavigations { get; set; }
        public virtual ICollection<PhieuNhap> PhieuNhapMaNguoiTaoNavigations { get; set; }
    }
}
