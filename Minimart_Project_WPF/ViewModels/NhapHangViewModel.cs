using Minimart_Project_WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimart_Project_WPF.ViewModels
{
    public class NhapHangViewModel: BaseViewModel
    {
        private ObservableCollection<SanPham> _Products;
        public ObservableCollection<SanPham> Products
        {
            get { return _Products; }
            set { _Products = value; OnPropertyChanged(); }
        }
        public NhapHangViewModel()
        {
            LoadProDucts();
        }
        private void LoadProDucts()
        {
            using (var context = new csassignmentContext())
            {
                Products = new ObservableCollection<SanPham>(context.SanPhams.ToList());
            }
        }
    }
}
