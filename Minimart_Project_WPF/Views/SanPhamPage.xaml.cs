using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Minimart_Project_WPF.Views
{
    /// <summary>
    /// Interaction logic for SanPhamPage.xaml
    /// </summary>
    public partial class SanPhamPage : Page
    {

        public SanPhamPage()
        {
            InitializeComponent();
            List<SanPham> sanpham = new List<SanPham>();

            // Thêm các đối tượng sản phẩm vào danh sách
            sanpham.Add(new SanPham() { maSanPham = 1, tenSanPham = "Bánh mì", loaiSanPham = "Thực phẩm", soLuong = "100", donVi = "cái" });
            sanpham.Add(new SanPham() { maSanPham = 2, tenSanPham = "Nước ngọt", loaiSanPham = "Thực phẩm", soLuong = "100", donVi = "chai" });
            sanpham.Add(new SanPham() { maSanPham = 3, tenSanPham = "Kẹo", loaiSanPham = "Thực phẩm", soLuong = "100", donVi = "cái" });
            sanpham.Add(new SanPham() { maSanPham = 4, tenSanPham = "Bánh quy", loaiSanPham = "Thực phẩm", soLuong = "100", donVi = "cái" });
            sanpham.Add(new SanPham() { maSanPham = 1, tenSanPham = "Bánh mì", loaiSanPham = "Thực phẩm", soLuong = "100", donVi = "cái" });
            sanpham.Add(new SanPham() { maSanPham = 2, tenSanPham = "Nước ngọt", loaiSanPham = "Thực phẩm", soLuong = "100", donVi = "chai" });
            sanpham.Add(new SanPham() { maSanPham = 3, tenSanPham = "Kẹo", loaiSanPham = "Thực phẩm", soLuong = "100", donVi = "cái" });
            sanpham.Add(new SanPham() { maSanPham = 4, tenSanPham = "Bánh quy", loaiSanPham = "Thực phẩm", soLuong = "100", donVi = "cái" });
            sanpham.Add(new SanPham() { maSanPham = 1, tenSanPham = "Bánh mì", loaiSanPham = "Thực phẩm", soLuong = "100", donVi = "cái" });
            sanpham.Add(new SanPham() { maSanPham = 2, tenSanPham = "Nước ngọt", loaiSanPham = "Thực phẩm", soLuong = "100", donVi = "chai" });
            sanpham.Add(new SanPham() { maSanPham = 3, tenSanPham = "Kẹo", loaiSanPham = "Thực phẩm", soLuong = "100", donVi = "cái" });
            sanpham.Add(new SanPham() { maSanPham = 4, tenSanPham = "Bánh quy", loaiSanPham = "Thực phẩm", soLuong = "100", donVi = "cái" });
            sanpham.Add(new SanPham() { maSanPham = 1, tenSanPham = "Bánh mì", loaiSanPham = "Thực phẩm", soLuong = "100", donVi = "cái" });
            sanpham.Add(new SanPham() { maSanPham = 2, tenSanPham = "Nước ngọt", loaiSanPham = "Thực phẩm", soLuong = "100", donVi = "chai" });
            sanpham.Add(new SanPham() { maSanPham = 3, tenSanPham = "Kẹo", loaiSanPham = "Thực phẩm", soLuong = "100", donVi = "cái" });
            sanpham.Add(new SanPham() { maSanPham = 4, tenSanPham = "Bánh quy", loaiSanPham = "Thực phẩm", soLuong = "100", donVi = "cái" });
            sanpham.Add(new SanPham() { maSanPham = 1, tenSanPham = "Bánh mì", loaiSanPham = "Thực phẩm", soLuong = "100", donVi = "cái" });
            sanpham.Add(new SanPham() { maSanPham = 2, tenSanPham = "Nước ngọt", loaiSanPham = "Thực phẩm", soLuong = "100", donVi = "chai" });
            sanpham.Add(new SanPham() { maSanPham = 3, tenSanPham = "Kẹo", loaiSanPham = "Thực phẩm", soLuong = "100", donVi = "cái" });
            sanpham.Add(new SanPham() { maSanPham = 4, tenSanPham = "Bánh quy", loaiSanPham = "Thực phẩm", soLuong = "100", donVi = "cái" });
            sanpham.Add(new SanPham() { maSanPham = 1, tenSanPham = "Bánh mì", loaiSanPham = "Thực phẩm", soLuong = "100", donVi = "cái" });
            sanpham.Add(new SanPham() { maSanPham = 2, tenSanPham = "Nước ngọt", loaiSanPham = "Thực phẩm", soLuong = "100", donVi = "chai" });
            sanpham.Add(new SanPham() { maSanPham = 3, tenSanPham = "Kẹo", loaiSanPham = "Thực phẩm", soLuong = "100", donVi = "cái" });
            sanpham.Add(new SanPham() { maSanPham = 4, tenSanPham = "Bánh quy", loaiSanPham = "Thực phẩm", soLuong = "100", donVi = "cái" });
            sanpham.Add(new SanPham() { maSanPham = 1, tenSanPham = "Bánh mì", loaiSanPham = "Thực phẩm", soLuong = "100", donVi = "cái" });
            sanpham.Add(new SanPham() { maSanPham = 2, tenSanPham = "Nước ngọt", loaiSanPham = "Thực phẩm", soLuong = "100", donVi = "chai" });
            sanpham.Add(new SanPham() { maSanPham = 3, tenSanPham = "Kẹo", loaiSanPham = "Thực phẩm", soLuong = "100", donVi = "cái" });
            sanpham.Add(new SanPham() { maSanPham = 4, tenSanPham = "Bánh quy", loaiSanPham = "Thực phẩm", soLuong = "100", donVi = "cái" });

            // Gán danh sách cho ItemsSource của datagrid
            membersDataGrid.ItemsSource = sanpham;
        }
        public class SanPham
        {
            public int maSanPham { get; set; }
            public string tenSanPham { get; set; }
            public string loaiSanPham { get; set; }
            public string soLuong { get; set; }
            public string donVi { get; set; }
            public int giaBan { get; set; }
            public bool trangThai { get; set; }
        }

    }
}
