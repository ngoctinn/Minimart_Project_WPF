using System;
using System.Collections.Generic;

namespace Minimart_Project_WPF.Models
{
    public partial class NhaCungCap
    {
        public NhaCungCap()
        {
            PhieuNhaps = new HashSet<PhieuNhap>();
        }

        public string MaNhaCungCap { get; set; } = null!;
        public string TenNhaCungCap { get; set; } = null!;
        public string? SoDienThoai { get; set; }
        public string? Email { get; set; }
        public string? DiaChi { get; set; }
        public string TrangThai { get; set; } = null!;

        public virtual ICollection<PhieuNhap> PhieuNhaps { get; set; }
    }
}
