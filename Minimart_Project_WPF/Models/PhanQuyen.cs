using System;
using System.Collections.Generic;

namespace Minimart_Project_WPF.Models
{
    public partial class PhanQuyen
    {
        public PhanQuyen()
        {
            NguoiDungs = new HashSet<NguoiDung>();
        }

        public string MaPhanQuyen { get; set; } = null!;
        public string TenPhanQuyen { get; set; } = null!;

        public virtual ICollection<NguoiDung> NguoiDungs { get; set; }
    }
}
