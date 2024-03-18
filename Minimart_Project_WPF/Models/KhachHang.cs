using System;
using System.Collections.Generic;

namespace Minimart_Project_WPF.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public string MaKhachHang { get; set; } = null!;
        public string HoTen { get; set; } = null!;
        public string SoDienThoai { get; set; } = null!;
        public string HangThanhVien { get; set; } = null!;
        public int DiemThanhVien { get; set; }
        public string TrangThai { get; set; } = null!;

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
