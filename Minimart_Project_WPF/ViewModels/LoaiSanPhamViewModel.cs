using Minimart_Project_WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimart_Project_WPF.ViewModels
{
    public class LoaiSanPhamViewModel:BaseViewModel
    {
        private ObservableCollection<LoaiSanPham> _LoaiSanPhams;
        public ObservableCollection<LoaiSanPham> LoaiSanPhams
        {
            get { return _LoaiSanPhams; }
            set { _LoaiSanPhams = value; OnPropertyChanged(); }
        }

        public LoaiSanPhamViewModel()
        {
            LoadSanPhams();

        }

        private void LoadSanPhams()
        {
            using (var context = new csassignmentContext())
            {
                LoaiSanPhams = new ObservableCollection<LoaiSanPham>(context.LoaiSanPhams.ToList());
            }
        }
    }
}
