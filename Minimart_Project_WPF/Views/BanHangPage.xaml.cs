using Minimart_Project_WPF.UserControls;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using static MaterialDesignThemes.Wpf.Theme;

namespace Minimart_Project_WPF.Views
{
    /// <summary>
    /// Interaction logic for BanHangPage.xaml
    /// </summary>
    public partial class BanHangPage : Page
    {
        private int totalMoney = 0;
        private BanHangViewModel  _viewModel;
        
        public BanHangPage()
        {
            InitializeComponent();

            

        }

        private void ProductUC_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Controls.Button button = sender as System.Windows.Controls.Button;
            if (button != null)
            {
                string moneyString = button.Content.ToString().Replace("đ", "").Replace(".", "");
                int moneyValue;
                if (int.TryParse(moneyString, out moneyValue))
                {
                    totalMoney += moneyValue;
                    TotalMoneyTextBlock.Text = string.Format("Khách đưa: "+"{0:N0}đ", totalMoney);
                }
            }
        }

        private void ProductUC_ProductSelected(object sender, EventArgs e)
        {
            var productUC = sender as ProductUC;
            if (productUC != null)
            {
                var productDetailUC = new ProductDetailUC
                {
                    DataContext = productUC.DataContext
                    
                };
                productDetailUC.DeleteClicked += ProductDetailUC_DeleteClicked;
                ProductDetailPanel.Children.Add(productDetailUC);
            }
        }
        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            totalMoney = 0;
            TotalMoneyTextBlock.Text = string.Format("Khách đưa: " + "{0:N0}đ", totalMoney);
        }

        private void ProductDetailUC_DeleteClicked(object sender, EventArgs e)
        {
            var productDetailUC = sender as ProductDetailUC;
            if (productDetailUC != null)
            {
                ProductDetailPanel.Children.Remove(productDetailUC);
            }
        }


    }
}
