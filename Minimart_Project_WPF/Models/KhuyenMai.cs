using System;
using System.Collections.Generic;

namespace Minimart_Project_WPF.Models
{
    public partial class KhuyenMai
    {
        public KhuyenMai()
        {
            HoaDons = new HashSet<HoaDon>();
        }

        public string MaKhuyenMai { get; set; } = null!;
        public string TenKhuyenMai { get; set; } = null!;
        public string LoaiGiaTri { get; set; } = null!;
        public double GiaTri { get; set; }
        public DateTime ThoiGianBatDau { get; set; }
        public DateTime ThoiGianKetThuc { get; set; }

        public virtual ICollection<HoaDon> HoaDons { get; set; }
    }
}
