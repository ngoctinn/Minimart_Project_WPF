using Minimart_Project_WPF.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Minimart_Project_WPF.XuLyKhac
{
    public class TaoMaTuDong
    {
        public TaoMaTuDong()
        {
            //Tạo mã tự động
        }

         

        public string TaoMaTuDongSanPham()
        {
            using var context = new csassignmentContext();
            int soSanPham = context.SanPhams.Count();
            string maSanPham = string.Format("SPH{0:D4}", ++soSanPham);
            return maSanPham;
        }

        public string TaoMaTuDongLoaiSanPham()
        {
            using var context = new csassignmentContext();
            int soLoaiSanPham = context.LoaiSanPhams.Count();
            string maLoaiSanPham = string.Format("LSP{0:D4}", ++soLoaiSanPham);
            return maLoaiSanPham;
        }

    }
    
}
