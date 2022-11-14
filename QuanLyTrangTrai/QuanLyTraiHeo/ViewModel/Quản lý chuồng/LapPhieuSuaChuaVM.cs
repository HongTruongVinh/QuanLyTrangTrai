using QuanLyTraiHeo.Model;
using QuanLyTraiHeo.View.Windows;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace QuanLyTraiHeo.ViewModel
{
    public class LapPhieuSuaChuaVM : BaseViewModel
    {
        #region Attributes
        private ObservableCollection<PHIEUSUACHUA> _ListPhieuSuaChua;
        private string _MaNhanVien = "";
        PHIEUSUACHUA _SelectedItem;
        private DateTime? _NgaySuaChua = DateTime.MinValue;
        private string _TenDoiTac = "";
        private List<string> _ListTrangThai = new List<string>();
        #endregion

        #region Property
        public ObservableCollection<PHIEUSUACHUA> ListPhieuSuaChua { get => _ListPhieuSuaChua; set { _ListPhieuSuaChua = value; OnPropertyChanged(); } }
        public string MaNhanVien { get => _MaNhanVien; set { _MaNhanVien = value; OnPropertyChanged(); } }
        public DateTime? NgaySuaChua { get => _NgaySuaChua; set { _NgaySuaChua = value; OnPropertyChanged(); } }
        public string TenDoiTac { get => _TenDoiTac; set { _TenDoiTac = value; OnPropertyChanged(); } }
        public List<string> ListTrangThai { get => _ListTrangThai; set { _ListTrangThai = value; OnPropertyChanged(); } }
        public PHIEUSUACHUA SelectedItem
        {
            get => _SelectedItem;
            set
            {
                _SelectedItem = value; OnPropertyChanged();
            }
        }
        #endregion

        #region Command
        public ICommand AddCommand { get; set; }
        public ICommand ShowCommand { get; set; }
        public ICommand EditCommand { get; set; }
        public ICommand DeleteCommand { get; set; }
        public ICommand TimKiemTheoMaNVCommand { get; set; }
        public ICommand TimKiemTheoNgaySCCommand { get; set; }
        public ICommand TimKiemTheoTrangThaiCommand { get; set; }
        #endregion

        public LapPhieuSuaChuaVM()
        {
            _ListPhieuSuaChua = new ObservableCollection<PHIEUSUACHUA>(DataProvider.Ins.DB.PHIEUSUACHUAs);
            AddCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                PhieuSuaChua phieuSuaChua = new PhieuSuaChua();
                phieuSuaChua.ShowDialog();
                ListPhieuSuaChua = new ObservableCollection<PHIEUSUACHUA>(DataProvider.Ins.DB.PHIEUSUACHUAs);
            });
            ShowCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                PhieuSuaChua phieuSuaChua = new PhieuSuaChua();
                phieuSuaChua.ShowDialog();
                ListPhieuSuaChua = new ObservableCollection<PHIEUSUACHUA>(DataProvider.Ins.DB.PHIEUSUACHUAs);
            });
            EditCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                PhieuSuaChua phieuSuaChua = new PhieuSuaChua();
                phieuSuaChua.ShowDialog();
                ListPhieuSuaChua = new ObservableCollection<PHIEUSUACHUA>(DataProvider.Ins.DB.PHIEUSUACHUAs);
            });
            DeleteCommand = new RelayCommand<Window>((p) => { return true; }, (p) =>
            {
                PhieuSuaChua phieuSuaChua = new PhieuSuaChua();
                phieuSuaChua.ShowDialog();
                ListPhieuSuaChua = new ObservableCollection<PHIEUSUACHUA>(DataProvider.Ins.DB.PHIEUSUACHUAs);
            });
            #region Tìm kiếm
            TimKiemTheoMaNVCommand = new RelayCommand<TextBox>((p) => { return true; }, p =>
            {
                _MaNhanVien = p.Text;
                TimKiem();
            });
            TimKiemTheoNgaySCCommand = new RelayCommand<DatePicker>((p) => { return true; }, p =>
            {
                _NgaySuaChua = p.SelectedDate;
                TimKiem();
            });
            TimKiemTheoTrangThaiCommand = new RelayCommand<CheckBox>((p) => { return true; }, p =>
            {
                if (p.IsChecked == true)
                {
                    ListTrangThai.Add(p.Content.ToString());
                }
                else
                    ListTrangThai.Remove(p.Content.ToString());
                TimKiem();
            });
            #endregion
        }

        void TimKiem()
        {
            _ListPhieuSuaChua.Clear();
            var PhieuSuaChuas = DataProvider.Ins.DB.PHIEUSUACHUAs.ToList();
            if (_MaNhanVien != "")
            {
                PhieuSuaChuas = PhieuSuaChuas.Where(x => x.MaNhanVien.Contains(_MaNhanVien)).ToList();
            }
            if (_NgaySuaChua != null && _NgaySuaChua != DateTime.MinValue)
            {
                PhieuSuaChuas = PhieuSuaChuas.Where(x => x.NgaySuaChua.Equals(_NgaySuaChua)).ToList();
            }
            if (ListTrangThai.Count > 0)
            {
                foreach (var i in ListTrangThai)
                {
                    PhieuSuaChuas = PhieuSuaChuas.Where(x => x.TrangThai == i).ToList();
                }
            }
            foreach (var item in PhieuSuaChuas)
            {
                PHIEUSUACHUA pHIEUSUACHUA = new PHIEUSUACHUA();
                pHIEUSUACHUA = item;
                _ListPhieuSuaChua.Add(pHIEUSUACHUA);
            }
        }
    }
}
