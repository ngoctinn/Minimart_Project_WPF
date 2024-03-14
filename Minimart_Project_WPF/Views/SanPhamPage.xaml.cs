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
            members.Add(new Member { Number = 1,member = "Tín", Name = "Alice", Position = "Manager", Email = "alice@example.com", Phone = "0123456789" });
            members.Add(new Member { Number = 2,member= "Thư", Name = "Bob", Position = "Developer", Email = "bob@example.com", Phone = "9876543210" });
            members.Add(new Member { Number = 3,member = "Huy", Name = "Charlie", Position = "Designer", Email = "test@gmail.com", Phone = "1234567890" });
            members.Add(new Member { Number = 4, member = "Tín", Name = "David", Position = "Developer", Email = "test2@gmail.com", Phone = "02937472342" });
            members.Add(new Member { Number = 5, member = "Tín", Name = "David", Position = "Developer", Email = "t@gmail.com", Phone = "02937472342" });
            // Gán danh sách cho ItemsSource của datagrid
            membersDataGrid.ItemsSource = members;
        }
        public class Member
        {
            public string member { get; set; }
            public int Number { get; set; }
            public string Name { get; set; }
            public string Position { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
        }
    }
}
