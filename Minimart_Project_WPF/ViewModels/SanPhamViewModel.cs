using Minimart_Project_WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Minimart_Project_WPF.ViewModels
{
    public class SanPhamViewModel : BaseViewModel
    {
        public ObservableCollection<string> LoaiSanPham { get; set; }
        private ObservableCollection<SanPham> _SanPhams;
        public ObservableCollection<SanPham> SanPhams
        {
            get { return _SanPhams; }
            set { _SanPhams = value; OnPropertyChanged(); }
        }
        public ICommand AddSanPhamCommand { get; set; }
        public SanPhamViewModel()
        {
            LoadSanPhams();

            LoadLoaiSanPham();

        }

        private void LoadLoaiSanPham()
        {
            using (var context = new csassignmentContext()  )
            {
                LoaiSanPham = new ObservableCollection<string>(context.LoaiSanPhams.Select(x => x.TenLoaiSanPham).ToList());
            }
        }

        private void LoadSanPhams()
        {
            using (var context = new csassignmentContext())
            {
                SanPhams = new ObservableCollection<SanPham>(context.SanPhams.ToList());
                
            }
        }
    }
}
