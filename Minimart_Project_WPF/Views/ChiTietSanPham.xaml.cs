using Microsoft.Win32;
using Minimart_Project_WPF.ViewModels;
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
    /// Interaction logic for ChiTietSanPham.xaml
    /// </summary>
    public partial class ChiTietSanPham : Window
    {
        public ChiTietSanPham()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen; // Set the startup location of the window to the center of the screen
        }

        private void btnChonAnh_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpeg;*.jpg)|*.png;*.jpeg;*.jpg|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                var bitmapImage = new BitmapImage(new Uri(openFileDialog.FileName));
                imgSanPham.Source = bitmapImage;
                var viewModel = (SanPhamViewModel)this.DataContext;
                viewModel.AnhSanPham = bitmapImage;
            }
        }
    }
}
