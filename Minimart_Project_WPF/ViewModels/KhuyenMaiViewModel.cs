using Minimart_Project_WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimart_Project_WPF.ViewModels
{
    public class KhuyenMaiViewModel : BaseViewModel
    {
        private ObservableCollection<KhuyenMai> _KhuyenMais;
        public ObservableCollection<KhuyenMai> KhuyenMais
        {
            get { return _KhuyenMais; }
            set { _KhuyenMais = value; OnPropertyChanged(); }
        }
        public KhuyenMaiViewModel()
        {
            LoadKhuyenMai();
        }
        private void LoadKhuyenMai()
        {
            using (var context = new csassignmentContext())
            {
                KhuyenMais = new ObservableCollection<KhuyenMai>(context.KhuyenMais.ToList());
            }
        }
    }
}
