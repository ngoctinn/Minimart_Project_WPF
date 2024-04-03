using Microsoft.EntityFrameworkCore.ChangeTracking;
using Minimart_Project_WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimart_Project_WPF.ViewModels
{
    public class KhachHangViewModel:BaseViewModel
    {
        private ObservableCollection<KhachHang> _KhachHang;
        public ObservableCollection<KhachHang> KhachHang
        {
            get { return _KhachHang; }
            set { _KhachHang = value; OnPropertyChanged(); }
        }
        public KhachHangViewModel()
        {
            LoadKhachHang();
        }
        public void LoadKhachHang()
        {
            using (var context = new csassignmentContext())
            {
                KhachHang = new ObservableCollection<KhachHang>(context.KhachHangs.ToList());
            }
        }

    }
}
