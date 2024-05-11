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
    /// Interaction logic for KhachHangPage.xaml
    /// </summary>
    public partial class KhachHangPage : Page
    {
        public KhachHangPage()
        {
            InitializeComponent();
        }

        private void timKiemKhachHang_TextChanged(object sender, TextChangedEventArgs e)
        {
            var filter = (sender as TextBox).Text.ToLower();
            var view = CollectionViewSource.GetDefaultView(membersDataGrid.ItemsSource);
            view.Filter = item => (item as KhachHang).SoDienThoai.ToLower().Contains(filter);
            view.Refresh();
        }

        

        private void btnThemKhachHang_Click_2(object sender, RoutedEventArgs e)
        {
            Window window = new ChiTietKhachHang();
            window.ShowDialog();
        }
    }
}
