using Minimart_Project_WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Minimart_Project_WPF.ViewModels
{
    public class LoaiSanPhamViewModel:BaseViewModel
    {
        public ObservableCollection<string> TrangThai { get; set; }
        private ObservableCollection<LoaiSanPham> _LoaiSanPhams;
        public ObservableCollection<LoaiSanPham> LoaiSanPhams
        {
            get { return _LoaiSanPhams; }
            set { _LoaiSanPhams = value; OnPropertyChanged(); }
        }
        public string MaLoaiSanPham { get; set; }
        public string  TenLoaiSanPham { get; set; }
        public string trangThai { get; set; }
        public ICommand AddLoaiSanPhamCommand { get; set; }

        public LoaiSanPhamViewModel()
        {
            LoadSanPhams();
            LoadTrangThai();
            AddLoaiSanPhamCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                using(var context = new csassignmentContext())
                {
                    var loaiSanPham = new LoaiSanPham()
                    {
                        MaLoaiSanPham = MaLoaiSanPham,
                        TenLoaiSanPham = TenLoaiSanPham,
                        TrangThai = trangThai
                    };
                    context.LoaiSanPhams.Add(loaiSanPham);
                    context.SaveChanges();
                    MessageBox.Show("Thêm loại sản phẩm thành công");
                    LoaiSanPhams.Add(loaiSanPham);
                }
            });

        }

        private void LoadSanPhams()
        {
            using (var context = new csassignmentContext())
            {
                LoaiSanPhams = new ObservableCollection<LoaiSanPham>(context.LoaiSanPhams.ToList());
            }
        }

        private void LoadTrangThai()
        {
            using (var context = new csassignmentContext())
            {
                TrangThai = new ObservableCollection<string>(context.LoaiSanPhams.Select(x => x.TrangThai).Distinct().ToList());
            }
        }


    }
}
