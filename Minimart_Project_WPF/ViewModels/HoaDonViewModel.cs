using Minimart_Project_WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimart_Project_WPF.ViewModels
{
    public class HoaDonViewModel:BaseViewModel
    {
       private ObservableCollection<HoaDon> _HoaDons;
        public ObservableCollection<HoaDon> HoaDons
        {
            get { return _HoaDons; }
            set { _HoaDons = value; OnPropertyChanged(); }
        }
        public HoaDonViewModel()
        {
            LoadHoaDon();
        }
        private void LoadHoaDon()
        {
            using (var context = new csassignmentContext())
            {
                HoaDons = new ObservableCollection<HoaDon>(context.HoaDons.ToList());
            }
        }

        
    }
}
