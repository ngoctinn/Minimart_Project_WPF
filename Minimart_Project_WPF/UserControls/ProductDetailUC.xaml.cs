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

namespace Minimart_Project_WPF.UserControls
{
    /// <summary>
    /// Interaction logic for ProductDetailUC.xaml
    /// </summary>
    public partial class ProductDetailUC : UserControl
    {
        public event EventHandler DeleteClicked;
        public ProductDetailUC()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          DeleteClicked?.Invoke(this, e);
        }

        private void btnMinus_Click(object sender, RoutedEventArgs e)
        {
            int quantity = int.Parse(txtSoLuongSanPham.Text);
            if (quantity > 1)
            {
                quantity--;
                txtSoLuongSanPham.Text = quantity.ToString();
            }

        }

        private void btnPlus_Click(object sender, RoutedEventArgs e)
        {
            int quantity = int.Parse(txtSoLuongSanPham.Text);
            quantity++;
            txtSoLuongSanPham.Text = quantity.ToString();

        }
    }
}
