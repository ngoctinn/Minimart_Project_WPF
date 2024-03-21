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
    /// Interaction logic for BanHangPage.xaml
    /// </summary>
    public partial class BanHangPage : Page
    {
        private int totalMoney = 0;
        public BanHangPage()
        {
            InitializeComponent();
        }

        private void ProductUC_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            if (button != null)
            {
                string moneyString = button.Content.ToString().Replace("đ", "").Replace(".", "");
                int moneyValue;
                if (int.TryParse(moneyString, out moneyValue))
                {
                    totalMoney += moneyValue;
                    TotalMoneyTextBlock.Text = string.Format("Số tiền khách đưa: "+"{0:N0}đ", totalMoney);
                }
            }
        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            TotalMoneyTextBlock.Text = "Số tiền khách đưa: 0đ";
        }
    }
}
