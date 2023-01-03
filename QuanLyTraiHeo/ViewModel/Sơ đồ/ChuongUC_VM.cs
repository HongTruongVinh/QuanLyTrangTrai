using QuanLyTraiHeo.Model;
using QuanLyTraiHeo.View.UC;
using QuanLyTraiHeo.View.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace QuanLyTraiHeo.ViewModel
{
    public class ChuongUC_VM: BaseViewModel
    {
        public int _SoLuongHeo;

        #region command
        public ICommand OpenLichChuongCommand { get; set; }
        public ICommand OpenListHeoCommand { get; set; }
        #endregion

        public ChuongUC_VM()
        {
            OpenLichChuongCommand = new RelayCommand<FrameworkElement>((p) => { return true; }, p => { OpendLichChuong(p); });

            OpenListHeoCommand = new RelayCommand<FrameworkElement>((p) => { return true; }, p => { OpendListHeo(p); });
        }

        void OpendLichChuong(FrameworkElement p)
        {
            if (p == null) return;

            CHUONGTRAI chuong = p.Tag as CHUONGTRAI;

            wDSLichChuong wd = new wDSLichChuong();
            DSLichChuongVM dsLichChuong = new DSLichChuongVM(LayWindow(p as IconChuongUC)) { MaChuong = chuong.MaChuong, LoaiChuong = DataProvider.Ins.DB.LOAICHUONGs.Where(x => x.MaLoaiChuong == chuong.MaLoaiChuong).SingleOrDefault().TenLoai, SucChuaToiDa = chuong.SuaChuaToiDa, SoLuongHeo = _SoLuongHeo };
            wd.DataContext = dsLichChuong;
            wd.ShowDialog();

        }

        void OpendListHeo(FrameworkElement p)
        {
            if (p == null) return;

            CHUONGTRAI chuong = p.Tag as CHUONGTRAI;

            wDSHeo wd = new wDSHeo();
            wd.DataContext = new DSHeoVM(chuong);
            wd.ShowDialog();

        }

        SoDoVM LayWindow(IconChuongUC p)
        {
            FrameworkElement window = GetFrameworkElement(p);
            var w = (Window)window;
            if (w != null)
            {
                return w.DataContext as SoDoVM;
            }
            return null;
        }

        FrameworkElement GetFrameworkElement(IconChuongUC p)
        {
            FrameworkElement parent = p;
            while (parent.Parent != null)
            {
                parent = parent.Parent as FrameworkElement;
            }
            return parent;
        }
    }
}
