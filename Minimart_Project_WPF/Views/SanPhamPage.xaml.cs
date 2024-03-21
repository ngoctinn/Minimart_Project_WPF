using Minimart_Project_WPF.Models;
using Minimart_Project_WPF.UserControls;
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
            
        }

        private void tbTimKiem_TextChanged(object sender, TextChangedEventArgs e)
        {
            var filter = (sender as TextBox).Text.ToLower();
            var view = CollectionViewSource.GetDefaultView(membersDataGrid.ItemsSource);
            view.Filter = item => (item as SanPham).TenSanPham.ToLower().Contains(filter);
            view.Refresh();
        }

        private void Button_Click_ThemSanPham(object sender, RoutedEventArgs e)
        {
           ChiTietSanPham chiTietSanPham = new ChiTietSanPham();
            chiTietSanPham.ShowDialog();
          
        }

        
    }
}
