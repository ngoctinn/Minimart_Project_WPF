using Minimart_Project_WPF.Models;
using Minimart_Project_WPF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Minimart_Project_WPF.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _UserName;
        public string UserName { get => _UserName; set { _UserName = value; OnPropertyChanged(); } }
        private string _Password;
        public string Password { get => _Password; set { _Password = value; OnPropertyChanged(); } }
        public bool IsLogin { get; set; }
        public ICommand PasswordChangedCommand { get; set; }
        public ICommand LoginCommand { get; set; }
        public static Action<string> UserRoleChanged { get; internal set; }

        private bool loginWindowShown = false;



        public LoginViewModel()
        {
            Password = "";
            UserName = "";
            IsLogin = false;
            LoginCommand = new RelayCommand<Window>((p) => { return true; }, (p) => { Login(p); });
            PasswordChangedCommand = new RelayCommand<PasswordBox>((p) => { return true; }, (p) => { if (p != null) Password = p.Password; });
        }

        void Login(Window p)
        {
            if (p == null)
                return;
            var context = new csassignmentContext();
            var count = context.NguoiDungs.Where(x => x.TenDangNhap == UserName && x.MatKhau == Password).Count();
            if (count > 0)
            {
                kiemTraPhanQuyen();
                IsLogin = true;
                p.Close();
            }
            else
            {
                IsLogin = false;
                MessageBox.Show("Thông tin tài khoản hoặc mật khẩu không chính xác");
            }
        }
        void kiemTraPhanQuyen()
        {
            var context = new csassignmentContext();
            var role = context.NguoiDungs.Where(x => x.TenDangNhap == UserName && x.MatKhau == Password).Select(x => x.MaPhanQuyen).FirstOrDefault();
            UserRoleChanged?.Invoke(role);
        }
    }
}
