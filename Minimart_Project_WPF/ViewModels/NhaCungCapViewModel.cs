using Minimart_Project_WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimart_Project_WPF.ViewModels
{
    public class NhaCungCapViewModel:BaseViewModel
    {
        private ObservableCollection<NhaCungCap> _nhaCungCaps;
        public ObservableCollection<NhaCungCap> NhaCungCaps
        {
            get { return _nhaCungCaps; }
            set
            {
                _nhaCungCaps = value;
                OnPropertyChanged(nameof(NhaCungCaps));
            }
        }
        public NhaCungCapViewModel()
        {
            LoadNhaCungCapFromDatabase();
        }
        private void LoadNhaCungCapFromDatabase()
        {
            using (var context = new csassignmentContext())
            {
                NhaCungCaps = new ObservableCollection<NhaCungCap>(context.NhaCungCaps.ToList());
            }
        }
        
    }
}
