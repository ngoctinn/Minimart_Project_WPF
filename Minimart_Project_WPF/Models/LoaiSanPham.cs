using System;
using System.Collections.Generic;

namespace Minimart_Project_WPF.Models
{
    public partial class LoaiSanPham
    {
        public LoaiSanPham()
        {
            SanPhams = new HashSet<SanPham>();
        }

        public string MaLoaiSanPham { get; set; } = null!;
        public string TenLoaiSanPham { get; set; } = null!;
        public string TrangThai { get; set; } = null!;

        public virtual ICollection<SanPham> SanPhams { get; set; }
    }
}
