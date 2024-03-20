using Minimart_Project_WPF.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Minimart_Project_WPF.Views
{
    /// <summary>
    /// Interaction logic for LoaiSanPhamPage.xaml
    /// </summary>
    public partial class LoaiSanPhamPage : Page
    {
        public LoaiSanPhamPage()
        {
            InitializeComponent();
        }

        private void ThemLoaiSanPham_Click(object sender, RoutedEventArgs e)
        {
            if (InputStackPanel.Visibility == Visibility.Collapsed)
            {
                InputStackPanel.Visibility = Visibility.Visible;
            }
            else
            {
                InputStackPanel.Visibility = Visibility.Collapsed;
            }
        }

        private void timKiemLoaiSanPham_TextChanged(object sender, TextChangedEventArgs e)
        {
            var filter = (sender as TextBox).Text.ToLower();
            var view = CollectionViewSource.GetDefaultView(membersDataGrid.ItemsSource);
            view.Filter = item => (item as LoaiSanPham).TenLoaiSanPham.ToLower().Contains(filter);
            view.Refresh();
        }
    }
}
