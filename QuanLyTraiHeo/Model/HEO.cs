//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QuanLyTraiHeo.Model
{
    using QuanLyTraiHeo.ViewModel;
    using System;
    using System.Collections.Generic;
    
    public partial class HEO:BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HEO()
        {
            this.CT_PHIEUHEO = new HashSet<CT_PHIEUHEO>();
            this.LICHPHOIGIONGs = new HashSet<LICHPHOIGIONG>();
            this.LICHPHOIGIONGs1 = new HashSet<LICHPHOIGIONG>();
            this.LICHTIEMHEOs = new HashSet<LICHTIEMHEO>();
        }
    
        public string MaHeo { get; set; }
        public string MaLoaiHeo { get; set; }
        public string MaGiongHeo { get; set; }
        private string _GioiTinh;
        public string GioiTinh { get => _GioiTinh; set { _GioiTinh = value; OnPropertyChanged(); } }
        private Nullable<System.DateTime> _NgaySinh;
        public Nullable<System.DateTime> NgaySinh { get=>_NgaySinh; set { _NgaySinh = value; OnPropertyChanged(); } }
        private Nullable<int> _TrongLuong;
        public Nullable<int> TrongLuong { get=> _TrongLuong; set { _TrongLuong = value; OnPropertyChanged(); } }
        private string _MaChuong;
        public string MaChuong { get=> _MaChuong; set { _MaChuong = value; OnPropertyChanged(); } }
        public string MaHeoCha { get; set; }
        public string MaHeoMe { get; set; }
        private string _NguonGoc;
        public string NguonGoc { get=>_NguonGoc; set { _NguonGoc = value; OnPropertyChanged(); } }
        private string _TinhTrang;
        public string TinhTrang { get=>_TinhTrang; set { _TinhTrang = value; OnPropertyChanged(); } }
    
        public virtual CHUONGTRAI CHUONGTRAI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEUHEO> CT_PHIEUHEO { get; set; }
        public GIONGHEO _GIONGHEO;
        public virtual GIONGHEO GIONGHEO { get => _GIONGHEO; set { _GIONGHEO = value; OnPropertyChanged(); } }
        public LOAIHEO _LOAIHEO;
        public virtual LOAIHEO LOAIHEO { get=>_LOAIHEO; set { _LOAIHEO = value; OnPropertyChanged(); } }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LICHPHOIGIONG> LICHPHOIGIONGs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LICHPHOIGIONG> LICHPHOIGIONGs1 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LICHTIEMHEO> LICHTIEMHEOs { get; set; }
    }
}
