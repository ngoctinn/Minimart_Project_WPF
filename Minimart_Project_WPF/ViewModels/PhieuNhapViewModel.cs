using Minimart_Project_WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimart_Project_WPF.ViewModels
{
    public class PhieuNhapViewModel: BaseViewModel
    {
        private ObservableCollection<PhieuNhap> _PhieuNhaps;
        public ObservableCollection<PhieuNhap> PhieuNhaps
        {
            get { return _PhieuNhaps; }
            set { _PhieuNhaps = value; OnPropertyChanged(); }
        }
        public PhieuNhapViewModel()
        {
            LoadPhieuNhap();
        }
        private void LoadPhieuNhap()
        {
            using (var context = new csassignmentContext())
            {
                PhieuNhaps = new ObservableCollection<PhieuNhap>(context.PhieuNhaps.ToList());
            }
        }
    }
}
