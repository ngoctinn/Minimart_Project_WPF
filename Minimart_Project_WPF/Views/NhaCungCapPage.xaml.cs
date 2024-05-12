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
    /// Interaction logic for NhaCungCapPage.xaml
    /// </summary>
    public partial class NhaCungCapPage : Page
    {
        public NhaCungCapPage()
        {
            InitializeComponent();
        }

        

        private void btnThemNhaCungCap_Click(object sender, RoutedEventArgs e)
        {
            Window window = new ChiTietNhaCungCap();
            window.ShowDialog();
        }
    }
}
