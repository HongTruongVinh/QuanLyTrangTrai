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
    
    public partial class PHIEUKIEMKHO:BaseViewModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PHIEUKIEMKHO()
        {
            this.CT_PHIEUKIEMKHO = new HashSet<CT_PHIEUKIEMKHO>();
        }
    
        public string SoPhieu { get; set; }
        public Nullable<System.DateTime> NgayLap { get; set; }
        public string MaNhanVien { get; set; }
        public string GhiChu { get; set; }
        private string _KetQua;
        public string KetQua { get =>_KetQua; set { _KetQua = value; OnPropertyChanged(); } }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_PHIEUKIEMKHO> CT_PHIEUKIEMKHO { get; set; }
        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}