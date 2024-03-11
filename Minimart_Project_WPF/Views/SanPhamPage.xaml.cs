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
            List<Member> members = new List<Member>();

            // Thêm các đối tượng Member vào danh sách
            members.Add(new Member { Number = 1, Name = "Alice", Position = "Manager", Email = "alice@example.com", Phone = "0123456789" });
            members.Add(new Member { Number = 2, Name = "Bob", Position = "Developer", Email = "bob@example.com", Phone = "9876543210" });

            // Gán danh sách cho ItemsSource của datagrid
            membersDataGrid.ItemsSource = members;
        }
        public class Member
        {
            public int Number { get; set; }
            public string Name { get; set; }
            public string Position { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
        }
    }
}
