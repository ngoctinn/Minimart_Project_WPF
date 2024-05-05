using Minimart_Project_WPF.Models;
using Minimart_Project_WPF.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Media;

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
        private ImageSource _anhSanPham;
        public ImageSource AnhSanPham
        {
            get { return _anhSanPham; }
            set
            {
                _anhSanPham = value;
                OnPropertyChanged("AnhSanPham");
            }
        }
        public byte[] AnhSanPhamAsBytes
        {
            get { return ImageSourceToBytes(AnhSanPham); }
            
        }

        private byte[] ImageSourceToBytes(ImageSource imageSource)
        {
            if (imageSource == null)
            {
                return null;
            }

            using (MemoryStream memoryStream = new MemoryStream())
            {
                BitmapEncoder encoder = new PngBitmapEncoder();
                encoder.Frames.Add(BitmapFrame.Create(imageSource as BitmapSource));
                encoder.Save(memoryStream);
                return memoryStream.ToArray();
            }
        }

        public string MaSanPham { get; set; }
        public string TenSanPham { get; set; }
        public string LoaiSanPhamSelected { get; set; }
        public string DonViTinh { get; set; }
        public decimal GiaBan { get; set; }
        public int SoLuong { get; set; }
        public string TrangThai { get; set; }

        public ICommand AddSanPhamCommand { get; set; }
        public SanPhamViewModel()
        {
            LoadSanPhams();
            LoadLoaiSanPham();
            AddSanPhamCommand = new RelayCommand<object>((p) => { return true; }, (p) =>
            {
                using (var context = new csassignmentContext())
                {
                    var sanPham = new SanPham
                    {

                        Anh = AnhSanPhamAsBytes,
                        MaSanPham = MaSanPham,
                        TenSanPham = TenSanPham,
                        MaLoaiSanPham = context.LoaiSanPhams.Where(x => x.TenLoaiSanPham == LoaiSanPhamSelected).Select(x => x.MaLoaiSanPham).FirstOrDefault(),
                        DonViTinh = DonViTinh,
                        GiaBan = GiaBan,
                        SoLuong = SoLuong,
                        TrangThai = TrangThai
                    };
                    context.SanPhams.Add(sanPham);
                    context.SaveChanges();
                    MessageBox.Show("Thêm sản phẩm thành công!");

                    // Close the form
                    Application.Current.Windows.OfType<ChiTietSanPham>().FirstOrDefault()?.Close();

                    // Reload the data
                    LoadSanPhams();
                }
            });

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
