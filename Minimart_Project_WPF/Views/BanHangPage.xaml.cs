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
                    TotalMoneyTextBlock.Text = string.Format("Số tiền khách đưa: "+"{0:N0}đ", totalMoney);
                }
            }
        }

        private void Button_Delete_Click(object sender, RoutedEventArgs e)
        {
            totalMoney = 0;
            TotalMoneyTextBlock.Text = string.Format("Số tiền khách đưa: " + "{0:N0}đ", totalMoney);
        }

        private void CloseTab_Click(object sender, RoutedEventArgs e)
        {
            // Cast the sender to a Button
            var button = sender as System.Windows.Controls.Button;

            // Find the parent TabItem of the button
            var tabItem = FindParent<TabItem>(button);

            // Find the parent TabControl of the TabItem
            System.Windows.Controls.TabControl tabControl = FindParent<System.Windows.Controls.TabControl>(tabItem);

            // Remove the TabItem from the TabControl
            if (tabControl != null)
            {
                tabControl.Items.Remove(tabItem);
            }
        }
        private int tabCount = 2; // Add this field to your class

        private void AddTab_Click(object sender, RoutedEventArgs e)
        {
            // Increment the tab count
            tabCount++;

            // Create new TabItem
            TabItem newTab = new TabItem();

            // Create Header with close button
            StackPanel headerPanel = new StackPanel { Orientation = Orientation.Horizontal};
            TextBlock headerText = new TextBlock { Text = "Giỏ hàng " + tabCount, Margin = new Thickness(0, 5, 25, 0) };
            System.Windows.Controls.Button closeButton = new System.Windows.Controls.Button
            {
                Height = 25,
                Width = 25,
                HorizontalAlignment = HorizontalAlignment.Right,
                VerticalAlignment = VerticalAlignment.Center,
                Style = (Style)FindResource("MaterialDesignIconForegroundButton"),
                ToolTip = "MaterialDesignIconForegroundButton",
            };
            closeButton.Click += CloseTab_Click;
            closeButton.Content = new MaterialDesignThemes.Wpf.PackIcon
            {
                Kind = MaterialDesignThemes.Wpf.PackIconKind.Close,
                Height = 20,
                Width = 20
            };

            headerPanel.Children.Add(headerText);
            headerPanel.Children.Add(closeButton);

            newTab.Header = headerPanel;

            // Add content to the new tab
            // Replace this with your actual content
            newTab.Content = new TextBlock { Text = "New Tab Content" };

            // Insert the new tab at the second last position (before the Add Tab button)
            int insertPos = MyTabControl.Items.Count - 1;
            MyTabControl.Items.Insert(insertPos, newTab);

            // Select the new tab
            MyTabControl.SelectedItem = newTab;
        }



        // Helper method to find the parent of a given child item
        private static T FindParent<T>(DependencyObject child) where T : DependencyObject
        {
            var parentObject = VisualTreeHelper.GetParent(child);

            if (parentObject == null) return null;

            T parent = parentObject as T;
            if (parent != null)
            {
                return parent;
            }
            else
            {
                return FindParent<T>(parentObject);
            }

        }

        






    }
}
