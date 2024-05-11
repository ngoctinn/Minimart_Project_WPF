using Minimart_Project_WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimart_Project_WPF.ViewModels
{
    public class TaiKhoanViewModel: BaseViewModel
    {
        private ObservableCollection<NguoiDung> _TaiKhoans;
        public ObservableCollection<NguoiDung> TaiKhoans
        {
            get { return _TaiKhoans; }
            set { _TaiKhoans = value; OnPropertyChanged(); }
        }
        public TaiKhoanViewModel()
        {
            LoadTaiKhoan();
        }
        private void LoadTaiKhoan()
        {
            using (var context = new csassignmentContext())
            {
                TaiKhoans = new ObservableCollection<NguoiDung>(context.NguoiDungs.ToList());
            }
        }
    }

}
