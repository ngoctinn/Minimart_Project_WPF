using Minimart_Project_WPF.ViewModels;
using Minimart_Project_WPF.XuLyKhac;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace Minimart_Project_WPF.Views
{
    /// <summary>
    /// Interaction logic for ChiTietLoaiSanPham.xaml
    /// </summary>
    public partial class ChiTietLoaiSanPham : Window
    {
        public ChiTietLoaiSanPham()
        {
            InitializeComponent();

            // Center the window on the screen
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            TaoMaTuDong taoMaTuDong = new TaoMaTuDong();
            var viewModel = (LoaiSanPhamViewModel)this.DataContext;
            viewModel.MaLoaiSanPham = taoMaTuDong.TaoMaTuDongLoaiSanPham();
            txtMaLoaiSanPham.Text = viewModel.MaLoaiSanPham;
        }
    }
}
