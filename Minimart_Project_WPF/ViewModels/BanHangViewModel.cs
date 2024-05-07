using Minimart_Project_WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimart_Project_WPF.ViewModels
{
    public class BanHangViewModel : BaseViewModel
    {
 
        private ObservableCollection<SanPham> _products;

        public ObservableCollection<SanPham> Products
        {
            get { return _products; }
            set
            {
                _products = value;
                OnPropertyChanged(nameof(Products));
            }
        }

        public BanHangViewModel()
        {
            LoadProductsFromDatabase();
        }

        private void LoadProductsFromDatabase()
        {
            using (var context = new csassignmentContext())
            {
                Products = new ObservableCollection<SanPham>(context.SanPhams.ToList());
            }
        }

    }
}
