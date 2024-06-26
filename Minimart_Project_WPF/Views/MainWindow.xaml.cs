﻿using Minimart_Project_WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LoginViewModel.UserRoleChanged += OnUserRoleChanged;
        }
        private void BG_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Tg_Btn.IsChecked = false;
        }

        // Start: MenuLeft PopupButton //
        private void btnThongKe_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnThongKe;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Home";
            }
        }

        private void btnThongKe_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnSanPham_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnSanPham;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Sản phẩm";
            }
        }

        private void btnSanPham_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnBanHang_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnBanHang;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Bán hàng";
            }
        }

        private void btnBanHang_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnLoaiSanPham_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnLoaiSanPham;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Loại sản phẩm";
            }
        }

        private void btnLoaiSanPham_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnKhachHang_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnKhachHang;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Khách hàng";
            }
        }

        private void btnKhachHang_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }
        private void btnKhuyenMai_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnKhuyenMai;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Khuyến mãi";
            }
        }

        private void btnKhuyenMai_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnPhieuNhap_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnPhieuNhap;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Phiếu Nhập";
            }
        }

        private void btnPhieuNhap_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnHoaDon_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnHoaDon;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Hoá đơn";
            }
        }

        private void btnHoaDon_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnNhapKho_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnNhapKho;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Nhập Kho";
            }
        }

        private void btnNhapKho_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }
        private void btnNhaCungCap_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnNhaCungCap;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Nhà cung cấp";
            }
        }

        private void btnNhaCungCap_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }

        private void btnTaiKhoan_MouseEnter(object sender, MouseEventArgs e)
        {
            if (Tg_Btn.IsChecked == false)
            {
                Popup.PlacementTarget = btnTaiKhoan;
                Popup.Placement = PlacementMode.Right;
                Popup.IsOpen = true;
                Header.PopupText.Text = "Tài khoản";
            }
        }

        private void btnTaiKhoan_MouseLeave(object sender, MouseEventArgs e)
        {
            Popup.Visibility = Visibility.Collapsed;
            Popup.IsOpen = false;
        }
        // End: MenuLeft PopupButton //

        // Start: Button Close | Restore | Minimize 
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnRestore_Click(object sender, RoutedEventArgs e)
        {
            if (WindowState == WindowState.Normal)
                WindowState = WindowState.Maximized;
            else
                WindowState = WindowState.Normal;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        // End: Button Close | Restore | Minimize

        private void btnThongKe_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Views/Home.xaml", UriKind.RelativeOrAbsolute));
        }

        private void btnSanPham_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Views/SanPhamPage.xaml", UriKind.RelativeOrAbsolute));
        }
        private void btnBanHang_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Views/BanHangPage.xaml", UriKind.RelativeOrAbsolute));
        }
        private void btnLoaiSanPham_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Views/LoaiSanPhamPage.xaml", UriKind.RelativeOrAbsolute));
        }
        private void btnKhachHang_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Views/KhachHangPage.xaml", UriKind.RelativeOrAbsolute));
        }
        private void btnKhuyenMai_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Views/KhuyenMaiPage.xaml", UriKind.RelativeOrAbsolute));
        }
        private void btnPhieuNhap_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Views/PhieuNhapPage.xaml", UriKind.RelativeOrAbsolute));
        }
        private void btnTaiKhoan_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Views/TaiKhoanPage.xaml", UriKind.RelativeOrAbsolute));
        }
        private void btnHoaDon_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Views/HoaDonPage.xaml", UriKind.RelativeOrAbsolute));
        }
        private void btnNhaCungCap_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Views/NhaCungCapPage.xaml", UriKind.RelativeOrAbsolute));
        }
        private void btnNhapKho_Click(object sender, RoutedEventArgs e)
        {
            fContainer.Navigate(new System.Uri("Views/NhapHangPage.xaml", UriKind.RelativeOrAbsolute));
        }

        //Thực hiện chức năng phân quyền người dùng 
        private void OnUserRoleChanged(string role)
        {
            switch (role)
            {
                case "PQ01":
                    // Hide the buttons for this role
                    btnTaiKhoan.Visibility = Visibility.Visible;
                    btnThongKe.Visibility = Visibility.Visible;
                    
                    // Repeat for other buttons
                    break;

                case "PQ02":
                    // Handle the visibility for this role
                   
                    btnSanPham.Visibility = Visibility.Visible;
                    btnBanHang.Visibility = Visibility.Visible;
                    btnLoaiSanPham.Visibility = Visibility.Visible;
                    btnKhachHang.Visibility = Visibility.Visible;
                    btnKhuyenMai.Visibility = Visibility.Visible;
                    btnPhieuNhap.Visibility = Visibility.Visible;
                    btnHoaDon.Visibility = Visibility.Visible;
                    btnNhapKho.Visibility = Visibility.Visible;
                    btnNhaCungCap.Visibility = Visibility.Visible;
                    btnTaiKhoan.Visibility = Visibility.Visible;
                    btnThongKe.Visibility = Visibility.Visible;
                    break;

                case "PQ03":
                    // Handle the visibility for this role
                    break;

                case "PQ04":
                    // Handle the visibility for this role
                    break;

                default:
                    // Handle the visibility for unknown roles
                    break;
            }
        }

        
    }
}
